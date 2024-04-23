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
    public partial class FrmProveedor : FormBase
    {

        CDo_Procedimientos procedimientos = new();
        CDo_Proveedores proveedores = new();
        Proveedor proveedor = new();
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }
        private void cargarProveedores()
        {
            dataGridViewProveedores.DataSource = procedimientos.cargarDatos<Proveedor>("proveedores");
            dataGridViewProveedores.ClearSelection();
        }
        private void agPve_UpdateEventHandler(object sender, FrmAgregarProveedor.UpdateEventArgs args)
        {
            cargarProveedores();
        }
        private void acPve_UpdateEventHandler(object sender, FrmActualizarProveedor.UpdateEventArgs args)
        {
            cargarProveedores();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            FrmAgregarProveedor agregarProveedor = new(this);
            agregarProveedor.UpdateEventHandler += agPve_UpdateEventHandler;
            agregarProveedor.ShowDialog();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewProveedores.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmActualizarProveedor actualizarProveedor = new FrmActualizarProveedor(this);
                        actualizarProveedor.UpdateEventHandler += acPve_UpdateEventHandler;
                        actualizarProveedor.txtIdPve.Text = dataGridViewProveedores.SelectedRows[0].Cells[0].Value.ToString();
                        actualizarProveedor.txtCodigoPve.Text = dataGridViewProveedores.SelectedRows[0].Cells[1].Value.ToString();
                        actualizarProveedor.txtNombrePve.Text = dataGridViewProveedores.SelectedRows[0].Cells[2].Value.ToString();
                        actualizarProveedor.txtRucPve.Text = dataGridViewProveedores.SelectedRows[0].Cells[3].Value.ToString();
                        actualizarProveedor.txtDireccionPve.Text = dataGridViewProveedores.SelectedRows[0].Cells[4].Value.ToString();
                        actualizarProveedor.txtTelefonoPve.Text = dataGridViewProveedores.SelectedRows[0].Cells[5].Value.ToString();
                        actualizarProveedor.txtEmailPve.Text = dataGridViewProveedores.SelectedRows[0].Cells[6].Value.ToString();
                        actualizarProveedor.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar.", "Actualizar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewProveedores.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el producto?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        String idProveedor = dataGridViewProveedores.SelectedRows[0].Cells[0].Value.ToString();

                        proveedores.eliminarProveedor(idProveedor);
                        cargarProveedores();
                    }


                }
            }
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        public override async void Buscar()
        {
            try
            {
                if (cboTipoBuscar.Text == "Codigo")
                {
                    dataGridViewProveedores.DataSource = await proveedores.BuscarProveedorPorCodigo(txtBuscarProveedor.Text);
                }
                else if (cboTipoBuscar.Text == "Nombre")
                {
                    // Realiza la búsqueda por nombre
                    dataGridViewProveedores.DataSource = proveedores.BuscarProveedorPorNombre(txtBuscarProveedor.Text);

                }
                else if (cboTipoBuscar.Text == "RUC")
                {
                    dataGridViewProveedores.DataSource = await proveedores.BuscarProveedorPorRUC(txtBuscarProveedor.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado por: " + ex.Message, "Buscar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
