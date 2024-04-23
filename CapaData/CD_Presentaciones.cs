using CapaEntidad;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Presentaciones
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Procedimientos procedimientos = new CD_Procedimientos();
        public void agregarPresentacion(Presentacion presentacion)
        {
            var client = conexion.Abrir();
            FirebaseResponse response = client.Push("presentaciones",presentacion);

        }
        public string obtenerIdPresentacionPorNombre(string nombrePresentacion)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("presentaciones")
                .ResultAs<Dictionary<string, Presentacion>>();

            foreach (var presentacion in response)
            {
                if (presentacion.Value.nombrePre == nombrePresentacion)
                {
                    return presentacion.Key;
                }
            }

            return null;
        }
        public string obtenerPresentacionPorIdProducto(string idProducto)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("productos")
                .ResultAs<Dictionary<string, Producto>>();

            foreach (var producto in response)
            {
                if (producto.Key == idProducto)
                {
                    return producto.Value.presentacionPro;
                }
            }

            return null;
        }
        public Presentacion encontrarPresentacion(string nombreBuscado)
        {

            List<Presentacion> listaPresentacion = procedimientos.cargarDatos<Presentacion>("presentaciones");
            // Utiliza LINQ para buscar el objeto con el nombre buscado
            Presentacion presentacionEncontrada = listaPresentacion.FirstOrDefault(p => p.nombrePre == nombreBuscado);

            // Verificar si se encontró la presentación
            return presentacionEncontrada;

        }
    }
}
