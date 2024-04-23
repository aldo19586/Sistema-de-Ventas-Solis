namespace CapaPresentacion
{
    partial class FrmActualizarProveedor
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
            txtEmailPve = new TextBox();
            label6 = new Label();
            txtTelefonoPve = new TextBox();
            label5 = new Label();
            txtRucPve = new TextBox();
            label4 = new Label();
            txtNombrePve = new TextBox();
            label2 = new Label();
            txtDireccionPve = new TextBox();
            label3 = new Label();
            txtCodigoPve = new TextBox();
            label1 = new Label();
            btnGuardarActualizarProveedor = new Button();
            txtIdPve = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(491, 246);
            // 
            // txtEmailPve
            // 
            txtEmailPve.BackColor = Color.PapayaWhip;
            txtEmailPve.BorderStyle = BorderStyle.FixedSingle;
            txtEmailPve.Location = new Point(259, 192);
            txtEmailPve.Multiline = true;
            txtEmailPve.Name = "txtEmailPve";
            txtEmailPve.Size = new Size(366, 25);
            txtEmailPve.TabIndex = 30;
            txtEmailPve.TextChanged += txtEmailPve_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 169);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 29;
            label6.Text = "Email Proveedor:";
            // 
            // txtTelefonoPve
            // 
            txtTelefonoPve.BackColor = Color.PapayaWhip;
            txtTelefonoPve.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoPve.Location = new Point(24, 192);
            txtTelefonoPve.Multiline = true;
            txtTelefonoPve.Name = "txtTelefonoPve";
            txtTelefonoPve.Size = new Size(185, 25);
            txtTelefonoPve.TabIndex = 28;
            txtTelefonoPve.TextChanged += txtTelefonoPve_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 169);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 27;
            label5.Text = "Teléfono Proveedor:";
            // 
            // txtRucPve
            // 
            txtRucPve.BackColor = Color.PapayaWhip;
            txtRucPve.BorderStyle = BorderStyle.FixedSingle;
            txtRucPve.Location = new Point(24, 127);
            txtRucPve.Multiline = true;
            txtRucPve.Name = "txtRucPve";
            txtRucPve.Size = new Size(185, 25);
            txtRucPve.TabIndex = 26;
            txtRucPve.TextChanged += txtRucPve_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 104);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 25;
            label4.Text = "RUC :";
            // 
            // txtNombrePve
            // 
            txtNombrePve.BackColor = Color.PapayaWhip;
            txtNombrePve.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePve.Location = new Point(259, 55);
            txtNombrePve.Multiline = true;
            txtNombrePve.Name = "txtNombrePve";
            txtNombrePve.Size = new Size(366, 25);
            txtNombrePve.TabIndex = 24;
            txtNombrePve.TextChanged += txtNombrePve_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 32);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 23;
            label2.Text = "Nombre Proveedor:";
            // 
            // txtDireccionPve
            // 
            txtDireccionPve.BackColor = Color.PapayaWhip;
            txtDireccionPve.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionPve.Location = new Point(259, 127);
            txtDireccionPve.Multiline = true;
            txtDireccionPve.Name = "txtDireccionPve";
            txtDireccionPve.Size = new Size(366, 25);
            txtDireccionPve.TabIndex = 22;
            txtDireccionPve.TextChanged += txtDireccionPve_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 104);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 21;
            label3.Text = "Direccion Proveedor:";
            // 
            // txtCodigoPve
            // 
            txtCodigoPve.BackColor = Color.PapayaWhip;
            txtCodigoPve.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPve.Enabled = false;
            txtCodigoPve.Location = new Point(24, 55);
            txtCodigoPve.Multiline = true;
            txtCodigoPve.Name = "txtCodigoPve";
            txtCodigoPve.Size = new Size(185, 25);
            txtCodigoPve.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 19;
            label1.Text = "Codigo Proveedor:";
            // 
            // btnGuardarActualizarProveedor
            // 
            btnGuardarActualizarProveedor.Enabled = false;
            btnGuardarActualizarProveedor.FlatStyle = FlatStyle.Popup;
            btnGuardarActualizarProveedor.Location = new Point(321, 244);
            btnGuardarActualizarProveedor.Name = "btnGuardarActualizarProveedor";
            btnGuardarActualizarProveedor.Size = new Size(135, 45);
            btnGuardarActualizarProveedor.TabIndex = 34;
            btnGuardarActualizarProveedor.Text = "Actualizar";
            btnGuardarActualizarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtIdPve
            // 
            txtIdPve.BackColor = Color.PapayaWhip;
            txtIdPve.BorderStyle = BorderStyle.FixedSingle;
            txtIdPve.Location = new Point(146, 4);
            txtIdPve.Multiline = true;
            txtIdPve.Name = "txtIdPve";
            txtIdPve.Size = new Size(63, 25);
            txtIdPve.TabIndex = 41;
            // 
            // FrmActualizarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 320);
            Controls.Add(txtIdPve);
            Controls.Add(btnGuardarActualizarProveedor);
            Controls.Add(txtEmailPve);
            Controls.Add(label6);
            Controls.Add(txtTelefonoPve);
            Controls.Add(label5);
            Controls.Add(txtRucPve);
            Controls.Add(label4);
            Controls.Add(txtNombrePve);
            Controls.Add(label2);
            Controls.Add(txtDireccionPve);
            Controls.Add(label3);
            Controls.Add(txtCodigoPve);
            Controls.Add(label1);
            Name = "FrmActualizarProveedor";
            Text = "FrmActualizarProveedor";
            Load += FrmActualizarProveedor_Load;
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigoPve, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtDireccionPve, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNombrePve, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtRucPve, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtTelefonoPve, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtEmailPve, 0);
            Controls.SetChildIndex(btnGuardarActualizarProveedor, 0);
            Controls.SetChildIndex(txtIdPve, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtEmailPve;
        private Label label6;
        public TextBox txtTelefonoPve;
        private Label label5;
        public TextBox txtRucPve;
        private Label label4;
        public TextBox txtNombrePve;
        private Label label2;
        public TextBox txtDireccionPve;
        private Label label3;
        public TextBox txtCodigoPve;
        private Label label1;
        private Button btnGuardarActualizarProveedor;
        public TextBox txtIdPve;
    }
}