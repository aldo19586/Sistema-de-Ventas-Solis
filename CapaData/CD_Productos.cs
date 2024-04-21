using CapaEntidad;
using FireSharp;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Productos
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Procedimientos procedimientos = new CD_Procedimientos();

        public void agregarProducto(Producto producto)
        {

            var client = conexion.Abrir();
            // Obtener una referencia a la ubicación donde deseas almacenar los productos
            FirebaseResponse response = client.Push("productos", producto);
        }
        public void actualizarProducto(Producto producto,string idProducto)
        {
            var client = conexion.Abrir();
            string rutaProducto = $"productos/{idProducto}";
            client.Set(rutaProducto,producto);
        }
        public void eliminarProducto(string idProducto)
        {
       
                var client = conexion.Abrir();
                string rutaProducto = $"productos/{idProducto}";

                // Eliminar el producto de la base de datos Firebase
                FirebaseResponse response = client.Delete(rutaProducto);
            
           
        }
        public async Task<List<Producto>> BuscarProductoPorNombre(string nombreProducto)
        {
            try
            {
                // Cargar datos
                List<Producto> productosEncontrados = procedimientos.cargarDatos<Producto>("productos");

         

                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(nombreProducto))
                {
                    // Si es así, retornar la lista completa de productos
                    return productosEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                productosEncontrados = productosEncontrados
                    .Where(p => p.nombrePro.StartsWith(nombreProducto, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return productosEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<Producto>();
            }
        }
        public async Task<List<Producto>> BuscarProductoPorCodigo(string codigoProducto)
        {
            try
            {
                // Cargar datos
                List<Producto> productosEncontrados = procedimientos.cargarDatos<Producto>("productos");



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(codigoProducto))
                {
                    // Si es así, retornar la lista completa de productos
                    return productosEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                productosEncontrados = productosEncontrados
                    .Where(p => p.codigoPro.StartsWith(codigoProducto, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return productosEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<Producto>();
            }
        }
        public async Task<List<Producto>> BuscarProductoPorDescripcion(string descripcionProducto)
        {
            try
            {
                // Cargar datos
                List<Producto> productosEncontrados = procedimientos.cargarDatos<Producto>("productos");



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(descripcionProducto))
                {
                    // Si es así, retornar la lista completa de productos
                    return productosEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                productosEncontrados = productosEncontrados
                    .Where(p => p.descripcionPro.StartsWith(descripcionProducto, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return productosEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<Producto>();
            }
        }





    }
}
