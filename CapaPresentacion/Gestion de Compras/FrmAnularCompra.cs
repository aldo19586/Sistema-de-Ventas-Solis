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

namespace CapaPresentacion.Gestion_de_Compras
{
    public partial class FrmAnularCompra : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_IngresoProductos ingresosProductos = new();
        IngresoProductos ingresoProducto = new();
        DetalleIngresos detalleIngreso = new();
        CDo_DetalleIngresos detalleIngresos = new();
        Inventario inventario = new();
        CDo_Inventario inventarios = new();
        public FrmAnularCompra(FrmCompras Compras)
        {
            InitializeComponent();
        }
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        // Cambiar el modificador de acceso del DateTimePicker a public
        public System.Windows.Forms.DateTimePicker DateTimePickerFecha
        {
            get { return dateTimePickerFecha; }
            set { dateTimePickerFecha = value; }
        }
        private void FrmAnularCompra_Load(object sender, EventArgs e)
        {
            cargarCompras();
        }
        private void cargarCompras()
        {

            dataGridViewCompras.DataSource = ingresosProductos.mostrarDatosIngresoXid(txtIdIngreso.Text.ToString());
            dataGridViewCompras.ClearSelection();
        }

        private void btnGuardarAnularCompra_Click(object sender, EventArgs e)
        {
            var listInventarios = procedimientos.cargarDatos<Inventario>("inventario");
            try
            {
                if (string.IsNullOrEmpty(txtNumIngreso.Text) ||
                    string.IsNullOrEmpty(txtNombrePve.Text) ||
                    string.IsNullOrEmpty(txtNumComprobante.Text))
                {
                    MessageBox.Show("Debe completar todos los campos por favor", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ingresoProducto.id = txtIdIngreso.Text;
                    ingresoProducto.idIngreso = ingresosProductos.obtenerIdIngresoProductoPorId(ingresoProducto.id);
                    ingresoProducto.numIngreso = txtNumIngreso.Text;
                    ingresoProducto.idProveedor = txtIdProveedor.Text;
                    ingresoProducto.fechaIngreso = dateTimePickerFecha.Value.ToString();
                    ingresoProducto.comprobante = txtNumComprobante.Text;
                    ingresoProducto.montoTotal = txtCostoTotalCompra.Text;
                    ingresoProducto.estado = "Anulado";

                    foreach (DataGridViewRow row in dataGridViewCompras.Rows)
                    {
                        // Obtener los valores de la fila
                        detalleIngreso.idIngreso = ingresoProducto.idIngreso;
                        detalleIngreso.idProducto = row.Cells[1].Value.ToString();
                        detalleIngreso.nombrePro = row.Cells[2].Value.ToString();
                        detalleIngreso.cantidadPro = row.Cells[3].Value.ToString();
                        detalleIngreso.costoUnitario = row.Cells[4].Value.ToString();
                        detalleIngreso.subTotal = row.Cells[6].Value.ToString();

                        // Calcular el monto total del producto
                        double costoUnitario = Convert.ToDouble(detalleIngreso.costoUnitario);
                        double cantidad = Convert.ToDouble(detalleIngreso.cantidadPro);
                        double montoTotalProducto = costoUnitario * cantidad;

                        // Restar cantidad y monto total del inventario
                        string codigoProducto = ingresosProductos.obtenerCodigoProductoPorId(row.Cells[1].Value.ToString());
                        int cantidadProducto = Convert.ToInt32(cantidad);

                        // Buscar el producto en el inventario
                        var productoInventario = listInventarios.FirstOrDefault(p => p.codigoPro == codigoProducto);
                        if (productoInventario != null)
                        {
                            // Verificar si la cantidad en el inventario es mayor o igual a la cantidad a restar
                            int cantidadEnInventario = Convert.ToInt32(productoInventario.cantidad);
                            if (cantidadEnInventario >= cantidadProducto)
                            {
                                // Restar la cantidad y el monto total
                                productoInventario.cantidad = (cantidadEnInventario - cantidadProducto).ToString();
                                productoInventario.montoTotal = (Convert.ToDouble(productoInventario.montoTotal) - montoTotalProducto).ToString();

                                // Actualizar el inventario en la lista
                                inventarios.actualizarInventario(productoInventario, codigoProducto);
                            }
                            else
                            {
                                MessageBox.Show("No hay suficiente cantidad en el inventario para restar. Cantidad disponible: " + cantidadEnInventario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado en el inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    ingresosProductos.anularIngresoProductos(ingresoProducto, ingresoProducto.id);
                    // Mostrar el mensaje de éxito
                    MessageBox.Show("Se anuló correctamente la compra", "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error
                MessageBox.Show("El ingreso de la compra no fue anulado debido a " + ex.Message, "Agregar Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
