using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class DetalleIngresos
    {
        public string id { get; set; }
        public String idIngreso { get; set; }
        public String idProducto { get; set; }
        public String nombrePro { get; set; }
        public String cantidadPro { get; set; }
        public String costoUnitario{ get; set; }
        public String subTotal { get; set; }

    }
}
