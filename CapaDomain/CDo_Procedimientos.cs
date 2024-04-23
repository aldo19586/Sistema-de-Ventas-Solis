using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CapaDominio
{
    public class CDo_Procedimientos
    {
        CD_Procedimientos objProcedimientos = new CD_Procedimientos();
        public List<T> cargarDatos<T>(string tabla)
        {
            return objProcedimientos.cargarDatos<T>(tabla);
        }
        public string generarCodigo(string tipoCodigo)
        {
            return objProcedimientos.generarCodigo(tipoCodigo);
        }
        public void llenarComboBox<T>(ComboBox comboBox, string nombreTabla, string nombreElemento) where T : class
        {
            objProcedimientos.llenarComboBox<T>(comboBox, nombreTabla, nombreElemento);
        }
        public byte[] comprimirQR(Image codigoQR, long calidadDeseada)
        {
            return objProcedimientos.comprimirQR(codigoQR, calidadDeseada);
        }
        public void limpiarControles(Form form)
        {
             objProcedimientos.limpiarControles(form);
        }
        public System.Drawing.Image descomprimirImagen(byte[] imagenComprimida)
        {
            return objProcedimientos.descomprimirImagen(imagenComprimida);
        }
        public string generarCodigoOrdenado(string tabla)
        {
            return objProcedimientos.generarCodigoOrdenado(tabla);

        }
        public void formatoMoneda(TextBox xTBox)
        {
            objProcedimientos.formatoMoneda(xTBox);
        }
    }
}
