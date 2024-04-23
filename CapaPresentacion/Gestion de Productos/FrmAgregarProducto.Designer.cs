namespace CapaPresentacion
{
    partial class FrmAgregarProducto
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtCodigoPro = new TextBox();
            txtNombrePro = new TextBox();
            label2 = new Label();
            txtDescripcionPro = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCostoUnitarioPro = new TextBox();
            label5 = new Label();
            txtPrecioVentaPro = new TextBox();
            label6 = new Label();
            cboTipoCargoPro = new ComboBox();
            label7 = new Label();
            btnGuardarProducto = new Button();
            cboPresentacion = new ComboBox();
            cboCategoria = new ComboBox();
            label8 = new Label();
            pbxQR = new PictureBox();
            btnGenerarQR = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxQR).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(579, 300);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Codigo Producto:";
            // 
            // txtCodigoPro
            // 
            txtCodigoPro.BackColor = Color.PapayaWhip;
            txtCodigoPro.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPro.Enabled = false;
            txtCodigoPro.Location = new Point(23, 54);
            txtCodigoPro.Multiline = true;
            txtCodigoPro.Name = "txtCodigoPro";
            txtCodigoPro.Size = new Size(185, 25);
            txtCodigoPro.TabIndex = 2;
            // 
            // txtNombrePro
            // 
            txtNombrePro.BackColor = Color.PapayaWhip;
            txtNombrePro.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePro.Location = new Point(423, 54);
            txtNombrePro.Multiline = true;
            txtNombrePro.Name = "txtNombrePro";
            txtNombrePro.Size = new Size(336, 25);
            txtNombrePro.TabIndex = 4;
            txtNombrePro.KeyPress += txtNombre_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 31);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre Producto:";
            // 
            // txtDescripcionPro
            // 
            txtDescripcionPro.BackColor = Color.PapayaWhip;
            txtDescripcionPro.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionPro.Location = new Point(23, 126);
            txtDescripcionPro.Multiline = true;
            txtDescripcionPro.Name = "txtDescripcionPro";
            txtDescripcionPro.Size = new Size(366, 25);
            txtDescripcionPro.TabIndex = 6;
            txtDescripcionPro.KeyPress += txtDescripcion_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 103);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripcion Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 103);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 7;
            label4.Text = "Presentacion Producto:";
            // 
            // txtCostoUnitarioPro
            // 
            txtCostoUnitarioPro.BackColor = Color.PapayaWhip;
            txtCostoUnitarioPro.BorderStyle = BorderStyle.FixedSingle;
            txtCostoUnitarioPro.Location = new Point(23, 208);
            txtCostoUnitarioPro.Multiline = true;
            txtCostoUnitarioPro.Name = "txtCostoUnitarioPro";
            txtCostoUnitarioPro.Size = new Size(157, 25);
            txtCostoUnitarioPro.TabIndex = 10;
            txtCostoUnitarioPro.KeyPress += txtCostoUnitario_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 185);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 9;
            label5.Text = "Costo Unitario:";
            // 
            // txtPrecioVentaPro
            // 
            txtPrecioVentaPro.BackColor = Color.PapayaWhip;
            txtPrecioVentaPro.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVentaPro.Location = new Point(237, 208);
            txtPrecioVentaPro.Multiline = true;
            txtPrecioVentaPro.Name = "txtPrecioVentaPro";
            txtPrecioVentaPro.Size = new Size(157, 25);
            txtPrecioVentaPro.TabIndex = 12;
            txtPrecioVentaPro.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 185);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 11;
            label6.Text = "Precio Venta:";
            // 
            // cboTipoCargoPro
            // 
            cboTipoCargoPro.BackColor = Color.PapayaWhip;
            cboTipoCargoPro.FlatStyle = FlatStyle.System;
            cboTipoCargoPro.FormattingEnabled = true;
            cboTipoCargoPro.Items.AddRange(new object[] { "Dañado", "Activo" });
            cboTipoCargoPro.Location = new Point(413, 208);
            cboTipoCargoPro.Name = "cboTipoCargoPro";
            cboTipoCargoPro.Size = new Size(157, 28);
            cboTipoCargoPro.TabIndex = 14;
            cboTipoCargoPro.KeyPress += cboTipoCargo_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 185);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 15;
            label7.Text = "Tipo de Cargo:";
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.FlatStyle = FlatStyle.Popup;
            btnGuardarProducto.Location = new Point(420, 300);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(135, 45);
            btnGuardarProducto.TabIndex = 16;
            btnGuardarProducto.Text = "Agregar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // cboPresentacion
            // 
            cboPresentacion.BackColor = Color.PapayaWhip;
            cboPresentacion.FlatStyle = FlatStyle.System;
            cboPresentacion.FormattingEnabled = true;
            cboPresentacion.Location = new Point(416, 126);
            cboPresentacion.Name = "cboPresentacion";
            cboPresentacion.Size = new Size(157, 28);
            cboPresentacion.TabIndex = 17;
            cboPresentacion.KeyPress += cboPresentacion_KeyPress;
            // 
            // cboCategoria
            // 
            cboCategoria.BackColor = Color.PapayaWhip;
            cboCategoria.FlatStyle = FlatStyle.System;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(237, 54);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(157, 28);
            cboCategoria.TabIndex = 18;
            cboCategoria.KeyPress += cboCategoria_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 31);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 19;
            label8.Text = "Categoria Producto:";
            // 
            // pbxQR
            // 
            pbxQR.Location = new Point(614, 95);
            pbxQR.Name = "pbxQR";
            pbxQR.Size = new Size(122, 141);
            pbxQR.TabIndex = 20;
            pbxQR.TabStop = false;
            // 
            // btnGenerarQR
            // 
            btnGenerarQR.FlatStyle = FlatStyle.Popup;
            btnGenerarQR.Location = new Point(614, 239);
            btnGenerarQR.Name = "btnGenerarQR";
            btnGenerarQR.Size = new Size(122, 35);
            btnGenerarQR.TabIndex = 21;
            btnGenerarQR.Text = "Generar QR";
            btnGenerarQR.UseVisualStyleBackColor = true;
            btnGenerarQR.Click += btnGenerarQR_Click;
            btnGenerarQR.KeyPress += btnGenerarQR_KeyPress;
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 360);
            Controls.Add(btnGenerarQR);
            Controls.Add(pbxQR);
            Controls.Add(label8);
            Controls.Add(cboCategoria);
            Controls.Add(cboPresentacion);
            Controls.Add(btnGuardarProducto);
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
            Name = "FrmAgregarProducto";
            Text = "Agregar Producto";
            Load += FrmAgregarProducto_Load;
            Controls.SetChildIndex(btnCancelar, 0);
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
            Controls.SetChildIndex(btnGuardarProducto, 0);
            Controls.SetChildIndex(cboPresentacion, 0);
            Controls.SetChildIndex(cboCategoria, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(pbxQR, 0);
            Controls.SetChildIndex(btnGenerarQR, 0);
            ((System.ComponentModel.ISupportInitialize)pbxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox txtCodigoPro;
        public TextBox txtNombrePro;
        private Label label2;
        public TextBox txtDescripcionPro;
        private Label label3;
        private Label label4;
        public TextBox txtCostoUnitarioPro;
        private Label label5;
        public TextBox txtPrecioVentaPro;
        private Label label6;
        private ComboBox cboTipoCargoPro;
        private Label label7;
        private Button btnGuardarProducto;
        private ComboBox cboPresentacion;
        private ComboBox cboCategoria;
        private Label label8;
        private PictureBox pbxQR;
        private Button btnGenerarQR;
        public System.Windows.Forms.Timer timer1;
    }
}