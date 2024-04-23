using CapaData;
using CapaDatos;
using CapaEntidad;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_Proveedores
    {
        CD_Proveedores objProveedores = new CD_Proveedores();
        public void agregarProveedor(Proveedor proveedor)
        {
            objProveedores.agregarProveedor(proveedor);
        }
        public void actualizarProveedor(Proveedor proveedor, String idProveedor)
        {
            objProveedores.actualizarProveedor(proveedor, idProveedor);

        }
        public void eliminarProveedor(string idProveedor)
        {
            objProveedores.eliminarProveedor(idProveedor);
        }
        public Task<List<Proveedor>> BuscarProveedorPorNombre(string nombreProveedor)
        {
            return objProveedores.BuscarProveedorPorNombre(nombreProveedor);
        }
        public Task<List<Proveedor>> BuscarProveedorPorCodigo(string codigoProveedor)
        {
            return objProveedores.BuscarProveedorPorCodigo(codigoProveedor);
        }
        public Task<List<Proveedor>> BuscarProveedorPorRUC(string rucProveedor)
        {
            return objProveedores.BuscarProveedorPorRUC(rucProveedor);
        }
    }
}
