using CapaData;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDomain
{
    public class CDo_DetalleIngresos

    {
        CD_DetalleIngresos objDetalleIngreso = new CD_DetalleIngresos();
        public void agregarDetalleIngreso(DetalleIngresos detalleIngresos)
        {
            objDetalleIngreso.agregarDetalleIngreso(detalleIngresos);

        }
        public void anularDetalleIngreso(DetalleIngresos detalleIngresos, string idDetalle)
        {

            objDetalleIngreso.anularDetalleIngreso(detalleIngresos,idDetalle);
        }
        public string obtenerIdDetalleProductoPorIdIngreso(string idIngreso)
        {
            return objDetalleIngreso.obtenerIdDetalleProductoPorIdIngreso(idIngreso);
        }
    }
}
