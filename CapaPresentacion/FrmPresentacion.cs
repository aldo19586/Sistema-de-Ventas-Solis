using CapaDatos;
using CapaEntidad;
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
    public partial class FrmPresentacion : FormBase
    {
        CD_Procedimientos procedimientos = new();
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
        private void cargarCategorias()
        {
            dataGridViewPresentaciones.DataSource = procedimientos.cargarDatos<Presentacion>("presentaciones");
            dataGridViewPresentaciones.ClearSelection();
        }
        private void agPre_UpdateEventHandler(object sender, FrmAgregarPresentacion.UpdateEventArgs args)
        {
            cargarCategorias();
        }

        private void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            FrmAgregarPresentacion agregarPresentacion = new(this);
            agregarPresentacion.UpdateEventHandler += agPre_UpdateEventHandler;
            agregarPresentacion.Show();
        }

        private void btnActualizarPresentacion_Click(object sender, EventArgs e)
        {

        }
    }
}
