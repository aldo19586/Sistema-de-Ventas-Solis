using System.DirectoryServices.ActiveDirectory;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            centerLabelForm(lblHour, lblFetch);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.ToLongTimeString();
            lblFetch.Text = DateTime.Now.ToLongDateString();

        }
        private void centerLabelForm(Label hour, Label fetch)
        {
            // Calcula la posición horizontal centrada para el Label
            int x = (this.ClientSize.Width - hour.Width) / 2;
            // Calcula la posición vertical centrada para el Label
            int y = (this.ClientSize.Height - hour.Height) / 2;

            // Establece la posición del Label
            hour.Location = new System.Drawing.Point(x, y);

            // Calcula la posición horizontal centrada para el Label2
            int x2 = (this.ClientSize.Width - fetch.Width) / 2;
            // Calcula la posición vertical debajo del Label1
            int y2 = y + hour.Height + 10; // Agrega un espacio entre los dos Labels, por ejemplo 10 píxeles

            // Establece la posición del Label2
            fetch.Location = new System.Drawing.Point(x2, y2);

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos products = new FrmProductos();
            products.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new();
            inventario.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias categorias = new();
            categorias.Show();

        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPresentacion presentacion = new();
            presentacion.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor proveedor = new();
            proveedor.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras compras = new();
            compras.Show();
        }
    }
}
