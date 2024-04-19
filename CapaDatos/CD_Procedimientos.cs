using CapaEntidad;
using FireSharp.Response;
using System.Data;

namespace CapaDatos
{
    public class CD_Procedimientos
    {
        CD_Conexion conexion = new CD_Conexion();
        public List<T> cargarDatos<T>(string tabla)
        {
            var client = conexion.Abrir();
            FirebaseResponse response = client.Get(tabla);

            if (response == null || response.Body == "null")
            {
                // Si no hay respuesta o la respuesta está vacía, devolver una lista vacía
                return new List<T>();
            }

            // Deserializar los datos en una lista de objetos del tipo T
            Dictionary<string, T> data = response.ResultAs<Dictionary<string, T>>();
            List<T> objetos = new List<T>(data.Values);

            // Devolver la lista de objetos del tipo T
            return objetos;
        }

        public string GenerarCodigo(string tipoCodigo )
        {
            string codigo = null;
            // Crear una instancia de la clase Random
            Random random = new Random();

            // Generar un número aleatorio entre 1000000 y 9999999 (7 dígitos)
            codigo = random.Next(1000000, 10000000).ToString();
            return tipoCodigo + codigo;
        }

    }
}
