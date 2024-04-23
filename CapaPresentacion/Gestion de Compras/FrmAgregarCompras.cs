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
    public partial class FrmAgregarCompras : FormBase
    {
        CDo_Procedimientos procedimientos = new CDo_Procedimientos();
        CDo_IngresoProductos ingresosProductos = new CDo_IngresoProductos();
        IngresoProductos ingresoProducto = new IngresoProductos();
        CDo_DetalleIngresos detalleIngresos = new CDo_DetalleIngresos();
        DetalleIngresos detalleIngreso = new DetalleIngresos();
        CDo_Inventario inventarios = new CDo_Inventario();
        Inventario inventario = new Inventario();
        public FrmAgregarCompras(FrmCompras Compras)
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
        private void FrmAgregarCompra_Load(object sender, EventArgs e)
        {
            mejorarVista();
            correlativo();
            
        }
        private void mejorarVista()
        {
            dataGridViewCompras.Columns[0].Visible = false;
            dataGridViewCompras.Columns[1].Width = 350;
            dataGridViewCompras.Columns[2].Width = 160;
            dataGridViewCompras.Columns[3].Width = 160;
            dataGridViewCompras.Columns[4].Width = 180;

            dataGridViewCompras.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompras.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCompras.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCompras.Columns[3].DefaultCellStyle.Format = "#,##0.00";
            dataGridViewCompras.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            procedimientos.formatoMoneda(txtCostoUnitarioProducto);
            procedimientos.formatoMoneda(txtCostoTotalCompra);



        }
        private void correlativo()
        {
            txtIdIngreso.Text = procedimientos.generarCodigo("NUM");
            txtNumIngreso.Text = "INGR" + procedimientos.generarCodigoOrdenado("ingresoProductos");
            txtIdDetalle.Text = procedimientos.generarCodigo("DETA");
        }


        private void btnBuscarProveedorCompra_Click(object sender, EventArgs e)
        {
            FrmVistaProveedores vistaProveedores = new FrmVistaProveedores();
            vistaProveedores.ShowDialog();
            try
            {
                if (vistaProveedores.DialogResult == DialogResult.OK)
                {
                    txtIdProveedor.Text = vistaProveedores.dataGridViewProveedores.Rows[vistaProveedores.dataGridViewProveedores.CurrentRow.Index].Cells[0].Value.ToString();
                    txtNombrePve.Text = vistaProveedores.dataGridViewProveedores.Rows[vistaProveedores.dataGridViewProveedores.CurrentRow.Index].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista", "Seleccionar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnBuscarProductoCompra_Click(object sender, EventArgs e)
        {
            FrmVistaProductos vistaProductos = new FrmVistaProductos();
            vistaProductos.ShowDialog();
            try
            {
                if (vistaProductos.DialogResult == DialogResult.OK)
                {
                    txtIdProducto.Text = vistaProductos.dataGridViewProductos.Rows[vistaProductos.dataGridViewProductos.CurrentRow.Index].Cells[0].Value.ToString();
                    txtCodigoProducto.Text = vistaProductos.dataGridViewProductos.Rows[vistaProductos.dataGridViewProductos.CurrentRow.Index].Cells[1].Value.ToString();
                    txtNombreProducto.Text = vistaProductos.dataGridViewProductos.Rows[vistaProductos.dataGridViewProductos.CurrentRow.Index].Cells[2].Value.ToString();
                    txtCostoUnitarioProducto.Text = vistaProductos.dataGridViewProductos.Rows[vistaProductos.dataGridViewProductos.CurrentRow.Index].Cells[4].Value.ToString();
                    txtPresentacionProducto.Text = vistaProductos.dataGridViewProductos.Rows[vistaProductos.dataGridViewProductos.CurrentRow.Index].Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista", "Seleccionar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarProductoCompra_Click(object sender, EventArgs e)
        {
            agregarDetalle();
        }
        public static int contFila = 0;
        public static decimal Total;
        private void agregarDetalle()
        {
            try
            {

                decimal SubTotal = 0;
                if (txtIdProducto.Text == string.Empty ||
                    txtNombreProducto.Text == string.Empty ||
                    txtCantidadProducto.Text == string.Empty ||
                    txtCostoUnitarioProducto.Text == string.Empty ||
                    txtPresentacionProducto.Text == string.Empty)
                {
                    MessageBox.Show("Debe completar todos los campos del detalle ingreso.", "Agregar Detalle Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    bool Existe = false;
                    int numFila = 0;
                    if (contFila == 0)
                    {
                        decimal costoUnitario = Convert.ToDecimal(txtCostoUnitarioProducto.Text);
                        string costoFormateado = costoUnitario.ToString("N2");
                        SubTotal = Convert.ToDecimal(txtCantidadProducto.Text) * Convert.ToDecimal(txtCostoUnitarioProducto.Text);
                        dataGridViewCompras.Rows.Add(txtIdProducto.Text, txtNombreProducto.Text, txtCantidadProducto.Text, costoFormateado, txtPresentacionProducto.Text, SubTotal.ToString("N2"));
                        dataGridViewCompras.ClearSelection();
                        limpiarDetalle();
                        contFila++;

                    }
                    else
                    {

                        foreach (DataGridViewRow row in dataGridViewCompras.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == txtIdProducto.Text)
                            {
                                Existe = true;
                                numFila = row.Index;
                            }

                        }
                        if (Existe == true)
                        {

                            SubTotal = Convert.ToDecimal(txtCantidadProducto.Text) * Convert.ToDecimal(txtCostoUnitarioProducto.Text);
                            dataGridViewCompras.Rows[numFila].Cells[2].Value = Convert.ToDouble(txtCantidadProducto.Text) + Convert.ToDouble(dataGridViewCompras.Rows[numFila].Cells[2].Value.ToString());
                            dataGridViewCompras.Rows[numFila].Cells[5].Value = (SubTotal + Convert.ToDecimal(dataGridViewCompras.Rows[numFila].Cells[5].Value.ToString()));
                            limpiarDetalle();
                        }
                        else
                        {
                            decimal costoUnitario = Convert.ToDecimal(txtCostoUnitarioProducto.Text);
                            string costoFormateado = costoUnitario.ToString("N2");
                            SubTotal = Convert.ToDecimal(txtCantidadProducto.Text) * Convert.ToDecimal(txtCostoUnitarioProducto.Text);
                            dataGridViewCompras.Rows.Add(txtIdProducto.Text, txtNombreProducto.Text, txtCantidadProducto.Text, costoFormateado, txtPresentacionProducto.Text, SubTotal.ToString("N2"));
                            dataGridViewCompras.ClearSelection();
                            limpiarDetalle();
                            contFila++;
                        }

                    }
                    Total = 0;
                    foreach (DataGridViewRow row in dataGridViewCompras.Rows)
                    {
                        Total += Convert.ToDecimal(row.Cells[5].Value);
                    }
                    txtCostoTotalCompra.Text = Total.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no fue agregado por :" + ex.Message, "Agregar Detalle Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProductoCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (contFila > 0)
                {
                    Total = Total - Convert.ToDecimal(dataGridViewCompras.Rows[dataGridViewCompras.CurrentRow.Index].Cells[5].Value.ToString());
                    txtCostoTotalCompra.Text = Total.ToString("N2");
                    dataGridViewCompras.Rows.RemoveAt(dataGridViewCompras.CurrentRow.Index);
                    contFila--;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay filas para eliminar" + ex.Message, "Eliminar Fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     
        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {
            try
            {
                if (txtNumIngreso.Text == string.Empty ||
                    txtNombrePve.Text == string.Empty ||
                    txtNumComprobante.Text == string.Empty
                 )
                {
                    MessageBox.Show("Debe completar todos los campos por favor", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ingresoProducto.idIngreso = txtIdIngreso.Text;
                    ingresoProducto.numIngreso = txtNumIngreso.Text;
                    ingresoProducto.idProveedor = txtIdProveedor.Text;
                    ingresoProducto.fechaIngreso = dateTimePickerFecha.Value.ToString();
                    ingresoProducto.comprobante = txtNumComprobante.Text.ToString();
                    ingresoProducto.montoTotal = txtCostoTotalCompra.Text;
                    ingresoProducto.estado = "Emitido";
                    
                    foreach (DataGridViewRow row in dataGridViewCompras.Rows)
                    {
                        detalleIngreso.idIngreso = txtIdIngreso.Text;
                        detalleIngreso.idProducto = row.Cells[0].Value.ToString();
                        detalleIngreso.nombrePro = row.Cells[1].Value.ToString();
                        detalleIngreso.cantidadPro = row.Cells[2].Value.ToString();
                        detalleIngreso.costoUnitario = row.Cells[3].Value.ToString();
                        detalleIngreso.subTotal = row.Cells[5].Value.ToString();
                       
                        detalleIngresos.agregarDetalleIngreso(detalleIngreso);

                        inventario.codigoPro = ingresosProductos.obtenerCodigoProductoPorId(detalleIngreso.idProducto); ;
                        inventario.nombrePro = detalleIngreso.nombrePro;
                        inventario.costoUnitarioPro = detalleIngreso.costoUnitario;
                        inventario.tipoCargoPro = ingresosProductos.obtenerTipoCargoProductoPorCodigo(inventario.codigoPro);
                        inventario.cantidad =(Convert.ToDecimal(ingresosProductos.obtenerCantidadProPorCodigoPro(inventario.codigoPro))+Convert.ToDecimal(detalleIngreso.cantidadPro)).ToString() ;
                        inventario.precioVentaPro = ingresosProductos.obtenerPrecioVentaProductoPorId(detalleIngreso.idProducto);
                        inventario.montoTotal = (Convert.ToDouble(inventario.costoUnitarioPro)*Convert.ToDouble(inventario.cantidad)).ToString();
                        inventarios.actualizarInventario(inventario, inventario.codigoPro);
                    }
                    
                    ingresosProductos.agregarIngresoProductos(ingresoProducto);
                    MessageBox.Show("Los productos fueron agregados correctamente", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    procedimientos.limpiarControles(this);
                    txtIdDetalle.Text = string.Empty;
                    txtCostoTotalCompra.Text = "0.00";
                    Agregar();
                    limpiarDetalle();
                    limpiarCampos();
                    correlativo();
                    return true;
                }

            }
            catch (Exception ex)
            {
                // Agregar más detalles a la excepción
                string mensaje = "El ingreso del producto no fue agregado. Detalles: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mensaje += Environment.NewLine + "Detalles internos: " + ex.InnerException.Message;
                }

                // Mostrar el mensaje de error
                MessageBox.Show(mensaje, "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public void limpiarDetalle()
        {
            txtIdProducto.Text = string.Empty;
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtCantidadProducto.Text = string.Empty;
            txtCostoUnitarioProducto.Text = string.Empty;
            txtPresentacionProducto.Text = string.Empty;
            btnBuscarProductoCompra.Focus();
        }
        private void limpiarCampos()
        {
            txtIdIngreso.Text = string.Empty;
            txtNumIngreso.Text = string.Empty;
            txtIdProveedor.Text = string.Empty;
            txtNombrePve.Text = string.Empty;
            txtNumComprobante.Text = string.Empty;
            dataGridViewCompras.ClearSelection();

        }
        private void btnBuscarProductoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCantidadProducto.Focus();
                e.Handled = true;
            }
        }
        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAgregarProductoCompra.Focus();
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
