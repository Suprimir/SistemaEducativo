namespace SistemaEducativo.Views.Admin
{
    partial class FrmAsignarMateria
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
            comboBoxMaterias = new ComboBox();
            lblMateriasStatic = new Label();
            lblCarrerasStatic = new Label();
            comboBoxCarreras = new ComboBox();
            btnAsignarMateria = new Button();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(12, 27);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(121, 23);
            comboBoxMaterias.TabIndex = 0;
            // 
            // lblMateriasStatic
            // 
            lblMateriasStatic.AutoSize = true;
            lblMateriasStatic.Location = new Point(12, 9);
            lblMateriasStatic.Name = "lblMateriasStatic";
            lblMateriasStatic.Size = new Size(52, 15);
            lblMateriasStatic.TabIndex = 1;
            lblMateriasStatic.Text = "Materias";
            // 
            // lblCarrerasStatic
            // 
            lblCarrerasStatic.AutoSize = true;
            lblCarrerasStatic.Location = new Point(139, 9);
            lblCarrerasStatic.Name = "lblCarrerasStatic";
            lblCarrerasStatic.Size = new Size(50, 15);
            lblCarrerasStatic.TabIndex = 2;
            lblCarrerasStatic.Text = "Carreras";
            // 
            // comboBoxCarreras
            // 
            comboBoxCarreras.FormattingEnabled = true;
            comboBoxCarreras.Location = new Point(139, 27);
            comboBoxCarreras.Name = "comboBoxCarreras";
            comboBoxCarreras.Size = new Size(121, 23);
            comboBoxCarreras.TabIndex = 3;
            // 
            // btnAsignarMateria
            // 
            btnAsignarMateria.Location = new Point(185, 120);
            btnAsignarMateria.Name = "btnAsignarMateria";
            btnAsignarMateria.Size = new Size(75, 23);
            btnAsignarMateria.TabIndex = 4;
            btnAsignarMateria.Text = "Asignar";
            btnAsignarMateria.UseVisualStyleBackColor = true;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Location = new Point(139, 63);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(55, 15);
            lblSemestreStatic.TabIndex = 5;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(139, 81);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 6;
            // 
            // FrmAsignarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 153);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(btnAsignarMateria);
            Controls.Add(comboBoxCarreras);
            Controls.Add(lblCarrerasStatic);
            Controls.Add(lblMateriasStatic);
            Controls.Add(comboBoxMaterias);
            Name = "FrmAsignarMateria";
            Text = "FrmAsignarMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMaterias;
        private Label lblMateriasStatic;
        private Label lblCarrerasStatic;
        private ComboBox comboBoxCarreras;
        private Button btnAsignarMateria;
        private Label lblSemestreStatic;
        private ComboBox comboBoxSemestres;
    }
}