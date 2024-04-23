namespace CapaPresentacion
{
    partial class FrmProductos
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
            dataGridViewProductos = new DataGridView();
            btnAgregar = new Button();
            btnEliminarProveedor = new Button();
            btnActualizar = new Button();
            cboTipoBuscar = new ComboBox();
            txtBuscarProveedor = new TextBox();
            label1 = new Label();
            btnAgregarProveedor = new Button();
            btnActualizarProveedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(1150, 541);
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProductos.EnableHeadersVisualStyles = false;
            dataGridViewProductos.Location = new Point(12, 80);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.RowTemplate.Height = 29;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(1272, 420);
            dataGridViewProductos.TabIndex = 1;
            dataGridViewProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(12, 530);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(135, 45);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.FlatStyle = FlatStyle.Popup;
            btnEliminarProveedor.Location = new Point(294, 530);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(135, 45);
            btnEliminarProveedor.TabIndex = 4;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProducto_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Location = new Point(153, 530);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(135, 45);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cboTipoBuscar
            // 
            cboTipoBuscar.FormattingEnabled = true;
            cboTipoBuscar.Items.AddRange(new object[] { "Codigo", "RUC", "Nombre" });
            cboTipoBuscar.Location = new Point(902, 31);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(151, 28);
            cboTipoBuscar.TabIndex = 6;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = Color.PapayaWhip;
            txtBuscarProveedor.Location = new Point(1071, 31);
            txtBuscarProveedor.Multiline = true;
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(213, 34);
            txtBuscarProveedor.TabIndex = 7;
            txtBuscarProveedor.TextChanged += txtBuscarProducto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(828, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 8;
            label1.Text = "Buscar:";
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.FlatStyle = FlatStyle.Popup;
            btnAgregarProveedor.Location = new Point(12, 528);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(135, 45);
            btnAgregarProveedor.TabIndex = 2;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregar_Click;
            // 
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.FlatStyle = FlatStyle.Popup;
            btnActualizarProveedor.Location = new Point(153, 528);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.Size = new Size(135, 45);
            btnActualizarProveedor.TabIndex = 5;
            btnActualizarProveedor.Text = "Actualizar";
            btnActualizarProveedor.UseVisualStyleBackColor = true;
            btnActualizarProveedor.Click += btnActualizarProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 607);
            Controls.Add(label1);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(cboTipoBuscar);
            Controls.Add(btnActualizarProveedor);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewProductos);
            Name = "FrmProductos";
            Text = "Gestion de Productos";
            Load += FrmProductos_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(dataGridViewProductos, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnAgregarProveedor, 0);
            Controls.SetChildIndex(btnEliminarProveedor, 0);
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(btnActualizarProveedor, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(txtBuscarProveedor, 0);
            Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewProductos;
        private Button btnAgregar;
        private Button btnEliminarProveedor;
        private Button btnActualizar;
        private ComboBox cboTipoBuscar;
        private TextBox txtBuscarProveedor;
        private Label label1;
        private Button btnAgregarProveedor;
        private Button btnActualizarProveedor;
    }
}