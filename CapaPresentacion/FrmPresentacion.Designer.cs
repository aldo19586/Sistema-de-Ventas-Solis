namespace CapaPresentacion
{
    partial class FrmPresentacion
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
            dataGridViewPresentaciones = new DataGridView();
            label1 = new Label();
            txtBuscarCategoria = new TextBox();
            cboTipoBuscar = new ComboBox();
            btnActualizarPresentacion = new Button();
            btnEliminarPresentacion = new Button();
            btnAgregarPresentacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPresentaciones).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(484, 357);
            // 
            // dataGridViewPresentaciones
            // 
            dataGridViewPresentaciones.AllowUserToAddRows = false;
            dataGridViewPresentaciones.AllowUserToDeleteRows = false;
            dataGridViewPresentaciones.AllowUserToResizeRows = false;
            dataGridViewPresentaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPresentaciones.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPresentaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPresentaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPresentaciones.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPresentaciones.EnableHeadersVisualStyles = false;
            dataGridViewPresentaciones.Location = new Point(12, 61);
            dataGridViewPresentaciones.Name = "dataGridViewPresentaciones";
            dataGridViewPresentaciones.ReadOnly = true;
            dataGridViewPresentaciones.RowHeadersVisible = false;
            dataGridViewPresentaciones.RowHeadersWidth = 51;
            dataGridViewPresentaciones.RowTemplate.Height = 29;
            dataGridViewPresentaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPresentaciones.Size = new Size(606, 257);
            dataGridViewPresentaciones.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 14;
            label1.Text = "Buscar:";
            // 
            // txtBuscarCategoria
            // 
            txtBuscarCategoria.BackColor = Color.PapayaWhip;
            txtBuscarCategoria.Location = new Point(448, 27);
            txtBuscarCategoria.Multiline = true;
            txtBuscarCategoria.Name = "txtBuscarCategoria";
            txtBuscarCategoria.Size = new Size(175, 28);
            txtBuscarCategoria.TabIndex = 13;
            // 
            // cboTipoBuscar
            // 
            cboTipoBuscar.FormattingEnabled = true;
            cboTipoBuscar.Items.AddRange(new object[] { "Codigo", "Descripcion", "Nombre" });
            cboTipoBuscar.Location = new Point(329, 27);
            cboTipoBuscar.Name = "cboTipoBuscar";
            cboTipoBuscar.Size = new Size(113, 28);
            cboTipoBuscar.TabIndex = 12;
            // 
            // btnActualizarPresentacion
            // 
            btnActualizarPresentacion.FlatStyle = FlatStyle.Popup;
            btnActualizarPresentacion.Location = new Point(153, 357);
            btnActualizarPresentacion.Name = "btnActualizarPresentacion";
            btnActualizarPresentacion.Size = new Size(135, 45);
            btnActualizarPresentacion.TabIndex = 17;
            btnActualizarPresentacion.Text = "Actualizar";
            btnActualizarPresentacion.UseVisualStyleBackColor = true;
            btnActualizarPresentacion.Click += btnActualizarPresentacion_Click;
            // 
            // btnEliminarPresentacion
            // 
            btnEliminarPresentacion.FlatStyle = FlatStyle.Popup;
            btnEliminarPresentacion.Location = new Point(294, 357);
            btnEliminarPresentacion.Name = "btnEliminarPresentacion";
            btnEliminarPresentacion.Size = new Size(135, 45);
            btnEliminarPresentacion.TabIndex = 16;
            btnEliminarPresentacion.Text = "Eliminar";
            btnEliminarPresentacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPresentacion
            // 
            btnAgregarPresentacion.FlatStyle = FlatStyle.Popup;
            btnAgregarPresentacion.Location = new Point(12, 357);
            btnAgregarPresentacion.Name = "btnAgregarPresentacion";
            btnAgregarPresentacion.Size = new Size(135, 45);
            btnAgregarPresentacion.TabIndex = 15;
            btnAgregarPresentacion.Text = "Agregar";
            btnAgregarPresentacion.UseVisualStyleBackColor = true;
            btnAgregarPresentacion.Click += btnAgregarPresentacion_Click;
            // 
            // FrmPresentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 432);
            Controls.Add(btnActualizarPresentacion);
            Controls.Add(btnEliminarPresentacion);
            Controls.Add(btnAgregarPresentacion);
            Controls.Add(label1);
            Controls.Add(txtBuscarCategoria);
            Controls.Add(cboTipoBuscar);
            Controls.Add(dataGridViewPresentaciones);
            Name = "FrmPresentacion";
            Text = "FrmPresentacion";
            Load += FrmPresentacion_Load;
            Controls.SetChildIndex(dataGridViewPresentaciones, 0);
            Controls.SetChildIndex(cboTipoBuscar, 0);
            Controls.SetChildIndex(txtBuscarCategoria, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnAgregarPresentacion, 0);
            Controls.SetChildIndex(btnEliminarPresentacion, 0);
            Controls.SetChildIndex(btnActualizarPresentacion, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPresentaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewPresentaciones;
        private Label label1;
        private TextBox txtBuscarCategoria;
        private ComboBox cboTipoBuscar;
        private Button btnActualizarPresentacion;
        private Button btnEliminarPresentacion;
        private Button btnAgregarPresentacion;
    }
}