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
            lblNombreStatic.Location = new Point(12, 23);
            lblNombreStatic.Name = "lblNombreStatic";
            lblNombreStatic.Size = new Size(97, 15);
            lblNombreStatic.TabIndex = 0;
            lblNombreStatic.Text = "Nombre Materia:";
            // 
            // textBoxNombreMateria
            // 
            textBoxNombreMateria.Location = new Point(115, 20);
            textBoxNombreMateria.MaxLength = 50;
            textBoxNombreMateria.Name = "textBoxNombreMateria";
            textBoxNombreMateria.Size = new Size(144, 23);
            textBoxNombreMateria.TabIndex = 1;
            // 
            // lblDescripcionStatic
            // 
            lblDescripcionStatic.AutoSize = true;
            lblDescripcionStatic.Location = new Point(12, 58);
            lblDescripcionStatic.Name = "lblDescripcionStatic";
            lblDescripcionStatic.Size = new Size(72, 15);
            lblDescripcionStatic.TabIndex = 2;
            lblDescripcionStatic.Text = "Descripcion:";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Location = new Point(12, 85);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(247, 103);
            richTextBoxDescripcion.TabIndex = 3;
            richTextBoxDescripcion.Text = "";
            // 
            // btnRegistrarMateria
            // 
            btnRegistrarMateria.Location = new Point(98, 202);
            btnRegistrarMateria.Name = "btnRegistrarMateria";
            btnRegistrarMateria.Size = new Size(75, 23);
            btnRegistrarMateria.TabIndex = 4;
            btnRegistrarMateria.Text = "Registrar";
            btnRegistrarMateria.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroMateria
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(276, 237);
            Controls.Add(btnRegistrarMateria);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(lblDescripcionStatic);
            Controls.Add(textBoxNombreMateria);
            Controls.Add(lblNombreStatic);
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