namespace SistemaEducativo.Views.Admin
{
    partial class FrmRegistroMateria
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
            lblNombreStatic = new Label();
            textBoxNombreMateria = new TextBox();
            lblDescripcionStatic = new Label();
            richTextBoxDescripcion = new RichTextBox();
            btnRegistrarMateria = new Button();
            SuspendLayout();
            // 
            // lblNombreStatic
            // 
            lblNombreStatic.AutoSize = true;
            lblNombreStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreStatic.Location = new Point(12, 9);
            lblNombreStatic.Name = "lblNombreStatic";
            lblNombreStatic.Size = new Size(94, 15);
            lblNombreStatic.TabIndex = 0;
            lblNombreStatic.Text = "Nombre Materia";
            // 
            // textBoxNombreMateria
            // 
            textBoxNombreMateria.BorderStyle = BorderStyle.None;
            textBoxNombreMateria.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreMateria.Location = new Point(12, 27);
            textBoxNombreMateria.MaxLength = 50;
            textBoxNombreMateria.Name = "textBoxNombreMateria";
            textBoxNombreMateria.Size = new Size(304, 23);
            textBoxNombreMateria.TabIndex = 1;
            // 
            // lblDescripcionStatic
            // 
            lblDescripcionStatic.AutoSize = true;
            lblDescripcionStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcionStatic.Location = new Point(12, 66);
            lblDescripcionStatic.Name = "lblDescripcionStatic";
            lblDescripcionStatic.Size = new Size(70, 15);
            lblDescripcionStatic.TabIndex = 2;
            lblDescripcionStatic.Text = "Descripcion";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.BorderStyle = BorderStyle.None;
            richTextBoxDescripcion.Location = new Point(12, 84);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(304, 103);
            richTextBoxDescripcion.TabIndex = 3;
            richTextBoxDescripcion.Text = "";
            // 
            // btnRegistrarMateria
            // 
            btnRegistrarMateria.BackColor = Color.FromArgb(51, 63, 167);
            btnRegistrarMateria.FlatAppearance.BorderSize = 0;
            btnRegistrarMateria.FlatStyle = FlatStyle.Flat;
            btnRegistrarMateria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarMateria.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarMateria.Location = new Point(241, 210);
            btnRegistrarMateria.Name = "btnRegistrarMateria";
            btnRegistrarMateria.Size = new Size(75, 23);
            btnRegistrarMateria.TabIndex = 4;
            btnRegistrarMateria.Text = "Registrar";
            btnRegistrarMateria.UseVisualStyleBackColor = false;
            // 
            // FrmRegistroMateria
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(328, 245);
            Controls.Add(btnRegistrarMateria);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(lblDescripcionStatic);
            Controls.Add(textBoxNombreMateria);
            Controls.Add(lblNombreStatic);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmRegistroMateria";
            Text = "Registrar Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreStatic;
        private Label lblDescripcionStatic;
        private RichTextBox richTextBox1;
        public TextBox textBoxNombreMateria;
        public RichTextBox richTextBoxDescripcion;
        public Button btnRegistrarMateria;
    }
}