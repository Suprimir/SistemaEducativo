namespace SistemaEducativo.Views.Alumno
{
    partial class FrmVistaCalificaciones
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
            dataGridViewCalificaciones = new DataGridView();
            nombreMateria = new DataGridViewTextBoxColumn();
            parcial = new DataGridViewTextBoxColumn();
            calificacion = new DataGridViewTextBoxColumn();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCalificaciones
            // 
            dataGridViewCalificaciones.AllowUserToAddRows = false;
            dataGridViewCalificaciones.AllowUserToDeleteRows = false;
            dataGridViewCalificaciones.AllowUserToResizeColumns = false;
            dataGridViewCalificaciones.AllowUserToResizeRows = false;
            dataGridViewCalificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalificaciones.Columns.AddRange(new DataGridViewColumn[] { nombreMateria, parcial, calificacion });
            dataGridViewCalificaciones.Location = new Point(16, 44);
            dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            dataGridViewCalificaciones.ReadOnly = true;
            dataGridViewCalificaciones.RowHeadersVisible = false;
            dataGridViewCalificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCalificaciones.Size = new Size(559, 217);
            dataGridViewCalificaciones.TabIndex = 0;
            // 
            // nombreMateria
            // 
            nombreMateria.HeaderText = "Materia";
            nombreMateria.Name = "nombreMateria";
            nombreMateria.ReadOnly = true;
            // 
            // parcial
            // 
            parcial.HeaderText = "Parcial";
            parcial.Name = "parcial";
            parcial.ReadOnly = true;
            // 
            // calificacion
            // 
            calificacion.HeaderText = "Calificacion";
            calificacion.Name = "calificacion";
            calificacion.ReadOnly = true;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Location = new Point(16, 15);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(55, 15);
            lblSemestreStatic.TabIndex = 1;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(77, 12);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 2;
            // 
            // FrmVistaCalificaciones
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(dataGridViewCalificaciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVistaCalificaciones";
            Text = "FrmVistaCalificacionesAlumno";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn nombreMateria;
        private DataGridViewTextBoxColumn parcial;
        private DataGridViewTextBoxColumn calificacion;
        public DataGridView dataGridViewCalificaciones;
        public ComboBox comboBoxSemestres;
        public Label lblSemestreStatic;
    }
}