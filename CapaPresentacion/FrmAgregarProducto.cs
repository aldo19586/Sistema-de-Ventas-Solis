using CapaDomain;
using CapaDominio;
using CapaEntidad;
using CapaEntity;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class FrmAgregarProducto : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Productos productos = new();
        Producto producto = new();
        CDo_Inventario inventarios = new();
        Inventario inventario = new();
        private int conteo;
        public FrmAgregarProducto(FrmProductos Productos)
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

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            generarCodigo();
            procedimientos.llenarComboBox<Categoria>(cboCategoria, "categorias", "nombreCat");
            procedimientos.llenarComboBox<Presentacion>(cboPresentacion, "presentaciones", "nombrePre");


        }
        private void generarCodigo()
        {
            txtCodigoPro.Text = procedimientos.generarCodigo("PROD");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescripcionPro.Focus();
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCostoUnitarioPro.Focus();
                e.Handled = true;
            }

        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVentaPro.Focus();
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cboTipoCargoPro.Focus();
                e.Handled = true;
            }

        }

        private void cboTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardarProducto.Focus();
                e.Handled = true;
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Guardar();

        }
        public override bool Guardar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigoPro.Text) ||
                    string.IsNullOrWhiteSpace(txtNombrePro.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcionPro.Text) ||
                    string.IsNullOrWhiteSpace(txtCostoUnitarioPro.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioVentaPro.Text) ||
                    string.IsNullOrWhiteSpace(cboTipoCargoPro.Text) ||
                    string.IsNullOrWhiteSpace(cboCategoria.Text) ||
                    string.IsNullOrWhiteSpace(cboPresentacion.Text) ||
                    pbxQR.Image == null)
                {
                    MessageBox.Show("POR FAVOR COMPLETAR TODOS LOS CAMPOS", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                producto.codigoPro = txtCodigoPro.Text.Trim();
                producto.nombrePro = txtNombrePro.Text.Trim();
                producto.descripcionPro = txtDescripcionPro.Text.Trim();
                producto.presentacionPro = cboPresentacion.Text.Trim();
                producto.precioVentaPro = txtPrecioVentaPro.Text.Trim();
                producto.costoUnitarioPro = txtCostoUnitarioPro.Text.Trim();
                producto.tipoCargoPro = cboTipoCargoPro.Text.Trim();
                producto.categoriaPro = cboCategoria.Text.Trim();
                producto.qrPro = procedimientos.comprimirQR(pbxQR.Image, 70);

                inventario.codigoPro = producto.codigoPro;
                inventario.nombrePro = producto.nombrePro;
                inventario.descripcionPro = producto.descripcionPro;
                inventario.presentacionPro = producto.presentacionPro;
                inventario.precioVentaPro = producto.precioVentaPro;
                inventario.costoUnitarioPro = producto.costoUnitarioPro;
                inventario.tipoCargoPro = producto.tipoCargoPro;
                inventario.categoriaPro = producto.categoriaPro;
                inventario.qrPro = producto.qrPro;
                inventario.cantidad = 0;

                // Call the method to add the product to Firebase
                productos.agregarProducto(producto);
                inventarios.agregarInventario(inventario);

                MessageBox.Show("EL PRODUCTO FUE AGREGADO EXITOSAMENTE", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                procedimientos.limpiarControles(this);
                generarCodigo();
                txtNombrePro.Focus();
                Agregar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"EL PRODUCTO NO FUE AGREGADO POR: {ex.Message}", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }


        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            generarQrProducto();
        }



        public void generarQrProducto()
        {

            if (txtCodigoPro.Text == string.Empty ||
                txtNombrePro.Text == string.Empty ||
                txtDescripcionPro.Text == string.Empty ||
                txtCostoUnitarioPro.Text == string.Empty ||
                txtPrecioVentaPro.Text == string.Empty ||
                cboTipoCargoPro.Text == string.Empty ||
                cboCategoria.Text == string.Empty ||
                cboPresentacion.Text == string.Empty)
            {

                MessageBox.Show("PORFAVOR COMPLETAR TODOS LOS CAMPOS PARA PODER GENERAR EL QR", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
  
                producto.codigoPro = txtCodigoPro.Text.Trim();
                producto.nombrePro = txtNombrePro.Text.Trim();
                producto.descripcionPro = txtDescripcionPro.Text.Trim();
                producto.presentacionPro = cboPresentacion.Text.Trim();
                producto.precioVentaPro = txtPrecioVentaPro.Text.Trim();
                producto.costoUnitarioPro = txtCostoUnitarioPro.Text.Trim();
                producto.tipoCargoPro = cboTipoCargoPro.Text.Trim();
                producto.categoriaPro = cboCategoria.Text.Trim();
                Zen.Barcode.CodeQrBarcodeDraw mGeneradorQR = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                String productoQR = producto.nombrePro + "/" + producto.precioVentaPro;
                pbxQR.Image = mGeneradorQR.Draw(productoQR, 100);


                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                saveFileDialog.Filter = "Archivos de imagen JPEG (*.jpg)|*.jpg"; // Establecer el filtro para archivos JPEG
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string codigoQR = saveFileDialog.FileName;
                    Bitmap bitmap = new Bitmap(pbxQR.Image);
                    bitmap.Save(codigoQR);
                }
            }


        }
      
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       

        private void FrmAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
