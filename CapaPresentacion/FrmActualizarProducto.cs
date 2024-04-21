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
    public partial class FrmActualizarProducto : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Productos productos = new();
        CDo_Categorias categorias = new();
        CDo_Presentaciones presentaciones = new();
        Producto producto = new();

        Image imagenOriginal;
        private bool seCambioImagen = false;
    


        public FrmActualizarProducto(FrmProductos Productos)
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

        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            imagenOriginal = pbxQR.Image;
            btnGuardarActualizarProducto.Enabled = false;
        }

        private void btnGuardarActualizarProducto_Click(object sender, EventArgs e)

        {

            Actualizar();
        }
        public override void Actualizar()
        {
            try
            {


                if (txtCodigoPro.Text == string.Empty ||
                    txtNombrePro.Text == string.Empty ||
                    txtDescripcionPro.Text == string.Empty ||
                    txtCostoUnitarioPro.Text == string.Empty ||
                    txtPrecioVentaPro.Text == string.Empty ||
                    cboTipoCargoPro.Text == string.Empty ||
                    cboCategoria.Text == string.Empty ||
                    cboPresentacion.Text == string.Empty ||
                    pbxQR.Image == null)
                {
                    MessageBox.Show("PORFAVOR COMPLETAR TODOS LOS CAMPOS", "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if ( !seCambioImagen)
                    {

                        MessageBox.Show("Vuelva a generar el codigo QR.", "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        Presentacion objPresentacion = encontrarPresentacion(cboPresentacion.Text);
                        Categoria objCategoria = encontrarCategoria(cboCategoria.Text);
                        producto.id = txtIdPro.Text.Trim();
                        producto.codigoPro = txtCodigoPro.Text.Trim();
                        producto.nombrePro = txtNombrePro.Text.Trim();
                        producto.descripcionPro = txtDescripcionPro.Text.Trim();
                        producto.presentacionPro = cboPresentacion.Text.Trim();
                        producto.precioVentaPro = txtPrecioVentaPro.Text.Trim();
                        producto.costoUnitarioPro = txtCostoUnitarioPro.Text.Trim();
                        producto.tipoCargoPro = cboTipoCargoPro.Text.Trim();
                        producto.categoriaPro = cboCategoria.Text.Trim();
                        producto.qrPro = procedimientos.comprimirQR(pbxQR.Image, 80);
                        productos.actualizarProducto(producto, producto.id);
                        MessageBox.Show("SE ACTUALIZO EL PRODUCTO EXITOSAMENTE", "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                string mensajeError = "EL PRODUCTO NO FUE ACTUALIZADO POR : " + ex.Message + "\n\n";
                mensajeError += "Detalles del error:\n" + ex.StackTrace;

                MessageBox.Show(mensajeError, "Actualizar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private Presentacion encontrarPresentacion(string nombreBuscado)
        {

            List<Presentacion> listaPresentacion = procedimientos.cargarDatos<Presentacion>("presentaciones");
            // Utiliza LINQ para buscar el objeto con el nombre buscado
            Presentacion presentacionEncontrada = listaPresentacion.FirstOrDefault(p => p.nombrePre == nombreBuscado);

            // Verificar si se encontró la presentación
            return presentacionEncontrada;

        }
        private Categoria encontrarCategoria(string nombreBuscado)
        {

            List<Categoria> listaCategoria = procedimientos.cargarDatos<Categoria>("categorias");
            // Utiliza LINQ para buscar el objeto con el nombre buscado
            Categoria categoriaEncontrada = listaCategoria.FirstOrDefault(p => p.nombreCat == nombreBuscado);

            // Verificar si se encontró la presentación
            return categoriaEncontrada;

        }


        private void btnGenerarQR_Click(object sender, EventArgs e)
        {

            generarQrProducto();
            // Validar si la imagen ha cambiado
            if (pbxQR.Image != imagenOriginal)
            {
                // La imagen ha cambiado
                MessageBox.Show("La imagen ha cambiado.");
                seCambioImagen = true;
            }
            else
            {
                // La imagen no ha cambiado
                MessageBox.Show("La imagen no ha cambiado.");
            }

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

                Presentacion objPresentacion = encontrarPresentacion(cboPresentacion.Text);
                Categoria objCategoria = encontrarCategoria(cboCategoria.Text);
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

        private void cboPresentacion_TextChanged(object sender, EventArgs e)
        {
         
            btnGuardarActualizarProducto.Enabled = true;
        }

        private void txtNombrePro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProducto.Enabled = true;
        }

        private void txtDescripcionPro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProducto.Enabled = true;
        }

        private void cboCategoria_TextChanged(object sender, EventArgs e)
        {
          btnGuardarActualizarProducto.Enabled = true;
        }

        private void txtPrecioVentaPro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProducto.Enabled = true;
        }

        private void txtCostoUnitarioPro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProducto.Enabled = true;
        }

        private void cboTipoCargoPro_TextChanged(object sender, EventArgs e)
        {
            btnGuardarActualizarProducto.Enabled = true;
        }
    }
}
