using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{   

    public class CDo_Productos
    {
        CD_Productos objProductos = new();
        public void agregarProducto(Producto producto) {
            objProductos.agregarProducto(producto);
        }
    }
}
