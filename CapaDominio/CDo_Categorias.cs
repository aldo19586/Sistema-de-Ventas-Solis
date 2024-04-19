using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class CDo_Categorias
    {
        CD_Categorias objCategorias = new();
        public void agregarCategoria(Categoria categoria)
        {
            objCategorias.agregarCategoria(categoria);

        }
        public string obtenerIdCategoriaPorNombre(string nombreCategoria)
        {
           return objCategorias.obtenerIdCategoriaPorNombre(nombreCategoria);
        }
    }
}
