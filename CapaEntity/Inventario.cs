using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntity
{
    public class Inventario
    {
        public string id { get; set; }
        public String codigoPro { get; set; }
        public String nombrePro { get; set; }
        public String descripcionPro { get; set; }
        public String costoUnitarioPro { get; set; }
        public String precioVentaPro { get; set; }
        public String tipoCargoPro { get; set; }
        public String categoriaPro { get; set; }
        public String presentacionPro { get; set; }
        public byte[] qrPro { get; set; }
        public int cantidad { get; set; }

    }
}
