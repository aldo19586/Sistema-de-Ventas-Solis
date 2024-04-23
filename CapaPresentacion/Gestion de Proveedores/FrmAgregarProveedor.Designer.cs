namespace CapaPresentacion
{
    partial class FrmAgregarProveedor
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
            txtDireccionPve = new TextBox();
            label3 = new Label();
            txtCodigoPve = new TextBox();
            label1 = new Label();
            txtNombrePve = new TextBox();
            label2 = new Label();
            txtRucPve = new TextBox();
            label4 = new Label();
            txtTelefonoPve = new TextBox();
            label5 = new Label();
            txtEmailPve = new TextBox();
            label6 = new Label();
            btnGuardarProveedor = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(500, 251);
            // 
            // txtDireccionPve
            // 
            txtDireccionPve.BackColor = Color.PapayaWhip;
            txtDireccionPve.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionPve.Location = new Point(268, 129);
            txtDireccionPve.Multiline = true;
            txtDireccionPve.Name = "txtDireccionPve";
            txtDireccionPve.Size = new Size(366, 25);
            txtDireccionPve.TabIndex = 10;
            txtDireccionPve.KeyPress += txtDireccionPve_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 106);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 9;
            label3.Text = "Direccion Proveedor:";
            // 
            // txtCodigoPve
            // 
            txtCodigoPve.BackColor = Color.PapayaWhip;
            txtCodigoPve.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPve.Enabled = false;
            txtCodigoPve.Location = new Point(33, 57);
            txtCodigoPve.Multiline = true;
            txtCodigoPve.Name = "txtCodigoPve";
            txtCodigoPve.Size = new Size(185, 25);
            txtCodigoPve.TabIndex = 8;
            txtCodigoPve.KeyPress += txtCodigoPve_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Codigo Proveedor:";
            // 
            // txtNombrePve
            // 
            txtNombrePve.BackColor = Color.PapayaWhip;
            txtNombrePve.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePve.Location = new Point(268, 57);
            txtNombrePve.Multiline = true;
            txtNombrePve.Name = "txtNombrePve";
            txtNombrePve.Size = new Size(366, 25);
            txtNombrePve.TabIndex = 12;
            txtNombrePve.KeyPress += txtNombrePve_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 34);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre Proveedor:";
            // 
            // txtRucPve
            // 
            txtRucPve.BackColor = Color.PapayaWhip;
            txtRucPve.BorderStyle = BorderStyle.FixedSingle;
            txtRucPve.Location = new Point(33, 129);
            txtRucPve.Multiline = true;
            txtRucPve.Name = "txtRucPve";
            txtRucPve.Size = new Size(185, 25);
            txtRucPve.TabIndex = 14;
            txtRucPve.KeyPress += txtRucPve_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 106);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 13;
            label4.Text = "RUC :";
            // 
            // txtTelefonoPve
            // 
            txtTelefonoPve.BackColor = Color.PapayaWhip;
            txtTelefonoPve.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoPve.Location = new Point(33, 194);
            txtTelefonoPve.Multiline = true;
            txtTelefonoPve.Name = "txtTelefonoPve";
            txtTelefonoPve.Size = new Size(185, 25);
            txtTelefonoPve.TabIndex = 16;
            txtTelefonoPve.KeyPress += txtTelefonoPve_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 171);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 15;
            label5.Text = "Teléfono Proveedor:";
            // 
            // txtEmailPve
            // 
            txtEmailPve.BackColor = Color.PapayaWhip;
            txtEmailPve.BorderStyle = BorderStyle.FixedSingle;
            txtEmailPve.Location = new Point(268, 194);
            txtEmailPve.Multiline = true;
            txtEmailPve.Name = "txtEmailPve";
            txtEmailPve.Size = new Size(366, 25);
            txtEmailPve.TabIndex = 18;
            txtEmailPve.KeyPress += txtEmailPve_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 171);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 17;
            label6.Text = "Email Proveedor:";
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.FlatStyle = FlatStyle.Popup;
            btnGuardarProveedor.Location = new Point(334, 250);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.Size = new Size(135, 45);
            btnGuardarProveedor.TabIndex = 19;
            btnGuardarProveedor.Text = "Agregar";
            btnGuardarProveedor.UseVisualStyleBackColor = true;
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // FrmAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 320);
            Controls.Add(btnGuardarProveedor);
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
            Name = "FrmAgregarProveedor";
            Text = "FrmAgregarProveedor";
            Load += FrmAgregarProveedor_Load;
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
            Controls.SetChildIndex(btnGuardarProveedor, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtDireccionPve;
        private Label label3;
        public TextBox txtCodigoPve;
        private Label label1;
        public TextBox txtNombrePve;
        private Label label2;
        public TextBox txtRucPve;
        private Label label4;
        public TextBox txtTelefonoPve;
        private Label label5;
        public TextBox txtEmailPve;
        private Label label6;
        private Button btnGuardarProveedor;
    }
}