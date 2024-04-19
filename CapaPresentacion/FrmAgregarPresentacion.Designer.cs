namespace CapaPresentacion
{
    partial class FrmAgregarPresentacion
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
            btnGuardarPresentacion = new Button();
            txtDescripcionPre = new TextBox();
            label3 = new Label();
            txtNombrePre = new TextBox();
            label2 = new Label();
            txtCodigoPre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(337, 187);
            // 
            // btnGuardarPresentacion
            // 
            btnGuardarPresentacion.FlatStyle = FlatStyle.Popup;
            btnGuardarPresentacion.Location = new Point(191, 185);
            btnGuardarPresentacion.Name = "btnGuardarPresentacion";
            btnGuardarPresentacion.Size = new Size(135, 45);
            btnGuardarPresentacion.TabIndex = 26;
            btnGuardarPresentacion.Text = "Guardar";
            btnGuardarPresentacion.UseVisualStyleBackColor = true;
            btnGuardarPresentacion.Click += btnGuardarPresentacion_Click;
            // 
            // txtDescripcionPre
            // 
            txtDescripcionPre.BackColor = Color.PapayaWhip;
            txtDescripcionPre.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionPre.Location = new Point(7, 142);
            txtDescripcionPre.Multiline = true;
            txtDescripcionPre.Name = "txtDescripcionPre";
            txtDescripcionPre.Size = new Size(464, 25);
            txtDescripcionPre.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 119);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 24;
            label3.Text = "Descripcion Presentacion:";
            // 
            // txtNombrePre
            // 
            txtNombrePre.BackColor = Color.PapayaWhip;
            txtNombrePre.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePre.Location = new Point(191, 70);
            txtNombrePre.Multiline = true;
            txtNombrePre.Name = "txtNombrePre";
            txtNombrePre.Size = new Size(280, 25);
            txtNombrePre.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 47);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre Presentacion:";
            // 
            // txtCodigoPre
            // 
            txtCodigoPre.BackColor = Color.PapayaWhip;
            txtCodigoPre.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPre.Enabled = false;
            txtCodigoPre.Location = new Point(7, 70);
            txtCodigoPre.Multiline = true;
            txtCodigoPre.Name = "txtCodigoPre";
            txtCodigoPre.Size = new Size(125, 25);
            txtCodigoPre.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 47);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 20;
            label1.Text = "Codigo Presentacion:";
            // 
            // FrmAgregarPresentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 242);
            Controls.Add(btnGuardarPresentacion);
            Controls.Add(txtDescripcionPre);
            Controls.Add(label3);
            Controls.Add(txtNombrePre);
            Controls.Add(label2);
            Controls.Add(txtCodigoPre);
            Controls.Add(label1);
            Name = "FrmAgregarPresentacion";
            Text = "FrmAgregarPresentacion";
            Load += FrmAgregarPresentacion_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigoPre, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNombrePre, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtDescripcionPre, 0);
            Controls.SetChildIndex(btnGuardarPresentacion, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarPresentacion;
        public TextBox txtDescripcionPre;
        private Label label3;
        public TextBox txtNombrePre;
        private Label label2;
        public TextBox txtCodigoPre;
        private Label label1;
    }
}