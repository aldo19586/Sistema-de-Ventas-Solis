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
    }
}
