using CapaDomain;
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
    public partial class FrmVistaProductos : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Productos productos = new();
        CDo_Inventario inventario = new();
        Producto producto = new();
        public FrmVistaProductos()
        {
            InitializeComponent();
        }

        private void FrmVistaProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }
        private void cargarProductos()
        {
            dataGridViewProductos.DataSource = procedimientos.cargarDatos<Producto>("productos");
            dataGridViewProductos.ClearSelection();
        }

        private void dataGridViewProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProductos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
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
                    dataGridViewProductos.DataSource = await productos.BuscarProductoPorCodigo(txtBuscarProveedor.Text);
                }
                else if (cboTipoBuscar.Text == "Nombre")
                {
                    // Realiza la búsqueda por nombre
                    dataGridViewProductos.DataSource = productos.BuscarProductoPorNombre(txtBuscarProveedor.Text);

                }
                else if (cboTipoBuscar.Text == "Descripcion")
                {
                    dataGridViewProductos.DataSource = await productos.BuscarProductoPorDescripcion(txtBuscarProveedor.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado por: " + ex.Message, "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewProductos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
