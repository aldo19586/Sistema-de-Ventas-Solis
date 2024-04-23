using CapaDatos;
using CapaEntidad;
using CapaEntity;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    
    public class CD_Proveedores
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Procedimientos procedimientos = new CD_Procedimientos();
        public void agregarProveedor(Proveedor proveedor)
        {

            var client = conexion.Abrir();
            // Obtener una referencia a la ubicación donde deseas almacenar los productos
            FirebaseResponse response = client.Push("proveedores", proveedor);
        }
        public void actualizarProveedor(Proveedor proveedor, string idProveedor)
        {
            var client = conexion.Abrir();
            string rutaProducto = $"proveedores/{idProveedor}";
            client.Set(rutaProducto, proveedor);
        }
        public void eliminarProveedor(string idProveedor)
        {

            var client = conexion.Abrir();
            string rutaProveedor = $"proveedores/{idProveedor}";

            // Eliminar el producto de la base de datos Firebase
            FirebaseResponse response = client.Delete(rutaProveedor);


        }
        public async Task<List<Proveedor>> BuscarProveedorPorNombre(string nombreProveedor)
        {
            try
            {
                // Cargar datos
                List<Proveedor> proveedoresEncontrados = procedimientos.cargarDatos<Proveedor>("proveedores");



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(nombreProveedor))
                {
                    // Si es así, retornar la lista completa de productos
                    return proveedoresEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                proveedoresEncontrados = proveedoresEncontrados
                    .Where(p => p.nombrePve.StartsWith(nombreProveedor, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return proveedoresEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<Proveedor>();
            }
        }
        public async Task<List<Proveedor>> BuscarProveedorPorCodigo(string codigoProveedor)
        {
            try
            {
                // Cargar datos
                List<Proveedor> proveedoresEncontrados = procedimientos.cargarDatos<Proveedor>("proveedores");



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(codigoProveedor))
                {
                    // Si es así, retornar la lista completa de productos
                    return proveedoresEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                proveedoresEncontrados = proveedoresEncontrados
                    .Where(p => p.codigoPve.StartsWith(codigoProveedor, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return proveedoresEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<Proveedor>();
            }
        }
        public async Task<List<Proveedor>> BuscarProveedorPorRUC(string rucProveedor)
        {
            try
            {
                // Cargar datos
                List<Proveedor> proveedoresEncontrados = procedimientos.cargarDatos<Proveedor>("proveedores");



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(rucProveedor))
                {
                    // Si es así, retornar la lista completa de productos
                    return proveedoresEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                proveedoresEncontrados = proveedoresEncontrados
                    .Where(p => p.rucPve.StartsWith(rucProveedor, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return proveedoresEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<Proveedor>();
            }
        }
    }
}
