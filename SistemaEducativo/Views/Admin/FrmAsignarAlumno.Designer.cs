namespace SistemaEducativo.Views.Admin
{
    partial class FrmAsignarAlumno
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
            comboBoxGrupos = new ComboBox();
            lblGrupoStatic = new Label();
            lblAlumnosStatic = new Label();
            comboBoxAlumnos = new ComboBox();
            btnAsignarAlumno = new Button();
            checkBoxGrupo = new CheckBox();
            SuspendLayout();
            // 
            // comboBoxGrupos
            // 
            comboBoxGrupos.FormattingEnabled = true;
            comboBoxGrupos.Location = new Point(12, 27);
            comboBoxGrupos.Name = "comboBoxGrupos";
            comboBoxGrupos.Size = new Size(121, 23);
            comboBoxGrupos.TabIndex = 0;
            // 
            // lblGrupoStatic
            // 
            lblGrupoStatic.AutoSize = true;
            lblGrupoStatic.Location = new Point(12, 9);
            lblGrupoStatic.Name = "lblGrupoStatic";
            lblGrupoStatic.Size = new Size(40, 15);
            lblGrupoStatic.TabIndex = 1;
            lblGrupoStatic.Text = "Grupo";
            // 
            // lblAlumnosStatic
            // 
            lblAlumnosStatic.AutoSize = true;
            lblAlumnosStatic.Location = new Point(139, 9);
            lblAlumnosStatic.Name = "lblAlumnosStatic";
            lblAlumnosStatic.Size = new Size(55, 15);
            lblAlumnosStatic.TabIndex = 2;
            lblAlumnosStatic.Text = "Alumnos";
            // 
            // comboBoxAlumnos
            // 
            comboBoxAlumnos.FormattingEnabled = true;
            comboBoxAlumnos.Location = new Point(139, 27);
            comboBoxAlumnos.Name = "comboBoxAlumnos";
            comboBoxAlumnos.Size = new Size(266, 23);
            comboBoxAlumnos.TabIndex = 3;
            // 
            // btnAsignarAlumno
            // 
            btnAsignarAlumno.Location = new Point(330, 56);
            btnAsignarAlumno.Name = "btnAsignarAlumno";
            btnAsignarAlumno.Size = new Size(75, 23);
            btnAsignarAlumno.TabIndex = 4;
            btnAsignarAlumno.Text = "Asignar";
            btnAsignarAlumno.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrupo
            // 
            checkBoxGrupo.AutoSize = true;
            checkBoxGrupo.Location = new Point(12, 56);
            checkBoxGrupo.Name = "checkBoxGrupo";
            checkBoxGrupo.Size = new Size(64, 19);
            checkBoxGrupo.TabIndex = 5;
            checkBoxGrupo.Text = "Default";
            checkBoxGrupo.UseVisualStyleBackColor = true;
            // 
            // FrmAsignarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 86);
            Controls.Add(checkBoxGrupo);
            Controls.Add(btnAsignarAlumno);
            Controls.Add(comboBoxAlumnos);
            Controls.Add(lblAlumnosStatic);
            Controls.Add(lblGrupoStatic);
            Controls.Add(comboBoxGrupos);
            Name = "FrmAsignarAlumno";
            Text = "FrmAsignarAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGrupos;
        private Label lblGrupoStatic;
        private Label lblAlumnosStatic;
        private ComboBox comboBoxAlumnos;
        private Button btnAsignarAlumno;
        private CheckBox checkBoxGrupo;
    }
}