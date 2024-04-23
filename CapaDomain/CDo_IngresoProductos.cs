using CapaData;
using CapaEntidad;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_IngresoProductos
    {
        CD_IngresoProductos objIngresoProductos = new CD_IngresoProductos();
        public void agregarIngresoProductos(IngresoProductos ingresoProductos)
        {
            objIngresoProductos.agregarIngresoProductos(ingresoProductos);

        }
        public void anularIngresoProductos(IngresoProductos ingresoProductos, string idIngreso)
        {

            objIngresoProductos.anularIngresoProductos(ingresoProductos,idIngreso);
        }
        public List<VistaIngresoProductos> mostrarDatosIngreso(){
            return objIngresoProductos.mostrarDatosIngreso();
        }
        public List<VistaAnularProductos> mostrarDatosIngresoXid(string idIngreso)
        {
            return objIngresoProductos.mostrarDatosIngresoXid(idIngreso);
        }
        public string obtenerNombreProveedorPorId(string idProveedor)
        {
            return objIngresoProductos.obtenerNombreProveedorPorId(idProveedor);
        }
        public string obtenerIdProveedorPorNombre(string nombreProveedor)
        {
            return objIngresoProductos.obtenerIdProveedorPorNombre(nombreProveedor);
        }
        public string obtenerIdIngresoProductoPorId(string idIngreso)
        {
            return objIngresoProductos.obtenerIdIngresoProductoPorId(idIngreso);
        }
        public string obtenerTipoCargoProductoPorCodigo(string codigoPro)
        {
            return objIngresoProductos.obtenerTipoCargoProductoPorCodigo(codigoPro);
        }
        public string obtenerCodigoProductoPorId(string idPro)
        {
            return objIngresoProductos.obtenerCodigoProductoPorId(idPro);
        }
        public string obtenerPrecioVentaProductoPorId(string idPro)
        {
            return objIngresoProductos.obtenerPrecioVentaProductoPorId(idPro);
        }
        public string obtenerCantidadProPorCodigoPro(string codigoPro)
        {
            return objIngresoProductos.obtenerCantidadProPorCodigoPro(codigoPro);
        }
        public async Task<List<VistaIngresoProductos>> BuscarIngresoProductoPorNombre(string nombreIngreso)
        {
            return await objIngresoProductos.BuscarIngresoProductoPorNombre(nombreIngreso);
        }
        public async Task<List<VistaIngresoProductos>> BuscarIngresoProductoPorFecha(string fechaIngreso)
        {
            return await objIngresoProductos.BuscarIngresoProductoPorFecha(fechaIngreso);
        }
        public async Task<List<VistaIngresoProductos>> BuscarIngresoProductoPorComprobante(string comprobanteIngreso)
        {
            return await objIngresoProductos.BuscarIngresoProductoPorComprobante(comprobanteIngreso);
        }
    }
}
