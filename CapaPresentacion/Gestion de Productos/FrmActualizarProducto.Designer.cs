namespace CapaPresentacion
{
    partial class FrmActualizarProducto
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
            label8 = new Label();
            cboCategoria = new ComboBox();
            cboPresentacion = new ComboBox();
            btnGuardarActualizarProducto = new Button();
            label7 = new Label();
            cboTipoCargoPro = new ComboBox();
            txtPrecioVentaPro = new TextBox();
            label6 = new Label();
            txtCostoUnitarioPro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDescripcionPro = new TextBox();
            label3 = new Label();
            txtNombrePro = new TextBox();
            label2 = new Label();
            txtCodigoPro = new TextBox();
            label1 = new Label();
            btnGenerarQR = new Button();
            pbxQR = new PictureBox();
            txtIdPro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxQR).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(585, 294);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 23);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 36;
            label8.Text = "Categoria Producto:";
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = Color.PapayaWhip;
            cboCategoria.FlatStyle = FlatStyle.System;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(235, 46);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(157, 28);
            cboCategoria.TabIndex = 35;
            cboCategoria.TextChanged += cboCategoria_TextChanged;
            cboCategoria.KeyPress += cboCategoria_KeyPress_1;
            // 
            // cboPresentacion
            // 
            cboPresentacion.BackColor = Color.PapayaWhip;
            cboPresentacion.FlatStyle = FlatStyle.System;
            cboPresentacion.FormattingEnabled = true;
            cboPresentacion.Location = new Point(411, 123);
            cboPresentacion.Name = "cboPresentacion";
            cboPresentacion.Size = new Size(157, 28);
            cboPresentacion.TabIndex = 34;
            cboPresentacion.TextChanged += cboPresentacion_TextChanged;
            cboPresentacion.KeyPress += cboPresentacion_KeyPress;
            // 
            // btnGuardarActualizarProducto
            // 
            btnGuardarActualizarProducto.Enabled = false;
            btnGuardarActualizarProducto.FlatStyle = FlatStyle.Popup;
            btnGuardarActualizarProducto.Location = new Point(418, 292);
            btnGuardarActualizarProducto.Name = "btnGuardarActualizarProducto";
            btnGuardarActualizarProducto.Size = new Size(135, 45);
            btnGuardarActualizarProducto.TabIndex = 33;
            btnGuardarActualizarProducto.Text = "Actualizar";
            btnGuardarActualizarProducto.UseVisualStyleBackColor = true;
            btnGuardarActualizarProducto.Click += btnGuardarActualizarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 177);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 32;
            label7.Text = "Tipo de Cargo:";
            // 
            // cboTipoCargoPro
            // 
            cboTipoCargoPro.BackColor = Color.PapayaWhip;
            cboTipoCargoPro.FlatStyle = FlatStyle.System;
            cboTipoCargoPro.FormattingEnabled = true;
            cboTipoCargoPro.Items.AddRange(new object[] { "Dañado", "Activo" });
            cboTipoCargoPro.Location = new Point(411, 200);
            cboTipoCargoPro.Name = "cboTipoCargoPro";
            cboTipoCargoPro.Size = new Size(157, 28);
            cboTipoCargoPro.TabIndex = 31;
            cboTipoCargoPro.TextChanged += cboTipoCargoPro_TextChanged;
            cboTipoCargoPro.KeyPress += cboTipoCargoPro_KeyPress;
            // 
            // txtPrecioVentaPro
            // 
            txtPrecioVentaPro.BackColor = Color.PapayaWhip;
            txtPrecioVentaPro.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVentaPro.Location = new Point(235, 200);
            txtPrecioVentaPro.Multiline = true;
            txtPrecioVentaPro.Name = "txtPrecioVentaPro";
            txtPrecioVentaPro.Size = new Size(157, 25);
            txtPrecioVentaPro.TabIndex = 30;
            txtPrecioVentaPro.TextChanged += txtPrecioVentaPro_TextChanged;
            txtPrecioVentaPro.KeyPress += txtPrecioVentaPro_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 177);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 29;
            label6.Text = "Precio Venta:";
            // 
            // txtCostoUnitarioPro
            // 
            txtCostoUnitarioPro.BackColor = Color.PapayaWhip;
            txtCostoUnitarioPro.BorderStyle = BorderStyle.FixedSingle;
            txtCostoUnitarioPro.Location = new Point(21, 200);
            txtCostoUnitarioPro.Multiline = true;
            txtCostoUnitarioPro.Name = "txtCostoUnitarioPro";
            txtCostoUnitarioPro.Size = new Size(157, 25);
            txtCostoUnitarioPro.TabIndex = 28;
            txtCostoUnitarioPro.TextChanged += txtCostoUnitarioPro_TextChanged;
            txtCostoUnitarioPro.KeyPress += txtCostoUnitarioPro_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 177);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 27;
            label5.Text = "Costo Unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 100);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 26;
            label4.Text = "Presentacion Producto:";
            // 
            // txtDescripcionPro
            // 
            txtDescripcionPro.BackColor = Color.PapayaWhip;
            txtDescripcionPro.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionPro.Location = new Point(21, 118);
            txtDescripcionPro.Multiline = true;
            txtDescripcionPro.Name = "txtDescripcionPro";
            txtDescripcionPro.Size = new Size(366, 25);
            txtDescripcionPro.TabIndex = 25;
            txtDescripcionPro.TextChanged += txtDescripcionPro_TextChanged;
            txtDescripcionPro.KeyPress += txtDescripcionPro_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 95);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 24;
            label3.Text = "Descripcion Producto:";
            // 
            // txtNombrePro
            // 
            txtNombrePro.BackColor = Color.PapayaWhip;
            txtNombrePro.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePro.Location = new Point(421, 46);
            txtNombrePro.Multiline = true;
            txtNombrePro.Name = "txtNombrePro";
            txtNombrePro.Size = new Size(336, 25);
            txtNombrePro.TabIndex = 23;
            txtNombrePro.TextChanged += txtNombrePro_TextChanged;
            txtNombrePro.KeyPress += txtNombrePro_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 23);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre Producto:";
            // 
            // txtCodigoPro
            // 
            txtCodigoPro.BackColor = Color.PapayaWhip;
            txtCodigoPro.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPro.Enabled = false;
            txtCodigoPro.Location = new Point(21, 46);
            txtCodigoPro.Multiline = true;
            txtCodigoPro.Name = "txtCodigoPro";
            txtCodigoPro.Size = new Size(185, 25);
            txtCodigoPro.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 20;
            label1.Text = "Codigo Producto:";
            // 
            // btnGenerarQR
            // 
            btnGenerarQR.FlatStyle = FlatStyle.Popup;
            btnGenerarQR.Location = new Point(635, 239);
            btnGenerarQR.Name = "btnGenerarQR";
            btnGenerarQR.Size = new Size(122, 35);
            btnGenerarQR.TabIndex = 38;
            btnGenerarQR.Text = "Generar QR";
            btnGenerarQR.UseVisualStyleBackColor = true;
            btnGenerarQR.Click += btnGenerarQR_Click;
            btnGenerarQR.KeyPress += btnGenerarQR_KeyPress;
            // 
            // pbxQR
            // 
            pbxQR.Location = new Point(635, 95);
            pbxQR.Name = "pbxQR";
            pbxQR.Size = new Size(122, 141);
            pbxQR.TabIndex = 37;
            pbxQR.TabStop = false;
            // 
            // txtIdPro
            // 
            txtIdPro.BackColor = Color.PapayaWhip;
            txtIdPro.BorderStyle = BorderStyle.FixedSingle;
            txtIdPro.Location = new Point(152, 12);
            txtIdPro.Multiline = true;
            txtIdPro.Name = "txtIdPro";
            txtIdPro.Size = new Size(63, 25);
            txtIdPro.TabIndex = 39;
            // 
            // FrmActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 360);
            Controls.Add(txtIdPro);
            Controls.Add(btnGenerarQR);
            Controls.Add(pbxQR);
            Controls.Add(label8);
            Controls.Add(cboCategoria);
            Controls.Add(cboPresentacion);
            Controls.Add(btnGuardarActualizarProducto);
            Controls.Add(label7);
            Controls.Add(cboTipoCargoPro);
            Controls.Add(txtPrecioVentaPro);
            Controls.Add(label6);
            Controls.Add(txtCostoUnitarioPro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescripcionPro);
            Controls.Add(label3);
            Controls.Add(txtNombrePro);
            Controls.Add(label2);
            Controls.Add(txtCodigoPro);
            Controls.Add(label1);
            Name = "FrmActualizarProducto";
            Text = "Actualizar Producto";
            Load += FrmActualizarProducto_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigoPro, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNombrePro, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtDescripcionPro, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtCostoUnitarioPro, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtPrecioVentaPro, 0);
            Controls.SetChildIndex(cboTipoCargoPro, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(btnGuardarActualizarProducto, 0);
            Controls.SetChildIndex(cboPresentacion, 0);
            Controls.SetChildIndex(cboCategoria, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(pbxQR, 0);
            Controls.SetChildIndex(btnGenerarQR, 0);
            Controls.SetChildIndex(txtIdPro, 0);
            ((System.ComponentModel.ISupportInitialize)pbxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button btnGuardarActualizarProducto;
        private Label label7;
        public TextBox txtPrecioVentaPro;
        private Label label6;
        public TextBox txtCostoUnitarioPro;
        private Label label5;
        private Label label4;
        public TextBox txtDescripcionPro;
        private Label label3;
        public TextBox txtNombrePro;
        private Label label2;
        public TextBox txtCodigoPro;
        private Label label1;
        private Button btnGenerarQR;
        public TextBox txtIdPro;
        public ComboBox cboCategoria;
        public ComboBox cboPresentacion;
        public ComboBox cboTipoCargoPro;
        public PictureBox pbxQR;
    }
}