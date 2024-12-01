namespace SistemaEducativo.Views.Admin
{
    partial class FrmAsignarMaestro
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
            lblGrupoStatic = new Label();
            lblMateriasStatic = new Label();
            comboBoxMaterias = new ComboBox();
            comboBoxAlumnos = new ComboBox();
            lblAlumnosStatic = new Label();
            btnAsignarMaestro = new Button();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            lblCarreraStatic = new Label();
            lblCarrera = new Label();
            lblGrupo = new Label();
            SuspendLayout();
            // 
            // lblGrupoStatic
            // 
            lblGrupoStatic.AutoSize = true;
            lblGrupoStatic.Location = new Point(12, 20);
            lblGrupoStatic.Name = "lblGrupoStatic";
            lblGrupoStatic.Size = new Size(40, 15);
            lblGrupoStatic.TabIndex = 0;
            lblGrupoStatic.Text = "Grupo";
            // 
            // lblMateriasStatic
            // 
            lblMateriasStatic.AutoSize = true;
            lblMateriasStatic.Location = new Point(265, 20);
            lblMateriasStatic.Name = "lblMateriasStatic";
            lblMateriasStatic.Size = new Size(47, 15);
            lblMateriasStatic.TabIndex = 2;
            lblMateriasStatic.Text = "Materia";
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(265, 38);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(121, 23);
            comboBoxMaterias.TabIndex = 3;
            // 
            // comboBoxAlumnos
            // 
            comboBoxAlumnos.FormattingEnabled = true;
            comboBoxAlumnos.Location = new Point(265, 115);
            comboBoxAlumnos.Name = "comboBoxAlumnos";
            comboBoxAlumnos.Size = new Size(266, 23);
            comboBoxAlumnos.TabIndex = 5;
            // 
            // lblAlumnosStatic
            // 
            lblAlumnosStatic.AutoSize = true;
            lblAlumnosStatic.Location = new Point(265, 97);
            lblAlumnosStatic.Name = "lblAlumnosStatic";
            lblAlumnosStatic.Size = new Size(55, 15);
            lblAlumnosStatic.TabIndex = 4;
            lblAlumnosStatic.Text = "Maestros";
            // 
            // btnAsignarMaestro
            // 
            btnAsignarMaestro.Location = new Point(457, 144);
            btnAsignarMaestro.Name = "btnAsignarMaestro";
            btnAsignarMaestro.Size = new Size(75, 23);
            btnAsignarMaestro.TabIndex = 7;
            btnAsignarMaestro.Text = "Asignar";
            btnAsignarMaestro.UseVisualStyleBackColor = true;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Location = new Point(12, 97);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(55, 15);
            lblSemestreStatic.TabIndex = 8;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(12, 115);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 9;
            // 
            // lblCarreraStatic
            // 
            lblCarreraStatic.AutoSize = true;
            lblCarreraStatic.Location = new Point(149, 20);
            lblCarreraStatic.Name = "lblCarreraStatic";
            lblCarreraStatic.Size = new Size(45, 15);
            lblCarreraStatic.TabIndex = 10;
            lblCarreraStatic.Text = "Carrera";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(149, 46);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(87, 15);
            lblCarrera.TabIndex = 11;
            lblCarrera.Text = "nombreCarrera";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(14, 46);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(82, 15);
            lblGrupo.TabIndex = 12;
            lblGrupo.Text = "nombreGrupo";
            // 
            // FrmAsignarMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 179);
            Controls.Add(lblGrupo);
            Controls.Add(lblCarrera);
            Controls.Add(lblCarreraStatic);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(btnAsignarMaestro);
            Controls.Add(comboBoxAlumnos);
            Controls.Add(lblAlumnosStatic);
            Controls.Add(comboBoxMaterias);
            Controls.Add(lblMateriasStatic);
            Controls.Add(lblGrupoStatic);
            Name = "FrmAsignarMaestro";
            Text = "FrmAsignarMaestro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupoStatic;
        private Label lblMateriasStatic;
        private Label lblAlumnosStatic;
        private Label lblSemestreStatic;
        public ComboBox comboBoxSemestres;
        private Label lblCarreraStatic;
        public Label lblGrupo;
        public Label lblCarrera;
        public ComboBox comboBoxMaterias;
        public ComboBox comboBoxAlumnos;
        public Button btnAsignarMaestro;
    }
}