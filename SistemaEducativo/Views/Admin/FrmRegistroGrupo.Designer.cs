namespace SistemaEducativo.Views.Admin
{
    partial class FrmRegistroGrupo
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
            labelCarreraStatic = new Label();
            labelNombreGStatic = new Label();
            lblFechaStatic = new Label();
            comboBoxCarreras = new ComboBox();
            textBoxNombreG = new TextBox();
            dateTimePickerFechaInicio = new DateTimePicker();
            btnRegistrarGrupo = new Button();
            lblSemestreStatic = new Label();
            comboBoxSemestres = new ComboBox();
            SuspendLayout();
            // 
            // labelCarreraStatic
            // 
            labelCarreraStatic.AutoSize = true;
            labelCarreraStatic.Location = new Point(27, 30);
            labelCarreraStatic.Name = "labelCarreraStatic";
            labelCarreraStatic.Size = new Size(45, 15);
            labelCarreraStatic.TabIndex = 0;
            labelCarreraStatic.Text = "Carrera";
            // 
            // labelNombreGStatic
            // 
            labelNombreGStatic.AutoSize = true;
            labelNombreGStatic.Location = new Point(27, 64);
            labelNombreGStatic.Name = "labelNombreGStatic";
            labelNombreGStatic.Size = new Size(100, 15);
            labelNombreGStatic.TabIndex = 1;
            labelNombreGStatic.Text = "Nom. Generacion";
            // 
            // lblFechaStatic
            // 
            lblFechaStatic.AutoSize = true;
            lblFechaStatic.Location = new Point(27, 105);
            lblFechaStatic.Name = "lblFechaStatic";
            lblFechaStatic.Size = new Size(70, 15);
            lblFechaStatic.TabIndex = 3;
            lblFechaStatic.Text = "Fecha Inicio";
            // 
            // comboBoxCarreras
            // 
            comboBoxCarreras.FormattingEnabled = true;
            comboBoxCarreras.Location = new Point(164, 22);
            comboBoxCarreras.Name = "comboBoxCarreras";
            comboBoxCarreras.Size = new Size(121, 23);
            comboBoxCarreras.TabIndex = 4;
            // 
            // textBoxNombreG
            // 
            textBoxNombreG.Location = new Point(164, 61);
            textBoxNombreG.MaxLength = 50;
            textBoxNombreG.Name = "textBoxNombreG";
            textBoxNombreG.Size = new Size(121, 23);
            textBoxNombreG.TabIndex = 5;
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Location = new Point(164, 97);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(191, 23);
            dateTimePickerFechaInicio.TabIndex = 6;
            // 
            // btnRegistrarGrupo
            // 
            btnRegistrarGrupo.Location = new Point(138, 172);
            btnRegistrarGrupo.Name = "btnRegistrarGrupo";
            btnRegistrarGrupo.Size = new Size(75, 23);
            btnRegistrarGrupo.TabIndex = 7;
            btnRegistrarGrupo.Text = "Registrar";
            btnRegistrarGrupo.UseVisualStyleBackColor = true;
            // 
            // lblSemestreStatic
            // 
            lblSemestreStatic.AutoSize = true;
            lblSemestreStatic.Location = new Point(27, 138);
            lblSemestreStatic.Name = "lblSemestreStatic";
            lblSemestreStatic.Size = new Size(55, 15);
            lblSemestreStatic.TabIndex = 8;
            lblSemestreStatic.Text = "Semestre";
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Location = new Point(164, 135);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(121, 23);
            comboBoxSemestres.TabIndex = 9;
            // 
            // FrmRegistroGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 218);
            Controls.Add(comboBoxSemestres);
            Controls.Add(lblSemestreStatic);
            Controls.Add(btnRegistrarGrupo);
            Controls.Add(dateTimePickerFechaInicio);
            Controls.Add(textBoxNombreG);
            Controls.Add(comboBoxCarreras);
            Controls.Add(lblFechaStatic);
            Controls.Add(labelNombreGStatic);
            Controls.Add(labelCarreraStatic);
            Name = "FrmRegistroGrupo";
            Text = "FrmRegistroGrupo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarreraStatic;
        private Label labelNombreGStatic;
        private Label lblFechaStatic;
        public ComboBox comboBoxCarreras;
        public TextBox textBoxNombreG;
        public DateTimePicker dateTimePickerFechaInicio;
        public Button btnRegistrarGrupo;
        private TextBox textBox1;
        private Label lblSemestreStatic;
        public ComboBox comboBoxSemestres;
    }
}