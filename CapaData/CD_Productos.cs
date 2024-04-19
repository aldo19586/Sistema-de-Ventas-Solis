using CapaEntidad;
using FireSharp;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Productos
    {
        CD_Conexion conexion = new CD_Conexion();
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
      

        

    }
}
