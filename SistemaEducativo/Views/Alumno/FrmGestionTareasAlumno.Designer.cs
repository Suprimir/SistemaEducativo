namespace SistemaEducativo.Views.Alumno
{
    partial class FrmGestionTareasAlumno
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
            flowLayoutPanelTareas = new FlowLayoutPanel();
            comboBoxSemestres = new ComboBox();
            lblSemestre = new Label();
            lblMateria = new Label();
            comboBoxMaterias = new ComboBox();
            SuspendLayout();
            // 
            // flowLayoutPanelTareas
            // 
            flowLayoutPanelTareas.AutoScroll = true;
            flowLayoutPanelTareas.Location = new Point(0, 24);
            flowLayoutPanelTareas.Margin = new Padding(0);
            flowLayoutPanelTareas.Name = "flowLayoutPanelTareas";
            flowLayoutPanelTareas.Size = new Size(596, 251);
            flowLayoutPanelTareas.TabIndex = 10;
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FlatStyle = FlatStyle.Flat;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Items.AddRange(new object[] { "" });
            comboBoxSemestres.Location = new Point(67, 0);
            comboBoxSemestres.Margin = new Padding(4, 3, 4, 3);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(71, 23);
            comboBoxSemestres.TabIndex = 11;
            // 
            // lblSemestre
            // 
            lblSemestre.AutoSize = true;
            lblSemestre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemestre.Location = new Point(0, 3);
            lblSemestre.Name = "lblSemestre";
            lblSemestre.Size = new Size(56, 15);
            lblSemestre.TabIndex = 12;
            lblSemestre.Text = "Semestre";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(145, 3);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 13;
            lblMateria.Text = "Materia";
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaterias.FlatStyle = FlatStyle.Flat;
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Items.AddRange(new object[] { "" });
            comboBoxMaterias.Location = new Point(199, 0);
            comboBoxMaterias.Margin = new Padding(4, 3, 4, 3);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(148, 23);
            comboBoxMaterias.TabIndex = 14;
            // 
            // FrmGestionTareasAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(596, 275);
            Controls.Add(comboBoxMaterias);
            Controls.Add(lblMateria);
            Controls.Add(lblSemestre);
            Controls.Add(comboBoxSemestres);
            Controls.Add(flowLayoutPanelTareas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTareasAlumno";
            Text = "FrmGestionTareasAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public FlowLayoutPanel flowLayoutPanelTareas;
        public ComboBox comboBoxSemestres;
        private Label lblSemestre;
        private Label lblMateria;
        public ComboBox comboBoxMaterias;
    }
}