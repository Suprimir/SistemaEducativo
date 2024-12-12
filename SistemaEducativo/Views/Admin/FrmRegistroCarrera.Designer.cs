namespace SistemaEducativo.Views.Admin
{
    partial class FrmRegistroCarrera
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
            lblNombreCarrera = new Label();
            textBoxNombreCarrera = new TextBox();
            richTextBoxDescripcion = new RichTextBox();
            lblDescripcion = new Label();
            lblTotalSemestres = new Label();
            numericUpDownTotalSemestres = new NumericUpDown();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalSemestres).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCarrera
            // 
            lblNombreCarrera.AutoSize = true;
            lblNombreCarrera.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCarrera.Location = new Point(12, 9);
            lblNombreCarrera.Name = "lblNombreCarrera";
            lblNombreCarrera.Size = new Size(91, 15);
            lblNombreCarrera.TabIndex = 0;
            lblNombreCarrera.Text = "Nombre Carrera";
            // 
            // textBoxNombreCarrera
            // 
            textBoxNombreCarrera.BorderStyle = BorderStyle.None;
            textBoxNombreCarrera.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreCarrera.Location = new Point(12, 27);
            textBoxNombreCarrera.Name = "textBoxNombreCarrera";
            textBoxNombreCarrera.Size = new Size(338, 23);
            textBoxNombreCarrera.TabIndex = 1;
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.BorderStyle = BorderStyle.None;
            richTextBoxDescripcion.Location = new Point(12, 86);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(224, 127);
            richTextBoxDescripcion.TabIndex = 2;
            richTextBoxDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(12, 68);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(70, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // lblTotalSemestres
            // 
            lblTotalSemestres.AutoSize = true;
            lblTotalSemestres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSemestres.Location = new Point(260, 68);
            lblTotalSemestres.Name = "lblTotalSemestres";
            lblTotalSemestres.Size = new Size(90, 15);
            lblTotalSemestres.TabIndex = 4;
            lblTotalSemestres.Text = "Total Semestres";
            // 
            // numericUpDownTotalSemestres
            // 
            numericUpDownTotalSemestres.BorderStyle = BorderStyle.None;
            numericUpDownTotalSemestres.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownTotalSemestres.Location = new Point(260, 87);
            numericUpDownTotalSemestres.Name = "numericUpDownTotalSemestres";
            numericUpDownTotalSemestres.Size = new Size(93, 21);
            numericUpDownTotalSemestres.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(51, 63, 167);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(260, 190);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(90, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // FrmRegistroCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(365, 230);
            Controls.Add(btnRegistrar);
            Controls.Add(numericUpDownTotalSemestres);
            Controls.Add(lblTotalSemestres);
            Controls.Add(lblDescripcion);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(textBoxNombreCarrera);
            Controls.Add(lblNombreCarrera);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmRegistroCarrera";
            Text = "Registrar Carrera";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalSemestres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCarrera;
        private Label lblDescripcion;
        private Label lblTotalSemestres;
        private NumericUpDown numericUpDown1;
        public TextBox textBoxNombreCarrera;
        public RichTextBox richTextBoxDescripcion;
        public NumericUpDown numericUpDownTotalSemestres;
        public Button btnRegistrar;
    }
}