using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCategorias : FormBase
    {
        CD_Procedimientos procedimientos = new();
        public FrmCategorias()
        {
            InitializeComponent();
        }
        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
        private void cargarCategorias()
        {
            dataGridViewCategorias.DataSource = procedimientos.cargarDatos<Categoria>("categorias");
            dataGridViewCategorias.ClearSelection();
        }
        private void agCat_UpdateEventHandler(object sender, FrmAgregarCategoria.UpdateEventArgs args)
        {
            cargarCategorias();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria agregarCategoria = new(this);
            agregarCategoria.UpdateEventHandler += agCat_UpdateEventHandler;
            agregarCategoria.Show();

        }

        private void dataGridViewCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
