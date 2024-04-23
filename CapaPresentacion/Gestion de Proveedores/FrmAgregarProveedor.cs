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
    public partial class FrmAgregarProveedor : FormBase

    {
        CDo_Procedimientos procedimientos = new();
        CDo_Proveedores proveedores = new();
        Proveedor proveedor = new();
        public FrmAgregarProveedor(FrmProveedor Proveedor)
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

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {
            generarCodigo();
        }
        private void generarCodigo()
        {
            txtCodigoPve.Text = procedimientos.generarCodigo("PROV");
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
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
                    MessageBox.Show("POR FAVOR COMPLETAR TODOS LOS CAMPOS", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                proveedor.codigoPve = txtCodigoPve.Text.Trim();
                proveedor.nombrePve = txtNombrePve.Text.Trim();
                proveedor.rucPve = txtRucPve.Text.Trim();
                proveedor.direccionPve = txtDireccionPve.Text.Trim();
                proveedor.telefonoPve = txtTelefonoPve.Text.Trim();
                proveedor.EmailPve = txtEmailPve.Text.Trim();



                // Call the method to add the product to Firebase
                proveedores.agregarProveedor(proveedor);


                MessageBox.Show("EL PROVEEDOR FUE AGREGADO EXITOSAMENTE", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                procedimientos.limpiarControles(this);
                generarCodigo();
                txtNombrePve.Focus();
                Agregar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"EL PRODUCTO NO FUE AGREGADO POR: {ex.Message}", "Agregar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void txtCodigoPve_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
                btnGuardarProveedor.Focus();
                e.Handled = true;
            }
        }
    }
}
