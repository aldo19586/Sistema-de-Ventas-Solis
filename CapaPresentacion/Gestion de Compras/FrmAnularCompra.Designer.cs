namespace CapaPresentacion.Gestion_de_Compras
{
    partial class FrmAnularCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            txtIdDetalle = new TextBox();
            txtIdProducto = new TextBox();
            btnBuscarProductoCompra = new Button();
            btnEliminarProductoCompra = new Button();
            btnAgregarProductoCompra = new Button();
            txtCostoUnitarioProducto = new TextBox();
            label10 = new Label();
            txtPresentacionProducto = new TextBox();
            label9 = new Label();
            txtNombreProducto = new TextBox();
            label8 = new Label();
            txtCantidadProducto = new TextBox();
            label7 = new Label();
            txtCodigoProducto = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtIdProveedor = new TextBox();
            txtIdIngreso = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            label5 = new Label();
            btnBuscarProveedorCompra = new Button();
            txtNombrePve = new TextBox();
            label4 = new Label();
            txtNumComprobante = new TextBox();
            label3 = new Label();
            txtNumIngreso = new TextBox();
            label1 = new Label();
            btnGuardarAnularCompra = new Button();
            txtCostoTotalCompra = new TextBox();
            label2 = new Label();
            dataGridViewCompras = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1046, 755);
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(txtIdDetalle);
            groupBox2.Controls.Add(txtIdProducto);
            groupBox2.Controls.Add(btnBuscarProductoCompra);
            groupBox2.Controls.Add(btnEliminarProductoCompra);
            groupBox2.Controls.Add(btnAgregarProductoCompra);
            groupBox2.Controls.Add(txtCostoUnitarioProducto);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPresentacionProducto);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCantidadProducto);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCodigoProducto);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1178, 218);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion del Producto";
            // 
            // txtIdDetalle
            // 
            txtIdDetalle.BackColor = Color.PapayaWhip;
            txtIdDetalle.BorderStyle = BorderStyle.FixedSingle;
            txtIdDetalle.Location = new Point(0, 140);
            txtIdDetalle.Multiline = true;
            txtIdDetalle.Name = "txtIdDetalle";
            txtIdDetalle.Size = new Size(35, 25);
            txtIdDetalle.TabIndex = 31;
            txtIdDetalle.Visible = false;
            // 
            // txtIdProducto
            // 
            txtIdProducto.BackColor = Color.PapayaWhip;
            txtIdProducto.BorderStyle = BorderStyle.FixedSingle;
            txtIdProducto.Enabled = false;
            txtIdProducto.Location = new Point(0, 64);
            txtIdProducto.Multiline = true;
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(35, 25);
            txtIdProducto.TabIndex = 20;
            txtIdProducto.Visible = false;
            // 
            // btnBuscarProductoCompra
            // 
            btnBuscarProductoCompra.Enabled = false;
            btnBuscarProductoCompra.Location = new Point(677, 64);
            btnBuscarProductoCompra.Name = "btnBuscarProductoCompra";
            btnBuscarProductoCompra.Size = new Size(94, 29);
            btnBuscarProductoCompra.TabIndex = 29;
            btnBuscarProductoCompra.Text = "Buscar";
            btnBuscarProductoCompra.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProductoCompra
            // 
            btnEliminarProductoCompra.Enabled = false;
            btnEliminarProductoCompra.Location = new Point(1044, 115);
            btnEliminarProductoCompra.Name = "btnEliminarProductoCompra";
            btnEliminarProductoCompra.Size = new Size(94, 29);
            btnEliminarProductoCompra.TabIndex = 28;
            btnEliminarProductoCompra.Text = "Eliminar";
            btnEliminarProductoCompra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductoCompra
            // 
            btnAgregarProductoCompra.Enabled = false;
            btnAgregarProductoCompra.Location = new Point(1044, 62);
            btnAgregarProductoCompra.Name = "btnAgregarProductoCompra";
            btnAgregarProductoCompra.Size = new Size(94, 29);
            btnAgregarProductoCompra.TabIndex = 18;
            btnAgregarProductoCompra.Text = "Agregar";
            btnAgregarProductoCompra.UseVisualStyleBackColor = true;
            // 
            // txtCostoUnitarioProducto
            // 
            txtCostoUnitarioProducto.BackColor = Color.PapayaWhip;
            txtCostoUnitarioProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCostoUnitarioProducto.Enabled = false;
            txtCostoUnitarioProducto.Location = new Point(816, 64);
            txtCostoUnitarioProducto.Multiline = true;
            txtCostoUnitarioProducto.Name = "txtCostoUnitarioProducto";
            txtCostoUnitarioProducto.ReadOnly = true;
            txtCostoUnitarioProducto.Size = new Size(185, 25);
            txtCostoUnitarioProducto.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(816, 41);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 26;
            label10.Text = "Costo Unitario :";
            // 
            // txtPresentacionProducto
            // 
            txtPresentacionProducto.BackColor = Color.PapayaWhip;
            txtPresentacionProducto.BorderStyle = BorderStyle.FixedSingle;
            txtPresentacionProducto.Enabled = false;
            txtPresentacionProducto.Location = new Point(295, 145);
            txtPresentacionProducto.Multiline = true;
            txtPresentacionProducto.Name = "txtPresentacionProducto";
            txtPresentacionProducto.ReadOnly = true;
            txtPresentacionProducto.Size = new Size(185, 25);
            txtPresentacionProducto.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(295, 122);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 24;
            label9.Text = "Presentacion :";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = Color.PapayaWhip;
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Enabled = false;
            txtNombreProducto.Location = new Point(295, 64);
            txtNombreProducto.Multiline = true;
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.ReadOnly = true;
            txtNombreProducto.Size = new Size(376, 25);
            txtNombreProducto.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 41);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 22;
            label8.Text = "Nombre Producto :";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.BackColor = Color.PapayaWhip;
            txtCantidadProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadProducto.Enabled = false;
            txtCantidadProducto.Location = new Point(38, 140);
            txtCantidadProducto.Multiline = true;
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(185, 25);
            txtCantidadProducto.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 117);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 20;
            label7.Text = "Cantidad :";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BackColor = Color.PapayaWhip;
            txtCodigoProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProducto.Enabled = false;
            txtCodigoProducto.Location = new Point(38, 64);
            txtCodigoProducto.Multiline = true;
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(185, 25);
            txtCodigoProducto.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 41);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 18;
            label6.Text = "Codigo Producto  :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtIdProveedor);
            groupBox1.Controls.Add(txtIdIngreso);
            groupBox1.Controls.Add(dateTimePickerFecha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnBuscarProveedorCompra);
            groupBox1.Controls.Add(txtNombrePve);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNumComprobante);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumIngreso);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1178, 180);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de la Compra";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.BackColor = Color.PapayaWhip;
            txtIdProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtIdProveedor.Enabled = false;
            txtIdProveedor.Location = new Point(254, 54);
            txtIdProveedor.Multiline = true;
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(35, 25);
            txtIdProveedor.TabIndex = 19;
            txtIdProveedor.Visible = false;
            // 
            // txtIdIngreso
            // 
            txtIdIngreso.BackColor = Color.PapayaWhip;
            txtIdIngreso.BorderStyle = BorderStyle.FixedSingle;
            txtIdIngreso.Location = new Point(0, 87);
            txtIdIngreso.Multiline = true;
            txtIdIngreso.Name = "txtIdIngreso";
            txtIdIngreso.Size = new Size(78, 25);
            txtIdIngreso.TabIndex = 18;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Enabled = false;
            dateTimePickerFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(816, 46);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(186, 30);
            dateTimePickerFecha.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(816, 23);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 16;
            label5.Text = "Fecha Compra :";
            // 
            // btnBuscarProveedorCompra
            // 
            btnBuscarProveedorCompra.Enabled = false;
            btnBuscarProveedorCompra.Location = new Point(677, 52);
            btnBuscarProveedorCompra.Name = "btnBuscarProveedorCompra";
            btnBuscarProveedorCompra.Size = new Size(94, 29);
            btnBuscarProveedorCompra.TabIndex = 15;
            btnBuscarProveedorCompra.Text = "Buscar";
            btnBuscarProveedorCompra.UseVisualStyleBackColor = true;
            // 
            // txtNombrePve
            // 
            txtNombrePve.BackColor = Color.PapayaWhip;
            txtNombrePve.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePve.Enabled = false;
            txtNombrePve.Location = new Point(295, 56);
            txtNombrePve.Multiline = true;
            txtNombrePve.Name = "txtNombrePve";
            txtNombrePve.ReadOnly = true;
            txtNombrePve.Size = new Size(376, 25);
            txtNombrePve.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 33);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 13;
            label4.Text = "Nombre Proveedor:";
            // 
            // txtNumComprobante
            // 
            txtNumComprobante.BackColor = Color.PapayaWhip;
            txtNumComprobante.BorderStyle = BorderStyle.FixedSingle;
            txtNumComprobante.Enabled = false;
            txtNumComprobante.Location = new Point(38, 131);
            txtNumComprobante.Multiline = true;
            txtNumComprobante.Name = "txtNumComprobante";
            txtNumComprobante.Size = new Size(185, 25);
            txtNumComprobante.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 108);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 11;
            label3.Text = "N° Comprobante:";
            // 
            // txtNumIngreso
            // 
            txtNumIngreso.BackColor = Color.PapayaWhip;
            txtNumIngreso.BorderStyle = BorderStyle.FixedSingle;
            txtNumIngreso.Enabled = false;
            txtNumIngreso.Location = new Point(38, 56);
            txtNumIngreso.Multiline = true;
            txtNumIngreso.Name = "txtNumIngreso";
            txtNumIngreso.Size = new Size(185, 25);
            txtNumIngreso.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 9;
            label1.Text = "N° Ingreso :";
            // 
            // btnGuardarAnularCompra
            // 
            btnGuardarAnularCompra.FlatStyle = FlatStyle.Popup;
            btnGuardarAnularCompra.Location = new Point(905, 753);
            btnGuardarAnularCompra.Name = "btnGuardarAnularCompra";
            btnGuardarAnularCompra.Size = new Size(135, 45);
            btnGuardarAnularCompra.TabIndex = 26;
            btnGuardarAnularCompra.Text = "Anular";
            btnGuardarAnularCompra.UseVisualStyleBackColor = true;
            btnGuardarAnularCompra.Click += btnGuardarAnularCompra_Click;
            // 
            // txtCostoTotalCompra
            // 
            txtCostoTotalCompra.BackColor = Color.PapayaWhip;
            txtCostoTotalCompra.Location = new Point(12, 763);
            txtCostoTotalCompra.Multiline = true;
            txtCostoTotalCompra.Name = "txtCostoTotalCompra";
            txtCostoTotalCompra.Size = new Size(202, 47);
            txtCostoTotalCompra.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 735);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 24;
            label2.Text = "Costo Total a Pagar  :";
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.AllowUserToAddRows = false;
            dataGridViewCompras.AllowUserToDeleteRows = false;
            dataGridViewCompras.AllowUserToResizeRows = false;
            dataGridViewCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCompras.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCompras.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCompras.EnableHeadersVisualStyles = false;
            dataGridViewCompras.Location = new Point(12, 438);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersVisible = false;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.RowTemplate.Height = 29;
            dataGridViewCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompras.Size = new Size(1178, 280);
            dataGridViewCompras.TabIndex = 23;
            // 
            // FrmAnularCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 829);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardarAnularCompra);
            Controls.Add(txtCostoTotalCompra);
            Controls.Add(label2);
            Controls.Add(dataGridViewCompras);
            Name = "FrmAnularCompra";
            Text = "FrmAnularCompra";
            Load += FrmAnularCompra_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(dataGridViewCompras, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtCostoTotalCompra, 0);
            Controls.SetChildIndex(btnGuardarAnularCompra, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox2, 0);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        public TextBox txtIdDetalle;
        public TextBox txtIdProducto;
        private Button btnBuscarProductoCompra;
        private Button btnEliminarProductoCompra;
        private Button btnAgregarProductoCompra;
        public TextBox txtCostoUnitarioProducto;
        private Label label10;
        public TextBox txtPresentacionProducto;
        private Label label9;
        public TextBox txtNombreProducto;
        private Label label8;
        public TextBox txtCantidadProducto;
        private Label label7;
        public TextBox txtCodigoProducto;
        private Label label6;
        private GroupBox groupBox1;
        public TextBox txtIdProveedor;
        public TextBox txtIdIngreso;
        private DateTimePicker dateTimePickerFecha;
        private Label label5;
        private Button btnBuscarProveedorCompra;
        public TextBox txtNombrePve;
        private Label label4;
        public TextBox txtNumComprobante;
        private Label label3;
        public TextBox txtNumIngreso;
        private Label label1;
        private Button btnGuardarAnularCompra;
        private Label label2;
        public DataGridView dataGridViewCompras;
        public TextBox txtCostoTotalCompra;
    }
}