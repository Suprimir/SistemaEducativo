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
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanelTareas
            // 
            flowLayoutPanelTareas.AutoScroll = true;
            flowLayoutPanelTareas.Location = new Point(0, 32);
            flowLayoutPanelTareas.Margin = new Padding(0);
            flowLayoutPanelTareas.Name = "flowLayoutPanelTareas";
            flowLayoutPanelTareas.Size = new Size(681, 335);
            flowLayoutPanelTareas.TabIndex = 10;
            // 
            // comboBoxSemestres
            // 
            comboBoxSemestres.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemestres.FlatStyle = FlatStyle.Flat;
            comboBoxSemestres.FormattingEnabled = true;
            comboBoxSemestres.Items.AddRange(new object[] { "" });
            comboBoxSemestres.Location = new Point(77, 0);
            comboBoxSemestres.Margin = new Padding(4);
            comboBoxSemestres.Name = "comboBoxSemestres";
            comboBoxSemestres.Size = new Size(183, 28);
            comboBoxSemestres.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 12;
            label1.Text = "Semestre";
            // 
            // FrmGestionTareasAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(681, 367);
            Controls.Add(label1);
            Controls.Add(comboBoxSemestres);
            Controls.Add(flowLayoutPanelTareas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGestionTareasAlumno";
            Text = "FrmGestionTareasAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public FlowLayoutPanel flowLayoutPanelTareas;
        public ComboBox comboBoxSemestres;
        private Label label1;
    }
}