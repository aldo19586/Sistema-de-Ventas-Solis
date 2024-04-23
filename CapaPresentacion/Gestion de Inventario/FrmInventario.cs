using CapaDatos;
using CapaDomain;
using CapaEntidad;
using CapaEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInventario : FormBase
    {
        CD_Procedimientos procedimientos = new();
        CDo_Inventario inventario = new();
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            cargarInventario();
            txtMontoTotal.Text = inventario.sumarInventario(dataGridView1).ToString();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].Width = 140;
            dataGridView1.Columns[7].Width = 140;




        }
        private void cargarInventario()
        {
            dataGridView1.DataSource = procedimientos.cargarDatos<Inventario>("inventario");
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
