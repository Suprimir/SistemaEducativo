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
            lblNombreMateriaStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreMateriaStatic.Location = new Point(12, 9);
            lblNombreMateriaStatic.Name = "lblNombreMateriaStatic";
            lblNombreMateriaStatic.Size = new Size(130, 15);
            lblNombreMateriaStatic.TabIndex = 1;
            lblNombreMateriaStatic.Text = "Materias Seleccionadas";
            // 
            // lblCarrerasStatic
            // 
            lblCarrerasStatic.AutoSize = true;
            lblCarrerasStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarrerasStatic.Location = new Point(166, 9);
            lblCarrerasStatic.Name = "lblCarrerasStatic";
            lblCarrerasStatic.Size = new Size(49, 15);
            lblCarrerasStatic.TabIndex = 2;
            lblCarrerasStatic.Text = "Carreras";
            lblCarrerasStatic.Click += lblCarrerasStatic_Click;
            // 
            // comboBoxCarreras
            // 
            comboBoxCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarreras.FlatStyle = FlatStyle.Flat;
            comboBoxCarreras.FormattingEnabled = true;
            comboBoxCarreras.Location = new Point(166, 27);
            comboBoxCarreras.Name = "comboBoxCarreras";
            comboBoxCarreras.Size = new Size(121, 23);
            comboBoxCarreras.TabIndex = 3;
            // 
            // btnAsignarMateria
            // 
            btnAsignarMateria.BackColor = Color.FromArgb(51, 63, 167);
            btnAsignarMateria.FlatAppearance.BorderSize = 0;
            btnAsignarMateria.FlatStyle = FlatStyle.Flat;
            btnAsignarMateria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignarMateria.ForeColor = SystemColors.ControlLightLight;
            btnAsignarMateria.Location = new Point(212, 127);
            btnAsignarMateria.Name = "btnAsignarMateria";
            btnAsignarMateria.Size = new Size(75, 23);
            btnAsignarMateria.TabIndex = 4;
            btnAsignarMateria.Text = "Asignar";
            btnAsignarMateria.UseVisualStyleBackColor = false;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemestreStatic.Location = new Point(166, 64);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(56, 15);
            lblSemestreStatic.TabIndex = 5;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FlatStyle = FlatStyle.Flat;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(166, 82);
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
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(310, 162);
            Controls.Add(lblNombreMateria);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(btnAsignarMateria);
            Controls.Add(comboBoxCarreras);
            Controls.Add(lblCarrerasStatic);
            Controls.Add(lblNombreMateriaStatic);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmAsignarMateria";
            Text = "Asignar Materias";
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