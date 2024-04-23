using CapaDomain;
using CapaDominio;
using CapaEntidad;
using CapaEntity;
using CapaPresentacion.Gestion_de_Compras;
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
    public partial class FrmCompras : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_IngresoProductos ingresoProductos = new();
        IngresoProductos ingresoProducto = new();
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            cargarCompras();
            mejorarVista();


        }
        private void cargarCompras()
        {

            dataGridViewCompras.DataSource = ingresoProductos.mostrarDatosIngreso();
            dataGridViewCompras.ClearSelection();
        }
        private void mejorarVista()
        {
            dataGridViewCompras.Columns[0].Visible = Visible;
            dataGridViewCompras.Columns[1].Width = 180;
            dataGridViewCompras.Columns[2].Width = 200;
            dataGridViewCompras.Columns[3].Width = 160;
            dataGridViewCompras.Columns[4].Width = 180;

            dataGridViewCompras.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompras.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompras.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCompras.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompras.Columns[5].DefaultCellStyle.Format = "#,##0.00";

        }

        private void agCom_UpdateEventHandler(object sender, FrmAgregarCompras.UpdateEventArgs args)
        {
            cargarCompras();
        }

        private void anCom_UpdateEventHandler(object sender, FrmAnularCompra.UpdateEventArgs args)
        {
            cargarCompras();
        }



        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            FrmAgregarCompras agregarCompras = new FrmAgregarCompras(this);
            agregarCompras.UpdateEventHandler += agCom_UpdateEventHandler;
            agregarCompras.ShowDialog();

        }

        private void btnAnularCompra_Click(object sender, EventArgs e)
        {
            FrmAnularCompra anularCompra = new FrmAnularCompra(this);
            anularCompra.UpdateEventHandler += anCom_UpdateEventHandler;
            anularCompra.txtIdIngreso.Text = dataGridViewCompras.SelectedRows[0].Cells[0].Value.ToString();
            anularCompra.txtNumIngreso.Text = dataGridViewCompras.SelectedRows[0].Cells[1].Value.ToString();
            anularCompra.txtIdProveedor.Text = ingresoProductos.obtenerIdProveedorPorNombre(dataGridViewCompras.SelectedRows[0].Cells[2].Value.ToString());  
            anularCompra.txtNombrePve.Text = dataGridViewCompras.SelectedRows[0].Cells[2].Value.ToString();
            anularCompra.DateTimePickerFecha.Text = dataGridViewCompras.SelectedRows[0].Cells[3].Value.ToString();
            anularCompra.txtNumComprobante.Text = dataGridViewCompras.SelectedRows[0].Cells[4].Value.ToString();
            anularCompra.txtCostoTotalCompra.Text = dataGridViewCompras.SelectedRows[0].Cells[5].Value.ToString();

            anularCompra.ShowDialog();

            /*if (dataGridViewCompras.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para anular.", "Eliminar Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dataGridViewCompras.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar algun registro para anular.", "Eliminar Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    DialogResult result = MessageBox.Show("Esta seguro que desea anular la compra?", "Eliminar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ingresoProducto.id = dataGridViewCompras.SelectedRows[0].Cells[0].Value.ToString();
                        ingresoProducto.idIngreso = ingresoProductos.obtenerIdIngresoProductoPorId(ingresoProducto.id);
                        ingresoProducto.numIngreso = dataGridViewCompras.SelectedRows[0].Cells[1].Value.ToString();
                        ingresoProducto.idProveedor = ingresoProductos.obtenerIdProveedorPorNombre(dataGridViewCompras.SelectedRows[0].Cells[2].Value.ToString());
                        ingresoProducto.fechaIngreso = dataGridViewCompras.SelectedRows[0].Cells[3].Value.ToString();
                        ingresoProducto.comprobante = dataGridViewCompras.SelectedRows[0].Cells[4].Value.ToString();
                        ingresoProducto.montoTotal = dataGridViewCompras.SelectedRows[0].Cells[5].Value.ToString();
                        ingresoProducto.estado = "Anulado";
                        ingresoProductos.anularIngresoProductos(ingresoProducto, ingresoProducto.id);

                        cargarCompras();
                    }


                }
            }*/
        }

        private void txtBuscarCompra_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        public override async void Buscar()
        {
            try
            {
                if (cboTipoBuscar.Text == "Fecha")
                {
                    dataGridViewCompras.DataSource = await ingresoProductos.BuscarIngresoProductoPorFecha(txtBuscarCompra.Text);
                }                                                                                
                else if (cboTipoBuscar.Text == "Nombre")
                {
                    // Realiza la búsqueda por nombre
                    dataGridViewCompras.DataSource = await ingresoProductos.BuscarIngresoProductoPorNombre(txtBuscarCompra.Text);

                }
                else if (cboTipoBuscar.Text == "Comprobante")
                {
                    dataGridViewCompras.DataSource = await ingresoProductos.BuscarIngresoProductoPorComprobante(txtBuscarCompra.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue encontrado por: " + ex.Message, "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
