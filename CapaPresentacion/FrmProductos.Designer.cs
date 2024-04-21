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
            btnEliminarProducto = new Button();
            btnActualizar = new Button();
            cboTipoBuscar = new ComboBox();
            txtBuscarProducto = new TextBox();
            label1 = new Label();
            btnAgregarProducto = new Button();
            btnActualizarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(1020, 530);
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
            // btnEliminarProducto
            // 
            btnEliminarProducto.FlatStyle = FlatStyle.Popup;
            btnEliminarProducto.Location = new Point(294, 530);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(135, 45);
            btnEliminarProducto.TabIndex = 4;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
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
            cboTipoBuscar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Nombre" });
            cboTipoBuscar.Location = new Point(902, 31);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(151, 28);
            cboTipoBuscar.TabIndex = 6;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.BackColor = Color.PapayaWhip;
            txtBuscarProducto.Location = new Point(1071, 31);
            txtBuscarProducto.Multiline = true;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(213, 34);
            txtBuscarProducto.TabIndex = 7;
            txtBuscarProducto.TextChanged += txtBuscarProducto_TextChanged;
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
            // btnAgregarProducto
            // 
            btnAgregarProducto.FlatStyle = FlatStyle.Popup;
            btnAgregarProducto.Location = new Point(12, 528);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(135, 45);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregar_Click;
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.FlatStyle = FlatStyle.Popup;
            btnActualizarProducto.Location = new Point(153, 528);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new Size(135, 45);
            btnActualizarProducto.TabIndex = 5;
            btnActualizarProducto.Text = "Actualizar";
            btnActualizarProducto.UseVisualStyleBackColor = true;
            btnActualizarProducto.Click += btnActualizarProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 607);
            Controls.Add(label1);
            Controls.Add(txtBuscarProducto);
            Controls.Add(cboTipoBuscar);
            Controls.Add(btnActualizarProducto);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewProductos);
            Name = "FrmProductos";
            Text = "Gestion de Productos";
            Load += FrmProductos_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(dataGridViewProductos, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnAgregarProducto, 0);
            Controls.SetChildIndex(btnEliminarProducto, 0);
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(btnActualizarProducto, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(txtBuscarProducto, 0);
            Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewProductos;
        private Button btnAgregar;
        private Button btnEliminarProducto;
        private Button btnActualizar;
        private ComboBox cboTipoBuscar;
        private TextBox txtBuscarProducto;
        private Label label1;
        private Button btnAgregarProducto;
        private Button btnActualizarProducto;
    }
}