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
            lblMateria = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 24);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.Location = new Point(12, 56);
            lblParcial.Margin = new Padding(2, 0, 2, 0);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(42, 15);
            lblParcial.TabIndex = 1;
            lblParcial.Text = "Parcial";
            // 
            // btnVerTarea
            // 
            btnVerTarea.BackColor = Color.FromArgb(221, 223, 244);
            btnVerTarea.FlatAppearance.BorderSize = 0;
            btnVerTarea.FlatStyle = FlatStyle.Flat;
            btnVerTarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerTarea.Location = new Point(178, 52);
            btnVerTarea.Margin = new Padding(2);
            btnVerTarea.Name = "btnVerTarea";
            btnVerTarea.Size = new Size(95, 23);
            btnVerTarea.TabIndex = 2;
            btnVerTarea.Text = "Ver Detalles";
            btnVerTarea.UseVisualStyleBackColor = false;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(12, 9);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Materia";
            // 
            // FrmTareaAlumno
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(254, 254, 255);
            ClientSize = new Size(284, 86);
            Controls.Add(lblMateria);
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
        public Label lblMateria;
    }
}