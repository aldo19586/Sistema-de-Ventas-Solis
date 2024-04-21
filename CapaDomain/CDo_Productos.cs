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
        CD_Productos objProductos = new CD_Productos();
        public void agregarProducto(Producto producto) {
            objProductos.agregarProducto(producto);
        }
        public void actualizarProducto(Producto producto,String idProducto)
        {
            objProductos.actualizarProducto(producto,idProducto);

        }
        public void eliminarProducto(string idProducto)
        {
            objProductos.eliminarProducto(idProducto);
        }
        public Task<List<Producto>> BuscarProductoPorNombre(string nombreProducto)
        {
            return objProductos.BuscarProductoPorNombre(nombreProducto);
        }
        public Task<List<Producto>> BuscarProductoPorCodigo(string codigoProducto)
        {
            return objProductos.BuscarProductoPorCodigo(codigoProducto);
        }
        public Task<List<Producto>> BuscarProductoPorDescripcion(string descripcionProducto)
        {
            return objProductos.BuscarProductoPorDescripcion(descripcionProducto);
        }
    }
}
