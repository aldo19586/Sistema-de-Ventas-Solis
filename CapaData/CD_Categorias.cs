using CapaEntidad;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Categorias
    {
     
        CD_Conexion conexion = new CD_Conexion();

        public void agregarCategoria(Categoria categoria)
        {
            var client = conexion.Abrir();
            // Obtener una referencia a la ubicación donde deseas almacenar los productos
            FirebaseResponse response = client.Push("categorias", categoria);

        }
        public string obtenerIdCategoriaPorNombre(string nombreCategoria)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("categorias")
                .ResultAs<Dictionary<string, Categoria>>();

            foreach (var categoria in response)
            {
                if (categoria.Value.nombreCat == nombreCategoria)
                {
                    return categoria.Key;
                }
            }

            return null;
        }
    }
}
