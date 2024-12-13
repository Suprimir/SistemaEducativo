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
            SuspendLayout();
            // 
            // labelCarreraStatic
            // 
            labelCarreraStatic.AutoSize = true;
            labelCarreraStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarreraStatic.Location = new Point(12, 9);
            labelCarreraStatic.Name = "labelCarreraStatic";
            labelCarreraStatic.Size = new Size(44, 15);
            labelCarreraStatic.TabIndex = 0;
            labelCarreraStatic.Text = "Carrera";
            // 
            // labelNombreGStatic
            // 
            labelNombreGStatic.AutoSize = true;
            labelNombreGStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreGStatic.Location = new Point(12, 64);
            labelNombreGStatic.Name = "labelNombreGStatic";
            labelNombreGStatic.Size = new Size(114, 15);
            labelNombreGStatic.TabIndex = 1;
            labelNombreGStatic.Text = "Nombre Generacion";
            // 
            // lblFechaStatic
            // 
            lblFechaStatic.AutoSize = true;
            lblFechaStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaStatic.Location = new Point(12, 122);
            lblFechaStatic.Name = "lblFechaStatic";
            lblFechaStatic.Size = new Size(71, 15);
            lblFechaStatic.TabIndex = 3;
            lblFechaStatic.Text = "Fecha Inicio";
            // 
            // comboBoxCarreras
            // 
            comboBoxCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarreras.FlatStyle = FlatStyle.Flat;
            comboBoxCarreras.FormattingEnabled = true;
            comboBoxCarreras.Location = new Point(12, 27);
            comboBoxCarreras.Name = "comboBoxCarreras";
            comboBoxCarreras.Size = new Size(194, 23);
            comboBoxCarreras.TabIndex = 4;
            // 
            // textBoxNombreG
            // 
            textBoxNombreG.BorderStyle = BorderStyle.None;
            textBoxNombreG.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreG.Location = new Point(12, 82);
            textBoxNombreG.MaxLength = 50;
            textBoxNombreG.Name = "textBoxNombreG";
            textBoxNombreG.Size = new Size(194, 23);
            textBoxNombreG.TabIndex = 5;
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Location = new Point(12, 140);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(194, 23);
            dateTimePickerFechaInicio.TabIndex = 6;
            // 
            // btnRegistrarGrupo
            // 
            btnRegistrarGrupo.BackColor = Color.FromArgb(51, 63, 167);
            btnRegistrarGrupo.FlatAppearance.BorderSize = 0;
            btnRegistrarGrupo.FlatStyle = FlatStyle.Flat;
            btnRegistrarGrupo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarGrupo.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarGrupo.Location = new Point(225, 140);
            btnRegistrarGrupo.Name = "btnRegistrarGrupo";
            btnRegistrarGrupo.Size = new Size(87, 23);
            btnRegistrarGrupo.TabIndex = 7;
            btnRegistrarGrupo.Text = "Registrar";
            btnRegistrarGrupo.UseVisualStyleBackColor = false;
            // 
            // FrmRegistroGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(335, 177);
            Controls.Add(btnRegistrarGrupo);
            Controls.Add(dateTimePickerFechaInicio);
            Controls.Add(textBoxNombreG);
            Controls.Add(comboBoxCarreras);
            Controls.Add(lblFechaStatic);
            Controls.Add(labelNombreGStatic);
            Controls.Add(labelCarreraStatic);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmRegistroGrupo";
            Text = "Registrar Grupo";
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
    }
}