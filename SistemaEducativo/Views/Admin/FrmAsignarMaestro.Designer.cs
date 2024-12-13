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
            lblAlumnosStatic = new Label();
            btnAsignarMaestro = new Button();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            lblCarreraStatic = new Label();
            lblCarrera = new Label();
            lblGrupo = new Label();
            comboBoxMaestros = new ComboBox();
            SuspendLayout();
            // 
            // lblGrupoStatic
            // 
            lblGrupoStatic.AutoSize = true;
            lblGrupoStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrupoStatic.Location = new Point(12, 9);
            lblGrupoStatic.Name = "lblGrupoStatic";
            lblGrupoStatic.Size = new Size(40, 15);
            lblGrupoStatic.TabIndex = 0;
            lblGrupoStatic.Text = "Grupo";
            // 
            // lblMateriasStatic
            // 
            lblMateriasStatic.AutoSize = true;
            lblMateriasStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMateriasStatic.Location = new Point(146, 62);
            lblMateriasStatic.Name = "lblMateriasStatic";
            lblMateriasStatic.Size = new Size(47, 15);
            lblMateriasStatic.TabIndex = 2;
            lblMateriasStatic.Text = "Materia";
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterias.FlatStyle = FlatStyle.Flat;
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(146, 78);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(121, 23);
            comboBoxMaterias.TabIndex = 3;
            // 
            // lblAlumnosStatic
            // 
            lblAlumnosStatic.AutoSize = true;
            lblAlumnosStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumnosStatic.Location = new Point(12, 111);
            lblAlumnosStatic.Name = "lblAlumnosStatic";
            lblAlumnosStatic.Size = new Size(55, 15);
            lblAlumnosStatic.TabIndex = 4;
            lblAlumnosStatic.Text = "Maestros";
            // 
            // btnAsignarMaestro
            // 
            btnAsignarMaestro.BackColor = Color.FromArgb(51, 63, 167);
            btnAsignarMaestro.FlatAppearance.BorderSize = 0;
            btnAsignarMaestro.FlatStyle = FlatStyle.Flat;
            btnAsignarMaestro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignarMaestro.ForeColor = SystemColors.ControlLightLight;
            btnAsignarMaestro.Location = new Point(286, 130);
            btnAsignarMaestro.Name = "btnAsignarMaestro";
            btnAsignarMaestro.Size = new Size(75, 23);
            btnAsignarMaestro.TabIndex = 7;
            btnAsignarMaestro.Text = "Asignar";
            btnAsignarMaestro.UseVisualStyleBackColor = false;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemestreStatic.Location = new Point(146, 8);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(56, 15);
            lblSemestreStatic.TabIndex = 8;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FlatStyle = FlatStyle.Flat;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(146, 26);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 9;
            // 
            // lblCarreraStatic
            // 
            lblCarreraStatic.AutoSize = true;
            lblCarreraStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarreraStatic.Location = new Point(12, 66);
            lblCarreraStatic.Name = "lblCarreraStatic";
            lblCarreraStatic.Size = new Size(44, 15);
            lblCarreraStatic.TabIndex = 10;
            lblCarreraStatic.Text = "Carrera";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(12, 81);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(87, 15);
            lblCarrera.TabIndex = 11;
            lblCarrera.Text = "nombreCarrera";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 24);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(82, 15);
            lblGrupo.TabIndex = 12;
            lblGrupo.Text = "nombreGrupo";
            // 
            // comboBoxMaestros
            // 
            comboBoxMaestros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaestros.FlatStyle = FlatStyle.Flat;
            comboBoxMaestros.FormattingEnabled = true;
            comboBoxMaestros.Location = new Point(12, 130);
            comboBoxMaestros.Name = "comboBoxMaestros";
            comboBoxMaestros.Size = new Size(255, 23);
            comboBoxMaestros.TabIndex = 13;
            // 
            // FrmAsignarMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(373, 165);
            Controls.Add(comboBoxMaestros);
            Controls.Add(lblGrupo);
            Controls.Add(lblCarrera);
            Controls.Add(lblCarreraStatic);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(btnAsignarMaestro);
            Controls.Add(lblAlumnosStatic);
            Controls.Add(comboBoxMaterias);
            Controls.Add(lblMateriasStatic);
            Controls.Add(lblGrupoStatic);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmAsignarMaestro";
            Text = "Asignar Maestro";
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
        public Button btnAsignarMaestro;
        public ComboBox comboBoxMaestros;
    }
}