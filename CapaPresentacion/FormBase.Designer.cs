﻿namespace CapaPresentacion
{
    partial class FormBase
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
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Azure;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(1020, 477);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(134, 43);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button1_Click;
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 576);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FormBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Base";
            Load += FrmBase_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button btnCancelar;
    }
}