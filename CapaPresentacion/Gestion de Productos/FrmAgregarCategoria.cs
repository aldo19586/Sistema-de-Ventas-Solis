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
    public partial class FrmAgregarCategoria : FormBase
    {
        CDo_Procedimientos procedimientos = new();
        CDo_Categorias categorias = new();
        Categoria categoria = new();
        public FrmAgregarCategoria(FrmCategorias Categorias)
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

        private void FrmAgregarCategoria_Load(object sender, EventArgs e)
        {
            generarCodigo();
        }
        private void generarCodigo()
        {
            txtCodigoCat.Text = procedimientos.generarCodigo("CATE");
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public override bool Guardar()
        {
            try
            {
                if (txtCodigoCat.Text == string.Empty ||
                    txtNombreCat.Text == string.Empty ||
                    txtDescripcionCat.Text == string.Empty)
                {
                    MessageBox.Show("PORFAVOR COMPLETAR TODOS LOS CAMPOS", "Agregar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    categoria.codigoCat = txtCodigoCat.Text.Trim();
                    categoria.nombreCat = txtNombreCat.Text.Trim();
                    categoria.descripcionCat = txtDescripcionCat.Text.Trim();
                    

                    categorias.agregarCategoria(categoria);
                    MessageBox.Show("SE AGREGO LA CATEGORIA EXITOSAMENTE", "Agregar  Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles(this);
                    generarCodigo();
                    txtNombreCat.Focus();
                    Agregar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("LA CATEGORIA NO FUE AGREADO POR : " + ex.Message, "Agregar  Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public void limpiarControles(Form form)
        {
            foreach (var xCtrl in form.Controls)
                if (xCtrl is TextBox)
                {
                    ((TextBox)xCtrl).Text = string.Empty;
                }
            {

            }
        }
    }
}
