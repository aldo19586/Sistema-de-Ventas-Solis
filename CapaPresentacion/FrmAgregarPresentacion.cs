using CapaDominio;
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
    public partial class FrmAgregarPresentacion : FormBase
    {

        CDo_Procedimientos procedimientos = new();
        CDo_Presentaciones presentaciones = new();
        Presentacion presentacion = new();
        public FrmAgregarPresentacion(FrmPresentacion Presentacion)
        {
            InitializeComponent();
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarPresentacion_Load(object sender, EventArgs e)
        {
            generarCodigo();
        }
        private void generarCodigo()
        {
            txtCodigoPre.Text = procedimientos.generarCodigo("PRES");
        }

        private void btnGuardarPresentacion_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {
            try
            {
                if (txtCodigoPre.Text == string.Empty ||
                    txtNombrePre.Text == string.Empty ||
                    txtDescripcionPre.Text == string.Empty)
                {
                    MessageBox.Show("PORFAVOR COMPLETAR TODOS LOS CAMPOS", "Agregar Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    presentacion.codigoPre = txtCodigoPre.Text.Trim();
                    presentacion.nombrePre = txtNombrePre.Text.Trim();
                    presentacion.descripcionPre = txtDescripcionPre.Text.Trim();


                    presentaciones.agregarPresentacion(presentacion);
                    MessageBox.Show("SE AGREGO LA PRESENTACION EXITOSAMENTE", "Agregar  Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles(this);
                    generarCodigo();
                    txtNombrePre.Focus();
                    Agregar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("LA PRESENTACION NO FUE AGREADO POR : " + ex.Message, "Agregar Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public void limpiarControles(Form form)
        {
            foreach (var xCtrl in form.Controls)
                if (xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = string.Empty;
                }
            {

            }
        }
    }
}
