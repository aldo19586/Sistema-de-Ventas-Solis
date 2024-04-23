namespace CapaPresentacion
{
    partial class FrmCompras
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
            txtBuscarCompra = new TextBox();
            cboTipoBuscar = new ComboBox();
            btnAnularCompra = new Button();
            btnImprimirCompra = new Button();
            btnAgregarCompra = new Button();
            dataGridViewCompras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1133, 542);
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
            // txtBuscarCompra
            // 
            txtBuscarCompra.BackColor = Color.PapayaWhip;
            txtBuscarCompra.Location = new Point(1071, 31);
            txtBuscarCompra.Multiline = true;
            txtBuscarCompra.Name = "txtBuscarCompra";
            txtBuscarCompra.Size = new Size(213, 34);
            txtBuscarCompra.TabIndex = 16;
            txtBuscarCompra.TextChanged += txtBuscarCompra_TextChanged;
            // 
            // cboTipoBuscar
            // 
            cboTipoBuscar.FormattingEnabled = true;
            cboTipoBuscar.Items.AddRange(new object[] { "Fecha", "Comprobante", "Nombre" });
            cboTipoBuscar.Location = new Point(902, 31);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(151, 28);
            cboTipoBuscar.TabIndex = 15;
            // 
            // btnAnularCompra
            // 
            btnAnularCompra.FlatStyle = FlatStyle.Popup;
            btnAnularCompra.Location = new Point(153, 530);
            btnAnularCompra.Name = "btnAnularCompra";
            btnAnularCompra.Size = new Size(135, 45);
            btnAnularCompra.TabIndex = 13;
            btnAnularCompra.Text = "Anular";
            btnAnularCompra.UseVisualStyleBackColor = true;
            btnAnularCompra.Click += btnAnularCompra_Click;
            // 
            // btnImprimirCompra
            // 
            btnImprimirCompra.FlatStyle = FlatStyle.Popup;
            btnImprimirCompra.Location = new Point(294, 530);
            btnImprimirCompra.Name = "btnImprimirCompra";
            btnImprimirCompra.Size = new Size(135, 45);
            btnImprimirCompra.TabIndex = 12;
            btnImprimirCompra.Text = "Imprimir";
            btnImprimirCompra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.FlatStyle = FlatStyle.Popup;
            btnAgregarCompra.Location = new Point(12, 530);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(135, 45);
            btnAgregarCompra.TabIndex = 10;
            btnAgregarCompra.Text = "Agregar";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
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
            dataGridViewCompras.Location = new Point(12, 80);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersVisible = false;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.RowTemplate.Height = 29;
            dataGridViewCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCompras.Size = new Size(1272, 420);
            dataGridViewCompras.TabIndex = 9;
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 607);
            Controls.Add(label1);
            Controls.Add(txtBuscarCompra);
            Controls.Add(cboTipoBuscar);
            Controls.Add(btnAnularCompra);
            Controls.Add(btnImprimirCompra);
            Controls.Add(btnAgregarCompra);
            Controls.Add(dataGridViewCompras);
            Name = "FrmCompras";
            Text = "FrmCompras";
            Load += FrmCompras_Load;
            Controls.SetChildIndex(dataGridViewCompras, 0);
            Controls.SetChildIndex(btnAgregarCompra, 0);
            Controls.SetChildIndex(btnImprimirCompra, 0);
            Controls.SetChildIndex(btnAnularCompra, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(txtBuscarCompra, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarCompra;
        private ComboBox cboTipoBuscar;
        private Button btnAnularCompra;
        private Button btnImprimirCompra;
        private Button btnAgregarCompra;
        public DataGridView dataGridViewCompras;
    }
}