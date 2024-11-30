namespace SistemaEducativo.Views.Maestro
{
    partial class FrmRegistroTarea
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
            lblTituloStatic = new Label();
            textBoxTitulo = new TextBox();
            lblDescripcionStatic = new Label();
            richTextBoxDescripcion = new RichTextBox();
            lblFechaLimiteStatic = new Label();
            dateTimePickerFechaLimite = new DateTimePicker();
            btnRegistrarTarea = new Button();
            lblParcialesStatic = new Label();
            comboBoxParciales = new ComboBox();
            SuspendLayout();
            // 
            // lblTituloStatic
            // 
            lblTituloStatic.AutoSize = true;
            lblTituloStatic.Location = new Point(12, 72);
            lblTituloStatic.Name = "lblTituloStatic";
            lblTituloStatic.Size = new Size(38, 15);
            lblTituloStatic.TabIndex = 0;
            lblTituloStatic.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(56, 69);
            textBoxTitulo.MaxLength = 100;
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(311, 23);
            textBoxTitulo.TabIndex = 1;
            // 
            // lblDescripcionStatic
            // 
            lblDescripcionStatic.AutoSize = true;
            lblDescripcionStatic.Location = new Point(12, 114);
            lblDescripcionStatic.Name = "lblDescripcionStatic";
            lblDescripcionStatic.Size = new Size(69, 15);
            lblDescripcionStatic.TabIndex = 2;
            lblDescripcionStatic.Text = "Descripcion";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.Location = new Point(12, 132);
            richTextBoxDescripcion.MaxLength = 500;
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.Size = new Size(355, 96);
            richTextBoxDescripcion.TabIndex = 3;
            richTextBoxDescripcion.Text = "";
            // 
            // lblFechaLimiteStatic
            // 
            lblFechaLimiteStatic.AutoSize = true;
            lblFechaLimiteStatic.Location = new Point(11, 284);
            lblFechaLimiteStatic.Name = "lblFechaLimiteStatic";
            lblFechaLimiteStatic.Size = new Size(74, 15);
            lblFechaLimiteStatic.TabIndex = 4;
            lblFechaLimiteStatic.Text = "Fecha Limite";
            // 
            // dateTimePickerFechaLimite
            // 
            dateTimePickerFechaLimite.Location = new Point(91, 278);
            dateTimePickerFechaLimite.Name = "dateTimePickerFechaLimite";
            dateTimePickerFechaLimite.Size = new Size(200, 23);
            dateTimePickerFechaLimite.TabIndex = 5;
            // 
            // btnRegistrarTarea
            // 
            btnRegistrarTarea.Location = new Point(309, 276);
            btnRegistrarTarea.Name = "btnRegistrarTarea";
            btnRegistrarTarea.Size = new Size(75, 23);
            btnRegistrarTarea.TabIndex = 6;
            btnRegistrarTarea.Text = "Guardar";
            btnRegistrarTarea.UseVisualStyleBackColor = true;
            // 
            // lblParcialesStatic
            // 
            lblParcialesStatic.AutoSize = true;
            lblParcialesStatic.Location = new Point(12, 24);
            lblParcialesStatic.Name = "lblParcialesStatic";
            lblParcialesStatic.Size = new Size(53, 15);
            lblParcialesStatic.TabIndex = 7;
            lblParcialesStatic.Text = "Parciales";
            // 
            // comboBoxParciales
            // 
            comboBoxParciales.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParciales.FormattingEnabled = true;
            comboBoxParciales.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxParciales.Location = new Point(71, 21);
            comboBoxParciales.Name = "comboBoxParciales";
            comboBoxParciales.Size = new Size(121, 23);
            comboBoxParciales.TabIndex = 8;
            // 
            // FrmRegistroTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 323);
            Controls.Add(comboBoxParciales);
            Controls.Add(lblParcialesStatic);
            Controls.Add(btnRegistrarTarea);
            Controls.Add(dateTimePickerFechaLimite);
            Controls.Add(lblFechaLimiteStatic);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(lblDescripcionStatic);
            Controls.Add(textBoxTitulo);
            Controls.Add(lblTituloStatic);
            Name = "FrmRegistroTarea";
            Text = "FrmRegistroTarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloStatic;
        public TextBox textBoxTitulo;
        private Label lblDescripcionStatic;
        public RichTextBox richTextBoxDescripcion;
        private Label lblFechaLimiteStatic;
        public DateTimePicker dateTimePickerFechaLimite;
        public Button btnRegistrarTarea;
        private Label lblParcialesStatic;
        public ComboBox comboBoxParciales;
    }
}