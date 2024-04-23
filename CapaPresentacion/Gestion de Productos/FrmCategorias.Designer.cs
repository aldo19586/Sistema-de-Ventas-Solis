namespace CapaPresentacion
{
    partial class FrmCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewCategorias = new DataGridView();
            label1 = new Label();
            txtBuscarCategoria = new TextBox();
            cboTipoBuscar = new ComboBox();
            btnActualizarCategoria = new Button();
            btnEliminarCategoria = new Button();
            btnAgregarCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(470, 361);
            // 
            // dataGridViewCategorias
            // 
            dataGridViewCategorias.AllowUserToAddRows = false;
            dataGridViewCategorias.AllowUserToDeleteRows = false;
            dataGridViewCategorias.AllowUserToResizeRows = false;
            dataGridViewCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCategorias.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DimGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewCategorias.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCategorias.EnableHeadersVisualStyles = false;
            dataGridViewCategorias.Location = new Point(12, 60);
            dataGridViewCategorias.Name = "dataGridViewCategorias";
            dataGridViewCategorias.ReadOnly = true;
            dataGridViewCategorias.RowHeadersVisible = false;
            dataGridViewCategorias.RowHeadersWidth = 51;
            dataGridViewCategorias.RowTemplate.Height = 29;
            dataGridViewCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategorias.Size = new Size(611, 253);
            dataGridViewCategorias.TabIndex = 2;
            dataGridViewCategorias.CellContentClick += dataGridViewCategorias_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 11;
            label1.Text = "Buscar:";
            // 
            // txtBuscarCategoria
            // 
            txtBuscarCategoria.BackColor = Color.PapayaWhip;
            txtBuscarCategoria.Location = new Point(429, 26);
            txtBuscarCategoria.Multiline = true;
            txtBuscarCategoria.Name = "txtBuscarCategoria";
            txtBuscarCategoria.Size = new Size(194, 28);
            txtBuscarCategoria.TabIndex = 10;
            // 
            // cboTipoBuscar
            // 
            cboTipoBuscar.FormattingEnabled = true;
            cboTipoBuscar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Nombre" });
            cboTipoBuscar.Location = new Point(310, 26);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(113, 28);
            cboTipoBuscar.TabIndex = 9;
            // 
            // btnActualizarCategoria
            // 
            btnActualizarCategoria.FlatStyle = FlatStyle.Popup;
            btnActualizarCategoria.Location = new Point(153, 359);
            btnActualizarCategoria.Name = "btnActualizarCategoria";
            btnActualizarCategoria.Size = new Size(135, 45);
            btnActualizarCategoria.TabIndex = 14;
            btnActualizarCategoria.Text = "Actualizar";
            btnActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.FlatStyle = FlatStyle.Popup;
            btnEliminarCategoria.Location = new Point(294, 359);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(135, 45);
            btnEliminarCategoria.TabIndex = 13;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.FlatStyle = FlatStyle.Popup;
            btnAgregarCategoria.Location = new Point(12, 359);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(135, 45);
            btnAgregarCategoria.TabIndex = 12;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 432);
            Controls.Add(btnActualizarCategoria);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(label1);
            Controls.Add(txtBuscarCategoria);
            Controls.Add(cboTipoBuscar);
            Controls.Add(dataGridViewCategorias);
            Name = "FrmCategorias";
            Text = "Categorias";
            Load += FrmCategorias_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(dataGridViewCategorias, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(txtBuscarCategoria, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnAgregarCategoria, 0);
            Controls.SetChildIndex(btnEliminarCategoria, 0);
            Controls.SetChildIndex(btnActualizarCategoria, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewCategorias;
        private Label label1;
        private TextBox txtBuscarCategoria;
        private ComboBox cboTipoBuscar;
        private Button btnActualizarCategoria;
        private Button btnEliminarCategoria;
        private Button btnAgregarCategoria;
    }
}