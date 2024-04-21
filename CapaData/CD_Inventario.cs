using CapaDatos;
using CapaEntity;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_Inventario
    {
        CD_Conexion conexion = new CD_Conexion();
        public void agregarInventario(Inventario inventario)
        {
            var client = conexion.Abrir();
            FirebaseResponse response = client.Push("inventario",inventario);
        }
    }
}
