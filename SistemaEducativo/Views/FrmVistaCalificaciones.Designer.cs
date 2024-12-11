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
            dataGridViewCalificaciones.Columns.AddRange(new DataGridViewColumn[] { nombreMateria, parcial, calificacion });
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
            // FrmVistaCalificaciones
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
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