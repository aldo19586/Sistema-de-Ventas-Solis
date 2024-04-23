namespace CapaPresentacion
{
    partial class FrmVistaProductos
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
            label1 = new Label();
            txtBuscarProveedor = new TextBox();
            cboTipoBuscar = new ComboBox();
            dataGridViewProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1150, 532);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(828, 39);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 17;
            label1.Text = "Buscar:";
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.BackColor = Color.PapayaWhip;
            txtBuscarProveedor.Location = new Point(1071, 31);
            txtBuscarProveedor.Multiline = true;
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(213, 34);
            txtBuscarProveedor.TabIndex = 16;
            // 
            // cboTipoBuscar
            // 
            cboTipoBuscar.FormattingEnabled = true;
            cboTipoBuscar.Items.AddRange(new object[] { "Codigo", "RUC", "Nombre" });
            cboTipoBuscar.Location = new Point(902, 31);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(151, 28);
            cboTipoBuscar.TabIndex = 15;
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
            dataGridViewProductos.TabIndex = 9;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            dataGridViewProductos.DoubleClick += dataGridViewProductos_DoubleClick;
            // 
            // FrmVistaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 607);
            Controls.Add(label1);
            Controls.Add(txtBuscarProveedor);
            Controls.Add(cboTipoBuscar);
            Controls.Add(dataGridViewProductos);
            Name = "FrmVistaProductos";
            Text = "FrmVistaProductos";
            Load += FrmVistaProductos_Load;
            Controls.SetChildIndex(dataGridViewProductos, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(txtBuscarProveedor, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarProveedor;
        private ComboBox cboTipoBuscar;
        public DataGridView dataGridViewProductos;
    }
}