namespace CapaPresentacion
{
    partial class FrmAgregarCategoria
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
            txtDescripcionCat = new TextBox();
            label3 = new Label();
            txtNombreCat = new TextBox();
            label2 = new Label();
            txtCodigoCat = new TextBox();
            label1 = new Label();
            btnGuardarCategoria = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(342, 176);
            // 
            // txtDescripcionCat
            // 
            txtDescripcionCat.BackColor = Color.PapayaWhip;
            txtDescripcionCat.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionCat.Location = new Point(12, 130);
            txtDescripcionCat.Multiline = true;
            txtDescripcionCat.Name = "txtDescripcionCat";
            txtDescripcionCat.Size = new Size(464, 25);
            txtDescripcionCat.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 17;
            label3.Text = "Descripcion Categoria:";
            // 
            // txtNombreCat
            // 
            txtNombreCat.BackColor = Color.PapayaWhip;
            txtNombreCat.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCat.Location = new Point(196, 58);
            txtNombreCat.Multiline = true;
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(280, 25);
            txtNombreCat.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 35);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 15;
            label2.Text = "Nombre Categoria:";
            // 
            // txtCodigoCat
            // 
            txtCodigoCat.BackColor = Color.PapayaWhip;
            txtCodigoCat.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoCat.Enabled = false;
            txtCodigoCat.Location = new Point(12, 58);
            txtCodigoCat.Multiline = true;
            txtCodigoCat.Name = "txtCodigoCat";
            txtCodigoCat.Size = new Size(125, 25);
            txtCodigoCat.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 13;
            label1.Text = "Codigo Categoria:";
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.FlatStyle = FlatStyle.Popup;
            btnGuardarCategoria.Location = new Point(185, 176);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(135, 45);
            btnGuardarCategoria.TabIndex = 19;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = true;
            btnGuardarCategoria.Click += btnGuardarCategoria_Click;
            // 
            // FrmAgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 242);
            Controls.Add(btnGuardarCategoria);
            Controls.Add(txtDescripcionCat);
            Controls.Add(label3);
            Controls.Add(txtNombreCat);
            Controls.Add(label2);
            Controls.Add(txtCodigoCat);
            Controls.Add(label1);
            Name = "FrmAgregarCategoria";
            Text = "FrmAgregarCategoria";
            Load += FrmAgregarCategoria_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCodigoCat, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNombreCat, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtDescripcionCat, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnGuardarCategoria, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtDescripcionCat;
        private Label label3;
        public TextBox txtNombreCat;
        private Label label2;
        public TextBox txtCodigoCat;
        private Label label1;
        private Button btnGuardarCategoria;
    }
}