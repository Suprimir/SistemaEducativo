﻿namespace SistemaEducativo.Views.Alumno
{
    partial class FrmTareaAlumno
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
            lblTitulo = new Label();
            lblParcial = new Label();
            btnVerTarea = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(18, 17);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.Location = new Point(18, 46);
            lblParcial.Margin = new Padding(2, 0, 2, 0);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(42, 15);
            lblParcial.TabIndex = 1;
            lblParcial.Text = "Parcial";
            // 
            // btnVerTarea
            // 
            btnVerTarea.Location = new Point(159, 78);
            btnVerTarea.Margin = new Padding(2);
            btnVerTarea.Name = "btnVerTarea";
            btnVerTarea.Size = new Size(95, 23);
            btnVerTarea.TabIndex = 2;
            btnVerTarea.Text = "Ver Detalles";
            btnVerTarea.UseVisualStyleBackColor = true;
            // 
            // FrmTareaAlumno
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(228, 220, 201);
            ClientSize = new Size(266, 110);
            Controls.Add(btnVerTarea);
            Controls.Add(lblParcial);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmTareaAlumno";
            Text = "FrmTareaAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTitulo;
        public Label lblParcial;
        public Button btnVerTarea;
    }
}