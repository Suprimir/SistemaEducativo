namespace SistemaEducativo.Views.Alumno
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
            lblTitulo.Location = new Point(23, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.Location = new Point(23, 58);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(52, 20);
            lblParcial.TabIndex = 1;
            lblParcial.Text = "Parcial";
            // 
            // btnVerTarea
            // 
            btnVerTarea.Location = new Point(199, 97);
            btnVerTarea.Name = "btnVerTarea";
            btnVerTarea.Size = new Size(119, 29);
            btnVerTarea.TabIndex = 2;
            btnVerTarea.Text = "Ver Detalles";
            btnVerTarea.UseVisualStyleBackColor = true;
            // 
            // FrmTareaAlumno
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(228, 220, 201);
            ClientSize = new Size(330, 138);
            Controls.Add(btnVerTarea);
            Controls.Add(lblParcial);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
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