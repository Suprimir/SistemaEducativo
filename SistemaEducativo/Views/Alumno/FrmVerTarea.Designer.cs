namespace SistemaEducativo.Views.Alumno
{
    partial class FrmVerTarea
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
            lblTitulo = new Label();
            btnSubirTarea = new Button();
            btnAdjuntarArchivo = new Button();
            lblNombreArchivo = new Label();
            richTextBoxDescripcion = new RichTextBox();
            openFileDialogTarea = new OpenFileDialog();
            btnCancelarEntrega = new Button();
            btnVerArchivo = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "tituloTarea";
            // 
            // btnSubirTarea
            // 
            btnSubirTarea.Location = new Point(433, 188);
            btnSubirTarea.Name = "btnSubirTarea";
            btnSubirTarea.Size = new Size(151, 41);
            btnSubirTarea.TabIndex = 1;
            btnSubirTarea.Text = "Entregar";
            btnSubirTarea.UseVisualStyleBackColor = true;
            // 
            // btnAdjuntarArchivo
            // 
            btnAdjuntarArchivo.Location = new Point(433, 140);
            btnAdjuntarArchivo.Name = "btnAdjuntarArchivo";
            btnAdjuntarArchivo.Size = new Size(151, 42);
            btnAdjuntarArchivo.TabIndex = 2;
            btnAdjuntarArchivo.Text = "Adjuntar Archivo";
            btnAdjuntarArchivo.UseVisualStyleBackColor = true;
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Location = new Point(433, 122);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(90, 15);
            lblNombreArchivo.TabIndex = 3;
            lblNombreArchivo.Text = "archivoNombre";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.BackColor = Color.FromArgb(228, 220, 201);
            richTextBoxDescripcion.Location = new Point(15, 46);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.ReadOnly = true;
            richTextBoxDescripcion.Size = new Size(399, 217);
            richTextBoxDescripcion.TabIndex = 4;
            richTextBoxDescripcion.Text = "";
            // 
            // openFileDialogTarea
            // 
            openFileDialogTarea.FileName = "openFileDialogTarea";
            // 
            // btnCancelarEntrega
            // 
            btnCancelarEntrega.Location = new Point(433, 235);
            btnCancelarEntrega.Name = "btnCancelarEntrega";
            btnCancelarEntrega.Size = new Size(151, 28);
            btnCancelarEntrega.TabIndex = 5;
            btnCancelarEntrega.Text = "Cancelar Entrega";
            btnCancelarEntrega.UseVisualStyleBackColor = true;
            // 
            // btnVerArchivo
            // 
            btnVerArchivo.Location = new Point(433, 109);
            btnVerArchivo.Name = "btnVerArchivo";
            btnVerArchivo.Size = new Size(151, 25);
            btnVerArchivo.TabIndex = 6;
            btnVerArchivo.Text = "Ver Archivo";
            btnVerArchivo.UseVisualStyleBackColor = true;
            // 
            // FrmVerTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(btnVerArchivo);
            Controls.Add(btnCancelarEntrega);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(lblNombreArchivo);
            Controls.Add(btnAdjuntarArchivo);
            Controls.Add(btnSubirTarea);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerTarea";
            Text = "FrmVerTarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblTitulo;
        public RichTextBox richTextBoxDescripcion;
        public OpenFileDialog openFileDialogTarea;
        public Button btnSubirTarea;
        public Button btnAdjuntarArchivo;
        public Label lblNombreArchivo;
        public Button btnCancelarEntrega;
        public Button btnVerArchivo;
    }
}