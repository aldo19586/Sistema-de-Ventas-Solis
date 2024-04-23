using CapaData;
using CapaEntidad;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDomain
{
    public class CDo_Inventario
    {
        CD_Inventario objInventario = new CD_Inventario();
        public void agregarInventario(Inventario inventario)
        {
            objInventario.agregarInventario(inventario);
        }
        public Double sumarInventario(DataGridView dataGridInventario)
        {
           return objInventario.sumarInventario(dataGridInventario);

        }
        public void actualizarInventario(Inventario inventario, string codigoInventario)
        {
            objInventario.actualizarInventario(inventario, codigoInventario);
        }
        public bool eliminarInventario(Inventario inventario, string codigoInventario)
        {
            return objInventario.eliminarInventario(inventario,codigoInventario);
        }
        public string obtenerIdInventarioPorCodigo(string codigoInventario)
        {
            return objInventario.obtenerIdInventarioPorCodigo(codigoInventario);
        }
    }
}
