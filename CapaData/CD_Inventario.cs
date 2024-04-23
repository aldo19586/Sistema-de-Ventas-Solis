using CapaDatos;
using CapaEntidad;
using CapaEntity;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaData
{
    public class CD_Inventario
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Procedimientos procedimientos = new CD_Procedimientos();
        public void agregarInventario(Inventario inventario)
        {
            var client = conexion.Abrir();
            FirebaseResponse response = client.Push("inventario",inventario);
        }
        public Double sumarInventario(DataGridView dataGridInventario)
        {
            Double Total = 0;
            foreach (DataGridViewRow Row in dataGridInventario.Rows)
            {
                Total += Convert.ToDouble(Row.Cells[5].Value);
            }
            return Total;
        }
        public void actualizarInventario(Inventario inventario, string codigoInventario)
        {
            var client = conexion.Abrir();

            // Primero, necesitas buscar el ID del inventario correspondiente al código dado.
            // Dependiendo de la estructura de tu base de datos, esto puede requerir una consulta específica.
            // Supongamos que ya tienes una forma de obtener el ID del inventario según su código.
            string idInventario = obtenerIdInventarioPorCodigo(codigoInventario); // Debes implementar este método.

            // Verifica si se encontró el ID del inventario.
            if (!string.IsNullOrEmpty(idInventario))
            {
                // Ahora que tienes el ID del inventario, puedes actualizar la base de datos.
                string rutaInventario = $"inventario/{idInventario}";
                client.Set(rutaInventario, inventario);
            }
            else
            {
                // Maneja el caso en el que no se encontró ningún inventario con el código dado.
                // Puedes lanzar una excepción, registrar un mensaje de error, o realizar otra acción apropiada.
                Console.WriteLine("No se encontró ningún inventario con el código proporcionado.");
            }
        }
        public bool eliminarInventario(Inventario objInventario, string codigoInventario)
        {
            var client = conexion.Abrir();
            var inventarios = procedimientos.cargarDatos<Inventario>("inventario");
            bool estado = false;

            // Buscar el ID del inventario correspondiente al código dado.
            string idInventario = obtenerIdInventarioPorCodigo(codigoInventario);

            foreach (var inventario in inventarios)
            {
                // Asegurarse de que el ID del inventario coincida y sea del mismo tipo.
                if (inventario.id == idInventario)
                {
                    int cantidad = Convert.ToInt32(inventario.cantidad);

                    // Verificar si la cantidad actual es mayor que 1 para restar la cantidad pasada como parámetro.
                    if (cantidad > 1)
                    {
                        MessageBox.Show("El producto tiene stock","Gestion de Productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        estado = true;
                    }
                    else
                    {
                        // Si la cantidad es igual o menor que 1, eliminar el inventario.
                        string rutaInventario = $"inventario/{idInventario}";
                        FirebaseResponse response = client.Delete(rutaInventario);
                        estado = true; // Actualizar el estado a true después de eliminar el inventario.
                    }

                    break; // Terminar el bucle una vez que se ha actualizado o eliminado el inventario.
                }
            }

            return estado;
        }
        public string obtenerIdInventarioPorCodigo(string codigoInventario)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("inventario")
                .ResultAs<Dictionary<string, Inventario>>();

            foreach (var inventario in response)
            {
                if (inventario.Value.codigoPro == codigoInventario)
                {
                    return inventario.Key;
                }
            }

            return null;
        }
    }
}
