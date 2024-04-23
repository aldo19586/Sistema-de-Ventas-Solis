using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class CDo_Presentaciones
    {
        CD_Presentaciones presentaciones = new CD_Presentaciones();
        public void agregarPresentacion(Presentacion presentacion)
        {
            presentaciones.agregarPresentacion(presentacion);
        }
        public string obtenerIdPresentacionPorNombre(string nombrePresentacion)
        {
            return presentaciones.obtenerIdPresentacionPorNombre(nombrePresentacion);
        }
       
    }
}
