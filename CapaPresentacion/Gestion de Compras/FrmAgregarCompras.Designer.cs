namespace CapaPresentacion
{
    partial class FrmAgregarCompras
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewCompras = new DataGridView();
            Id_Producto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            CantidadProducto = new DataGridViewTextBoxColumn();
            CostoUnitarioProducto = new DataGridViewTextBoxColumn();
            PresentacionProducto = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            txtCostoTotalCompra = new TextBox();
            label2 = new Label();
            btnGuardarCompra = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1056, 748);
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.AllowUserToAddRows = false;
            dataGridViewCompras.AllowUserToDeleteRows = false;
            dataGridViewCompras.AllowUserToResizeRows = false;
            dataGridViewCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCompras.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.DimGray;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompras.Columns.AddRange(new DataGridViewColumn[] { Id_Producto, NombreProducto, CantidadProducto, CostoUnitarioProducto, PresentacionProducto, SubTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewCompras.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCompras.EnableHeadersVisualStyles = false;
            dataGridViewCompras.Location = new Point(12, 432);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersVisible = false;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.RowTemplate.Height = 29;
            dataGridViewCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompras.Size = new Size(1178, 280);
            dataGridViewCompras.TabIndex = 10;
            // 
            // Id_Producto
            // 
            Id_Producto.HeaderText = "IdProducto";
            Id_Producto.MinimumWidth = 6;
            Id_Producto.Name = "Id_Producto";
            Id_Producto.ReadOnly = true;
            Id_Producto.Width = 125;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 125;
            // 
            // CantidadProducto
            // 
            CantidadProducto.HeaderText = "Cantidad";
            CantidadProducto.MinimumWidth = 6;
            CantidadProducto.Name = "CantidadProducto";
            CantidadProducto.ReadOnly = true;
            CantidadProducto.Width = 125;
            // 
            // CostoUnitarioProducto
            // 
            CostoUnitarioProducto.HeaderText = "CostoUnitario";
            CostoUnitarioProducto.MinimumWidth = 6;
            CostoUnitarioProducto.Name = "CostoUnitarioProducto";
            CostoUnitarioProducto.ReadOnly = true;
            CostoUnitarioProducto.Width = 125;
            // 
            // PresentacionProducto
            // 
            PresentacionProducto.HeaderText = "Presentacion";
            PresentacionProducto.MinimumWidth = 6;
            PresentacionProducto.Name = "PresentacionProducto";
            PresentacionProducto.ReadOnly = true;
            PresentacionProducto.Width = 125;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 125;
            // 
            // txtCostoTotalCompra
            // 
            txtCostoTotalCompra.BackColor = Color.PapayaWhip;
            txtCostoTotalCompra.Location = new Point(12, 757);
            txtCostoTotalCompra.Multiline = true;
            txtCostoTotalCompra.Name = "txtCostoTotalCompra";
            txtCostoTotalCompra.Size = new Size(202, 47);
            txtCostoTotalCompra.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 729);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 14;
            label2.Text = "Costo Total a Pagar  :";
            // 
            // btnGuardarCompra
            // 
            btnGuardarCompra.FlatStyle = FlatStyle.Popup;
            btnGuardarCompra.Location = new Point(905, 747);
            btnGuardarCompra.Name = "btnGuardarCompra";
            btnGuardarCompra.Size = new Size(135, 45);
            btnGuardarCompra.TabIndex = 20;
            btnGuardarCompra.Text = "Agregar";
            btnGuardarCompra.UseVisualStyleBackColor = true;
            btnGuardarCompra.Click += btnGuardarCompra_Click;
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1178, 180);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de la Compra";
            groupBox1.Enter += groupBox1_Enter;
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
            txtIdIngreso.Location = new Point(0, 56);
            txtIdIngreso.Multiline = true;
            txtIdIngreso.Name = "txtIdIngreso";
            txtIdIngreso.Size = new Size(35, 25);
            txtIdIngreso.TabIndex = 18;
            txtIdIngreso.Visible = false;
            // 
            // dateTimePickerFecha
            // 
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
            btnBuscarProveedorCompra.Location = new Point(677, 52);
            btnBuscarProveedorCompra.Name = "btnBuscarProveedorCompra";
            btnBuscarProveedorCompra.Size = new Size(94, 29);
            btnBuscarProveedorCompra.TabIndex = 15;
            btnBuscarProveedorCompra.Text = "Buscar";
            btnBuscarProveedorCompra.UseVisualStyleBackColor = true;
            btnBuscarProveedorCompra.Click += btnBuscarProveedorCompra_Click;
            // 
            // txtNombrePve
            // 
            txtNombrePve.BackColor = Color.PapayaWhip;
            txtNombrePve.BorderStyle = BorderStyle.FixedSingle;
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
            groupBox2.Location = new Point(12, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1178, 218);
            groupBox2.TabIndex = 22;
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
            btnBuscarProductoCompra.Location = new Point(677, 64);
            btnBuscarProductoCompra.Name = "btnBuscarProductoCompra";
            btnBuscarProductoCompra.Size = new Size(94, 29);
            btnBuscarProductoCompra.TabIndex = 29;
            btnBuscarProductoCompra.Text = "Buscar";
            btnBuscarProductoCompra.UseVisualStyleBackColor = true;
            btnBuscarProductoCompra.Click += btnBuscarProductoCompra_Click;
            btnBuscarProductoCompra.KeyPress += btnBuscarProductoCompra_KeyPress;
            // 
            // btnEliminarProductoCompra
            // 
            btnEliminarProductoCompra.Location = new Point(1044, 115);
            btnEliminarProductoCompra.Name = "btnEliminarProductoCompra";
            btnEliminarProductoCompra.Size = new Size(94, 29);
            btnEliminarProductoCompra.TabIndex = 28;
            btnEliminarProductoCompra.Text = "Eliminar";
            btnEliminarProductoCompra.UseVisualStyleBackColor = true;
            btnEliminarProductoCompra.Click += btnEliminarProductoCompra_Click;
            // 
            // btnAgregarProductoCompra
            // 
            btnAgregarProductoCompra.Location = new Point(1044, 62);
            btnAgregarProductoCompra.Name = "btnAgregarProductoCompra";
            btnAgregarProductoCompra.Size = new Size(94, 29);
            btnAgregarProductoCompra.TabIndex = 18;
            btnAgregarProductoCompra.Text = "Agregar";
            btnAgregarProductoCompra.UseVisualStyleBackColor = true;
            btnAgregarProductoCompra.Click += btnAgregarProductoCompra_Click;
            // 
            // txtCostoUnitarioProducto
            // 
            txtCostoUnitarioProducto.BackColor = Color.PapayaWhip;
            txtCostoUnitarioProducto.BorderStyle = BorderStyle.FixedSingle;
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
            txtCantidadProducto.Location = new Point(38, 140);
            txtCantidadProducto.Multiline = true;
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(185, 25);
            txtCantidadProducto.TabIndex = 21;
            txtCantidadProducto.KeyPress += txtCantidadProducto_KeyPress;
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
            // FrmAgregarCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 829);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardarCompra);
            Controls.Add(txtCostoTotalCompra);
            Controls.Add(label2);
            Controls.Add(dataGridViewCompras);
            Name = "FrmAgregarCompras";
            Text = "FrmAgregarCompra";
            Load += FrmAgregarCompra_Load;
            Controls.SetChildIndex(dataGridViewCompras, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtCostoTotalCompra, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnGuardarCompra, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewCompras;
        private TextBox txtCostoTotalCompra;
        private Label label2;
        private Button btnGuardarCompra;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Button btnBuscarProveedorCompra;
        public TextBox txtNombrePve;
        private Label label4;
        public TextBox txtNumComprobante;
        private Label label3;
        public TextBox txtNumIngreso;
        private Label label1;
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
        private Button btnEliminarProductoCompra;
        private Button btnBuscarProductoCompra;
        public TextBox txtIdProveedor;
        public TextBox txtIdIngreso;
        public TextBox txtIdProducto;
        public TextBox txtIdDetalle;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn CantidadProducto;
        private DataGridViewTextBoxColumn CostoUnitarioProducto;
        private DataGridViewTextBoxColumn PresentacionProducto;
        private DataGridViewTextBoxColumn SubTotal;
        public DateTimePicker dateTimePickerFecha;
    }
}