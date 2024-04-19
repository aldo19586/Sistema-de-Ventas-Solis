using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return objProcedimientos.GenerarCodigo(tipoCodigo);
        }
    }
}
