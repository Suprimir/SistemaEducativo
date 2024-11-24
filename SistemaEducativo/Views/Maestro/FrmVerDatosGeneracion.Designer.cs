namespace SistemaEducativo.Views.Maestro
{
    partial class FrmVerDatosGeneracion
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
            dataGridViewAlumnos = new DataGridView();
            comboBoxSemestres = new ComboBox();
            comboBoxParciales = new ComboBox();
            lblSemestreStatic = new Label();
            lblParcialStatic = new Label();
            comboBoxMaterias = new ComboBox();
            lblMateriaStatic = new Label();
            btnVerCalificaciones = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.AllowUserToAddRows = false;
            dataGridViewAlumnos.AllowUserToDeleteRows = false;
            dataGridViewAlumnos.AllowUserToResizeColumns = false;
            dataGridViewAlumnos.AllowUserToResizeRows = false;
            dataGridViewAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Location = new Point(30, 121);
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RowHeadersVisible = false;
            dataGridViewAlumnos.Size = new Size(539, 306);
            dataGridViewAlumnos.TabIndex = 0;
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(30, 72);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 1;
            // 
            // comboBoxParciales
            // 
            comboBoxParciales.FormattingEnabled = true;
            comboBoxParciales.Location = new Point(190, 72);
            comboBoxParciales.Name = "comboBoxParciales";
            comboBoxParciales.Size = new Size(121, 23);
            comboBoxParciales.TabIndex = 2;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Location = new Point(30, 54);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(55, 15);
            lblSemestreStatic.TabIndex = 3;
            lblSemestreStatic.Text = "Semestre";
            // 
            // lblParcialStatic
            // 
            lblParcialStatic.AutoSize = true;
            lblParcialStatic.Location = new Point(190, 54);
            lblParcialStatic.Name = "lblParcialStatic";
            lblParcialStatic.Size = new Size(42, 15);
            lblParcialStatic.TabIndex = 4;
            lblParcialStatic.Text = "Parcial";
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(360, 72);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(121, 23);
            comboBoxMaterias.TabIndex = 5;
            // 
            // lblMateriaStatic
            // 
            lblMateriaStatic.AutoSize = true;
            lblMateriaStatic.Location = new Point(360, 54);
            lblMateriaStatic.Name = "lblMateriaStatic";
            lblMateriaStatic.Size = new Size(47, 15);
            lblMateriaStatic.TabIndex = 6;
            lblMateriaStatic.Text = "Materia";
            // 
            // btnVerCalificaciones
            // 
            btnVerCalificaciones.Location = new Point(503, 54);
            btnVerCalificaciones.Name = "btnVerCalificaciones";
            btnVerCalificaciones.Size = new Size(118, 43);
            btnVerCalificaciones.TabIndex = 7;
            btnVerCalificaciones.Text = "Ver Calificaciones";
            btnVerCalificaciones.UseVisualStyleBackColor = true;
            // 
            // FrmVerDatosGeneracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerCalificaciones);
            Controls.Add(lblMateriaStatic);
            Controls.Add(comboBoxMaterias);
            Controls.Add(lblParcialStatic);
            Controls.Add(lblSemestreStatic);
            Controls.Add(comboBoxParciales);
            Controls.Add(comboBoxSemestres);
            Controls.Add(dataGridViewAlumnos);
            Name = "FrmVerDatosGeneracion";
            Text = "FrmVerDatosGeneracion";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSemestreStatic;
        private Label lblParcialStatic;
        public DataGridView dataGridViewAlumnos;
        public ComboBox comboBoxSemestres;
        public ComboBox comboBoxParciales;
        public ComboBox comboBoxMaterias;
        private Label lblMateriaStatic;
        public Button btnVerCalificaciones;
    }
}