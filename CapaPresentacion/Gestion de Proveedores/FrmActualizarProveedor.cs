using CapaDomain;
using CapaDominio;
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
    public partial class FrmActualizarProveedor : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Proveedores proveedores = new();
        Proveedor proveedor = new();
        public FrmActualizarProveedor(FrmProveedor Proveedor)
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

        private void FrmActualizarProveedor_Load(object sender, EventArgs e)
        {
            btnGuardarActualizarProveedor.Enabled = false;
        }

        public override void Actualizar()
        {
            try
            {


                if (string.IsNullOrWhiteSpace(txtCodigoPve.Text) ||
                    string.IsNullOrWhiteSpace(txtNombrePve.Text) ||
                    string.IsNullOrWhiteSpace(txtRucPve.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccionPve.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefonoPve.Text) ||
                    string.IsNullOrWhiteSpace(txtEmailPve.Text))
                {
                    MessageBox.Show("PORFAVOR COMPLETAR TODOS LOS CAMPOS", "Actualizar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    proveedor.id = txtIdPve.Text.Trim();
                    proveedor.codigoPve = txtCodigoPve.Text.Trim();
                    proveedor.nombrePve = txtNombrePve.Text.Trim();
                    proveedor.rucPve = txtRucPve.Text.Trim();
                    proveedor.direccionPve = txtDireccionPve.Text.Trim();
                    proveedor.telefonoPve = txtTelefonoPve.Text.Trim();
                    proveedor.EmailPve = txtEmailPve.Text.Trim();


                    proveedores.actualizarProveedor(proveedor, proveedor.id);

                    MessageBox.Show("SE ACTUALIZO EL PROVEEDOR EXITOSAMENTE", "Actualizar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception ex)
            {
                string mensajeError = "EL PROVEEDOR NO FUE ACTUALIZADO POR : " + ex.Message + "\n\n";
                mensajeError += "Detalles del error:\n" + ex.StackTrace;

                MessageBox.Show(mensajeError, "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtNombrePve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRucPve.Focus();
                e.Handled = true;
            }
        }

        private void txtRucPve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDireccionPve.Focus();
                e.Handled = true;
            }
        }

        private void txtDireccionPve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTelefonoPve.Focus();
                e.Handled = true;
            }
        }

        private void txtTelefonoPve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmailPve.Focus();
                e.Handled = true;
            }
        }

        private void txtEmailPve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

            }
        }

        private void txtNombrePve_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProveedor.Enabled = true;
        }

        private void txtRucPve_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProveedor.Enabled = true;
        }

        private void txtDireccionPve_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProveedor.Enabled = true;
        }

        private void txtTelefonoPve_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProveedor.Enabled = true;
        }

        private void txtEmailPve_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProveedor.Enabled = true;
        }
    }
}
