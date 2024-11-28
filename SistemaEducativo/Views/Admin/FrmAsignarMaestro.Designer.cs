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
            comboBoxGrupos = new ComboBox();
            lblMateriasStatic = new Label();
            comboBoxMaterias = new ComboBox();
            comboBoxAlumnos = new ComboBox();
            lblAlumnosStatic = new Label();
            checkBoxGrupo = new CheckBox();
            btnAsignarMaestro = new Button();
            SuspendLayout();
            // 
            // lblGrupoStatic
            // 
            lblGrupoStatic.AutoSize = true;
            lblGrupoStatic.Location = new Point(12, 9);
            lblGrupoStatic.Name = "lblGrupoStatic";
            lblGrupoStatic.Size = new Size(40, 15);
            lblGrupoStatic.TabIndex = 0;
            lblGrupoStatic.Text = "Grupo";
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.FormattingEnabled = true;
            comboBoxGrupos.Location = new Point(12, 27);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(121, 23);
            comboBoxGrupos.TabIndex = 1;
            // 
            // lblMateriasStatic
            // 
            lblMateriasStatic.AutoSize = true;
            lblMateriasStatic.Location = new Point(139, 9);
            lblMateriasStatic.Name = "lblMateriasStatic";
            lblMateriasStatic.Size = new Size(47, 15);
            lblMateriasStatic.TabIndex = 2;
            lblMateriasStatic.Text = "Materia";
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(139, 27);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(121, 23);
            comboBoxMaterias.TabIndex = 3;
            // 
            // comboBoxAlumnos
            // 
            comboBoxAlumnos.FormattingEnabled = true;
            comboBoxAlumnos.Location = new Point(266, 27);
            comboBoxAlumnos.Name = "comboBoxAlumnos";
            comboBoxAlumnos.Size = new Size(266, 23);
            comboBoxAlumnos.TabIndex = 5;
            // 
            // lblAlumnosStatic
            // 
            lblAlumnosStatic.AutoSize = true;
            lblAlumnosStatic.Location = new Point(266, 9);
            lblAlumnosStatic.Name = "lblAlumnosStatic";
            lblAlumnosStatic.Size = new Size(55, 15);
            lblAlumnosStatic.TabIndex = 4;
            lblAlumnosStatic.Text = "Maestros";
            // 
            // checkBoxGrupo
            // 
            checkBoxGrupo.AutoSize = true;
            checkBoxGrupo.Location = new Point(12, 56);
            checkBoxGrupo.Name = "checkBoxGrupo";
            checkBoxGrupo.Size = new Size(64, 19);
            checkBoxGrupo.TabIndex = 6;
            checkBoxGrupo.Text = "Default";
            checkBoxGrupo.UseVisualStyleBackColor = true;
            // 
            // btnAsignarMaestro
            // 
            btnAsignarMaestro.Location = new Point(457, 56);
            btnAsignarMaestro.Name = "btnAsignarMaestro";
            btnAsignarMaestro.Size = new Size(75, 23);
            btnAsignarMaestro.TabIndex = 7;
            btnAsignarMaestro.Text = "Asignar";
            btnAsignarMaestro.UseVisualStyleBackColor = true;
            // 
            // FrmAsignarMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 88);
            Controls.Add(btnAsignarMaestro);
            Controls.Add(checkBoxGrupo);
            Controls.Add(comboBoxAlumnos);
            Controls.Add(lblAlumnosStatic);
            Controls.Add(comboBoxMaterias);
            Controls.Add(lblMateriasStatic);
            Controls.Add(comboBoxGrupos);
            Controls.Add(lblGrupoStatic);
            Name = "FrmAsignarMaestro";
            Text = "FrmAsignarMaestro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupoStatic;
        private ComboBox comboBoxGrupos;
        private Label lblMateriasStatic;
        private ComboBox comboBoxMaterias;
        private ComboBox comboBoxAlumnos;
        private Label lblAlumnosStatic;
        private CheckBox checkBoxGrupo;
        private Button btnAsignarMaestro;
    }
}