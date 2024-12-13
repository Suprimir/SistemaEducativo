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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCalificaciones = new DataGridView();
            semestre = new DataGridViewTextBoxColumn();
            nombreMateria = new DataGridViewTextBoxColumn();
            parcial = new DataGridViewTextBoxColumn();
            calificacion = new DataGridViewTextBoxColumn();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            checkBoxSemestral = new CheckBox();
            checkBoxFinales = new CheckBox();
            btnRegresarForm = new Button();
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
            dataGridViewCalificaciones.BackgroundColor = Color.FromArgb(221, 223, 244);
            dataGridViewCalificaciones.BorderStyle = BorderStyle.None;
            dataGridViewCalificaciones.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCalificaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalificaciones.Columns.AddRange(new DataGridViewColumn[] { semestre, nombreMateria, parcial, calificacion });
            dataGridViewCalificaciones.EnableHeadersVisualStyles = false;
            dataGridViewCalificaciones.GridColor = Color.FromArgb(221, 223, 244);
            dataGridViewCalificaciones.Location = new Point(0, 35);
            dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            dataGridViewCalificaciones.ReadOnly = true;
            dataGridViewCalificaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCalificaciones.RowHeadersVisible = false;
            dataGridViewCalificaciones.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(221, 223, 244);
            dataGridViewCalificaciones.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewCalificaciones.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 254, 255);
            dataGridViewCalificaciones.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCalificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCalificaciones.Size = new Size(597, 240);
            dataGridViewCalificaciones.TabIndex = 0;
            // 
            // semestre
            // 
            semestre.HeaderText = "Semestre";
            semestre.Name = "semestre";
            semestre.ReadOnly = true;
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
            lblSemestreStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemestreStatic.Location = new Point(0, 9);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(56, 15);
            lblSemestreStatic.TabIndex = 1;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FlatStyle = FlatStyle.Flat;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(61, 6);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 2;
            // 
            // checkBoxSemestral
            // 
            checkBoxSemestral.AutoSize = true;
            checkBoxSemestral.Location = new Point(404, 8);
            checkBoxSemestral.Name = "checkBoxSemestral";
            checkBoxSemestral.Size = new Size(77, 19);
            checkBoxSemestral.TabIndex = 3;
            checkBoxSemestral.Text = "Semestral";
            checkBoxSemestral.UseVisualStyleBackColor = true;
            // 
            // checkBoxFinales
            // 
            checkBoxFinales.AutoSize = true;
            checkBoxFinales.Location = new Point(487, 8);
            checkBoxFinales.Name = "checkBoxFinales";
            checkBoxFinales.Size = new Size(62, 19);
            checkBoxFinales.TabIndex = 4;
            checkBoxFinales.Text = "Finales";
            checkBoxFinales.UseVisualStyleBackColor = true;
            // 
            // btnRegresarForm
            // 
            btnRegresarForm.FlatAppearance.BorderSize = 0;
            btnRegresarForm.FlatStyle = FlatStyle.Flat;
            btnRegresarForm.Image = Properties.Resources.regresarIcon;
            btnRegresarForm.Location = new Point(566, 5);
            btnRegresarForm.Name = "btnRegresarForm";
            btnRegresarForm.Size = new Size(23, 23);
            btnRegresarForm.TabIndex = 5;
            btnRegresarForm.UseVisualStyleBackColor = true;
            // 
            // FrmVistaCalificaciones
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(596, 275);
            Controls.Add(btnRegresarForm);
            Controls.Add(checkBoxFinales);
            Controls.Add(checkBoxSemestral);
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
        public DataGridView dataGridViewCalificaciones;
        public ComboBox comboBoxSemestres;
        public Label lblSemestreStatic;
        public CheckBox checkBoxSemestral;
        public CheckBox checkBoxFinales;
        private DataGridViewTextBoxColumn semestre;
        private DataGridViewTextBoxColumn nombreMateria;
        private DataGridViewTextBoxColumn parcial;
        private DataGridViewTextBoxColumn calificacion;
        public Button btnRegresarForm;
    }
}