namespace CapaPresentacion
{
    partial class FrmVistaProveedores
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
            txtBuscarProveedor = new TextBox();
            label1 = new Label();
            cboTipoBuscar = new ComboBox();
            btnActualizarProveedor = new Button();
            btnActualizar = new Button();
            btnEliminarProveedor = new Button();
            btnAgregarProducto = new Button();
            btnAgregarProveedor = new Button();
            dataGridViewProveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1150, 528);
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = Color.PapayaWhip;
            txtBuscarProveedor.Location = new Point(1062, 31);
            txtBuscarProveedor.Multiline = true;
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(213, 34);
            txtBuscarProveedor.TabIndex = 26;
            txtBuscarProveedor.TextChanged += txtBuscarProveedor_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(828, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 25;
            label1.Text = "Buscar:";
            // 
            // cboTipoBuscar
            // 
            cboTipoBuscar.FormattingEnabled = true;
            cboTipoBuscar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Nombre" });
            cboTipoBuscar.Location = new Point(902, 31);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(151, 28);
            cboTipoBuscar.TabIndex = 24;
            // 
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.FlatStyle = FlatStyle.Popup;
            btnActualizarProveedor.Location = new Point(153, 528);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.Size = new Size(0, 0);
            btnActualizarProveedor.TabIndex = 22;
            btnActualizarProveedor.Text = "Actualizar";
            btnActualizarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Location = new Point(153, 530);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(0, 0);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.FlatStyle = FlatStyle.Popup;
            btnEliminarProveedor.Location = new Point(294, 530);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(0, 0);
            btnEliminarProveedor.TabIndex = 21;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.FlatStyle = FlatStyle.Popup;
            btnAgregarProducto.Location = new Point(12, 528);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(0, 0);
            btnAgregarProducto.TabIndex = 19;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.FlatStyle = FlatStyle.Popup;
            btnAgregarProveedor.Location = new Point(12, 530);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(0, 0);
            btnAgregarProveedor.TabIndex = 20;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AllowUserToAddRows = false;
            dataGridViewProveedores.AllowUserToDeleteRows = false;
            dataGridViewProveedores.AllowUserToResizeRows = false;
            dataGridViewProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProveedores.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProveedores.EnableHeadersVisualStyles = false;
            dataGridViewProveedores.Location = new Point(12, 80);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.ReadOnly = true;
            dataGridViewProveedores.RowHeadersVisible = false;
            dataGridViewProveedores.RowHeadersWidth = 51;
            dataGridViewProveedores.RowTemplate.Height = 29;
            dataGridViewProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProveedores.Size = new Size(1272, 420);
            dataGridViewProveedores.TabIndex = 18;
            dataGridViewProveedores.DoubleClick += dataGridViewProveedores_DoubleClick_1;
            // 
            // FrmVistaProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 607);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(label1);
            Controls.Add(cboTipoBuscar);
            Controls.Add(btnActualizarProveedor);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dataGridViewProveedores);
            Name = "FrmVistaProveedores";
            Text = "FrmVistaProveedores";
            Load += FrmVistaProveedores_Load;
            Controls.SetChildIndex(dataGridViewProveedores, 0);
            Controls.SetChildIndex(btnAgregarProveedor, 0);
            Controls.SetChildIndex(btnAgregarProducto, 0);
            Controls.SetChildIndex(btnEliminarProveedor, 0);
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(btnActualizarProveedor, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtBuscarProveedor, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProveedor;
        private Label label1;
        private ComboBox cboTipoBuscar;
        private Button btnActualizarProveedor;
        private Button btnActualizar;
        private Button btnEliminarProveedor;
        private Button btnAgregarProducto;
        private Button btnAgregarProveedor;
        public DataGridView dataGridViewProveedores;
    }
}