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
    public class CDo_Inventario
    {
        CD_Inventario objInventario = new CD_Inventario();
        public void agregarInventario(Inventario inventario)
        {
            objInventario.agregarInventario(inventario);
        }
    }
}
