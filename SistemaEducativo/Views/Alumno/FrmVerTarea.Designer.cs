﻿namespace SistemaEducativo.Views.Alumno
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
            lblCalificacionStatic = new Label();
            lblEstadoStatic = new Label();
            lblEstado = new Label();
            lblCalificacion = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(14, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(131, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "tituloTarea";
            // 
            // btnSubirTarea
            // 
            btnSubirTarea.BackColor = Color.FromArgb(51, 63, 167);
            btnSubirTarea.FlatAppearance.BorderSize = 0;
            btnSubirTarea.FlatStyle = FlatStyle.Flat;
            btnSubirTarea.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirTarea.ForeColor = Color.White;
            btnSubirTarea.Location = new Point(495, 251);
            btnSubirTarea.Margin = new Padding(3, 4, 3, 4);
            btnSubirTarea.Name = "btnSubirTarea";
            btnSubirTarea.Size = new Size(173, 55);
            btnSubirTarea.TabIndex = 1;
            btnSubirTarea.Text = "Entregar";
            btnSubirTarea.UseVisualStyleBackColor = false;
            // 
            // btnAdjuntarArchivo
            // 
            btnAdjuntarArchivo.BackColor = Color.White;
            btnAdjuntarArchivo.FlatAppearance.BorderSize = 0;
            btnAdjuntarArchivo.FlatStyle = FlatStyle.Flat;
            btnAdjuntarArchivo.ForeColor = SystemColors.ControlText;
            btnAdjuntarArchivo.Location = new Point(495, 187);
            btnAdjuntarArchivo.Margin = new Padding(3, 4, 3, 4);
            btnAdjuntarArchivo.Name = "btnAdjuntarArchivo";
            btnAdjuntarArchivo.Size = new Size(173, 56);
            btnAdjuntarArchivo.TabIndex = 2;
            btnAdjuntarArchivo.Text = "Adjuntar Archivo";
            btnAdjuntarArchivo.UseVisualStyleBackColor = false;
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Location = new Point(495, 163);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(112, 20);
            lblNombreArchivo.TabIndex = 3;
            lblNombreArchivo.Text = "archivoNombre";
            // 
            // richTextBoxDescripcion
            // 
            richTextBoxDescripcion.BackColor = Color.FromArgb(254, 254, 255);
            richTextBoxDescripcion.BorderStyle = BorderStyle.None;
            richTextBoxDescripcion.Location = new Point(17, 61);
            richTextBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            richTextBoxDescripcion.ReadOnly = true;
            richTextBoxDescripcion.Size = new Size(456, 289);
            richTextBoxDescripcion.TabIndex = 4;
            richTextBoxDescripcion.Text = "";
            // 
            // openFileDialogTarea
            // 
            openFileDialogTarea.FileName = "openFileDialogTarea";
            // 
            // btnCancelarEntrega
            // 
            btnCancelarEntrega.BackColor = Color.LightCoral;
            btnCancelarEntrega.FlatAppearance.BorderSize = 0;
            btnCancelarEntrega.FlatStyle = FlatStyle.Flat;
            btnCancelarEntrega.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarEntrega.ForeColor = Color.White;
            btnCancelarEntrega.Location = new Point(495, 313);
            btnCancelarEntrega.Margin = new Padding(3, 4, 3, 4);
            btnCancelarEntrega.Name = "btnCancelarEntrega";
            btnCancelarEntrega.Size = new Size(173, 37);
            btnCancelarEntrega.TabIndex = 5;
            btnCancelarEntrega.Text = "Cancelar Entrega";
            btnCancelarEntrega.UseVisualStyleBackColor = false;
            // 
            // btnVerArchivo
            // 
            btnVerArchivo.BackColor = Color.White;
            btnVerArchivo.FlatAppearance.BorderSize = 0;
            btnVerArchivo.FlatStyle = FlatStyle.Flat;
            btnVerArchivo.ForeColor = SystemColors.ControlText;
            btnVerArchivo.Location = new Point(495, 145);
            btnVerArchivo.Margin = new Padding(3, 4, 3, 4);
            btnVerArchivo.Name = "btnVerArchivo";
            btnVerArchivo.Size = new Size(173, 33);
            btnVerArchivo.TabIndex = 6;
            btnVerArchivo.Text = "Ver Archivo";
            btnVerArchivo.UseVisualStyleBackColor = false;
            // 
            // lblCalificacionStatic
            // 
            lblCalificacionStatic.AutoSize = true;
            lblCalificacionStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalificacionStatic.Location = new Point(495, 88);
            lblCalificacionStatic.Name = "lblCalificacionStatic";
            lblCalificacionStatic.Size = new Size(91, 20);
            lblCalificacionStatic.TabIndex = 7;
            lblCalificacionStatic.Text = "Calificación:";
            lblCalificacionStatic.Visible = false;
            // 
            // lblEstadoStatic
            // 
            lblEstadoStatic.AutoSize = true;
            lblEstadoStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoStatic.Location = new Point(495, 61);
            lblEstadoStatic.Name = "lblEstadoStatic";
            lblEstadoStatic.Size = new Size(58, 20);
            lblEstadoStatic.TabIndex = 8;
            lblEstadoStatic.Text = "Estado:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(591, 61);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(74, 20);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Pendiente";
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Location = new Point(592, 88);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(0, 20);
            lblCalificacion.TabIndex = 10;
            // 
            // FrmVerTarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(681, 367);
            Controls.Add(lblCalificacion);
            Controls.Add(lblEstado);
            Controls.Add(lblEstadoStatic);
            Controls.Add(lblCalificacionStatic);
            Controls.Add(btnVerArchivo);
            Controls.Add(btnCancelarEntrega);
            Controls.Add(richTextBoxDescripcion);
            Controls.Add(lblNombreArchivo);
            Controls.Add(btnAdjuntarArchivo);
            Controls.Add(btnSubirTarea);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmVerTarea";
            Text = "     ";
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
        private Label lblEstadoStatic;
        public Label lblCalificacionStatic;
        public Label lblEstado;
        public Label lblCalificacion;
    }
}