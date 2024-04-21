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
    public partial class FrmProductos : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Productos productos = new();
        Producto producto = new();

        public FrmProductos()
        {
            InitializeComponent();
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }
        private void cargarProductos()
        {
            dataGridViewProductos.DataSource = procedimientos.cargarDatos<Producto>("productos");
            dataGridViewProductos.ClearSelection();
        }
        private void agPro_UpdateEventHandler(object sender, FrmAgregarProducto.UpdateEventArgs args)
        {
            cargarProductos();
        }
        private void acPro_UpdateEventHandler(object sender, FrmActualizarProducto.UpdateEventArgs args)
        {
            cargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregarProducto = new(this);
            agregarProducto.UpdateEventHandler += agPro_UpdateEventHandler;
            agregarProducto.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para actualizar.", "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewProductos.SelectedRows == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        FrmActualizarProducto actualizarProducto = new FrmActualizarProducto(this);
                        actualizarProducto.UpdateEventHandler += acPro_UpdateEventHandler;
                        actualizarProducto.txtIdPro.Text = dataGridViewProductos.SelectedRows[0].Cells[0].Value.ToString();
                        actualizarProducto.txtCodigoPro.Text = dataGridViewProductos.SelectedRows[0].Cells[1].Value.ToString();
                        actualizarProducto.txtNombrePro.Text = dataGridViewProductos.SelectedRows[0].Cells[2].Value.ToString();
                        actualizarProducto.txtDescripcionPro.Text = dataGridViewProductos.SelectedRows[0].Cells[3].Value.ToString();
                        actualizarProducto.txtCostoUnitarioPro.Text = dataGridViewProductos.SelectedRows[0].Cells[4].Value.ToString();
                        actualizarProducto.txtPrecioVentaPro.Text = dataGridViewProductos.SelectedRows[0].Cells[5].Value.ToString();
                        actualizarProducto.cboTipoCargoPro.Text = dataGridViewProductos.SelectedRows[0].Cells[6].Value.ToString();
                        actualizarProducto.cboCategoria.Text = dataGridViewProductos.SelectedRows[0].Cells[7].Value.ToString();
                        actualizarProducto.cboPresentacion.Text = dataGridViewProductos.SelectedRows[0].Cells[8].Value.ToString();
                        actualizarProducto.pbxQR.Image = procedimientos.descomprimirImagen((byte[])dataGridViewProductos.SelectedRows[0].Cells[9].Value);
                        actualizarProducto.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debe seleccionar algun registro para actualizar.", "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public override void Eliminar()
        {
            if (dataGridViewProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para eliminar.", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        String idProducto = dataGridViewProductos.SelectedRows[0].Cells[0].Value.ToString();
                        productos.eliminarProducto(idProducto);
                        cargarProductos();
                    }


                }
            }

        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        public override async void Buscar()
        {
            try
            {
                if (cboTipoBuscar.Text == "Codigo")
                {
                    dataGridViewProductos.DataSource = await productos.BuscarProductoPorCodigo(txtBuscarProducto.Text);
                }
                else if (cboTipoBuscar.Text == "Nombre")
                {
                    // Realiza la búsqueda por nombre
                    dataGridViewProductos.DataSource =  productos.BuscarProductoPorNombre(txtBuscarProducto.Text);

                }
                else if (cboTipoBuscar.Text == "Descripcion")
                {
                    dataGridViewProductos.DataSource = await productos.BuscarProductoPorDescripcion(txtBuscarProducto.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado por: " + ex.Message, "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
