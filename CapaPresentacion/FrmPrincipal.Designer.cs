namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            gestionDeProductosToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            presentacionToolStripMenuItem = new ToolStripMenuItem();
            gestionDeProveedoresToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeComprasToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem1 = new ToolStripMenuItem();
            gestionDeVentasToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHour = new Label();
            lblFetch = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PapayaWhip;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDeProductosToolStripMenuItem, gestionDeProveedoresToolStripMenuItem, gestionDeClientesToolStripMenuItem, gestionDeComprasToolStripMenuItem, inventarioToolStripMenuItem, gestionDeVentasToolStripMenuItem, configuracionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1252, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            gestionDeProductosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem, presentacionToolStripMenuItem });
            gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            gestionDeProductosToolStripMenuItem.Size = new Size(164, 24);
            gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(176, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(176, 26);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // presentacionToolStripMenuItem
            // 
            presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            presentacionToolStripMenuItem.Size = new Size(176, 26);
            presentacionToolStripMenuItem.Text = "Presentacion";
            presentacionToolStripMenuItem.Click += presentacionToolStripMenuItem_Click;
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            gestionDeProveedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem });
            gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            gestionDeProveedoresToolStripMenuItem.Size = new Size(180, 24);
            gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(174, 26);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(150, 24);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            gestionDeComprasToolStripMenuItem.Size = new Size(157, 24);
            gestionDeComprasToolStripMenuItem.Text = "Gestion de Compras";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem1 });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(89, 24);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            inventarioToolStripMenuItem1.Size = new Size(158, 26);
            inventarioToolStripMenuItem1.Text = "Inventario";
            inventarioToolStripMenuItem1.Click += inventarioToolStripMenuItem1_Click;
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            gestionDeVentasToolStripMenuItem.Size = new Size(141, 24);
            gestionDeVentasToolStripMenuItem.Text = "Gestion de Ventas";
            // 
            // configuracionToolStripMenuItem
            // 
            configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            configuracionToolStripMenuItem.Size = new Size(116, 24);
            configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHour.ForeColor = Color.IndianRed;
            lblHour.Location = new Point(554, 217);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(207, 36);
            lblHour.TabIndex = 2;
            lblHour.Text = "03:58:00 am";
            lblHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFetch
            // 
            lblFetch.AutoSize = true;
            lblFetch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFetch.Location = new Point(541, 278);
            lblFetch.Name = "lblFetch";
            lblFetch.Size = new Size(234, 31);
            lblFetch.TabIndex = 3;
            lblFetch.Text = "17  de Abril del 2024";
            lblFetch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 471);
            Controls.Add(lblFetch);
            Controls.Add(lblHour);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas -";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        public Label lblHour;
        public Label lblFetch;
        private ToolStripMenuItem inventarioToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem presentacionToolStripMenuItem;
    }
}
