using CapaDomain;
using CapaDominio;
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
    public partial class FrmVistaProveedores : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Proveedores proveedores = new();
        Proveedor proveedor = new();
        public FrmVistaProveedores()
        {
            InitializeComponent();
        }

        private void FrmVistaProveedores_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }
        private void cargarProveedores()
        {
            dataGridViewProveedores.DataSource = procedimientos.cargarDatos<Proveedor>("proveedores");
            dataGridViewProveedores.ClearSelection();
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

        private void dataGridViewProveedores_DoubleClick_1(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.Rows.Count == 0)
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
