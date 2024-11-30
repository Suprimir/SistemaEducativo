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
            lblNombreMateriaStatic = new Label();
            lblCarrerasStatic = new Label();
            comboBoxCarreras = new ComboBox();
            btnAsignarMateria = new Button();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            lblNombreMateria = new Label();
            SuspendLayout();
            // 
            // lblNombreMateriaStatic
            // 
            lblNombreMateriaStatic.AutoSize = true;
            lblNombreMateriaStatic.Location = new Point(12, 9);
            lblNombreMateriaStatic.Name = "lblNombreMateriaStatic";
            lblNombreMateriaStatic.Size = new Size(119, 15);
            lblNombreMateriaStatic.TabIndex = 1;
            lblNombreMateriaStatic.Text = "Materia Seleccionada";
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
            comboBoxCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
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
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(139, 81);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 6;
            // 
            // lblNombreMateria
            // 
            lblNombreMateria.AutoSize = true;
            lblNombreMateria.Location = new Point(12, 27);
            lblNombreMateria.Name = "lblNombreMateria";
            lblNombreMateria.Size = new Size(89, 15);
            lblNombreMateria.TabIndex = 7;
            lblNombreMateria.Text = "nombreMateria";
            // 
            // FrmAsignarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 153);
            Controls.Add(lblNombreMateria);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(btnAsignarMateria);
            Controls.Add(comboBoxCarreras);
            Controls.Add(lblCarrerasStatic);
            Controls.Add(lblNombreMateriaStatic);
            Name = "FrmAsignarMateria";
            Text = "FrmAsignarMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreMateriaStatic;
        private Label lblCarrerasStatic;
        private Label lblSemestreStatic;
        public Button btnAsignarMateria;
        public ComboBox comboBoxCarreras;
        public ComboBox comboBoxSemestres;
        public Label lblNombreMateria;
    }
}