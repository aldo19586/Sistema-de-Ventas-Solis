using CapaDatos;
using CapaEntity;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_DetalleIngresos
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Procedimientos procedimientos = new CD_Procedimientos();
        public void agregarDetalleIngreso(DetalleIngresos detalleIngresos)
        {
            var client = conexion.Abrir();
            // Obtener una referencia a la ubicación donde deseas almacenar los detalles
            FirebaseResponse response = client.Push("detalleIngresos", detalleIngresos);

        }
        public void anularDetalleIngreso(DetalleIngresos detalleIngresos, string idDetalle)
        {

            var client = conexion.Abrir();
            string rutaDetalleIngreso = $"detalleIngresos/{idDetalle}";
            client.Set(rutaDetalleIngreso, detalleIngresos);
        }
        public string obtenerIdDetalleProductoPorIdIngreso(string idIngreso)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("detalleIngresos")
                .ResultAs<Dictionary<string, DetalleIngresos>>();

            foreach (var detalleProducto in response)
            {
                if (detalleProducto.Value.idIngreso == idIngreso)
                {
                    return detalleProducto.Key; // Ajuste aquí
                }
                
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
    }
}
