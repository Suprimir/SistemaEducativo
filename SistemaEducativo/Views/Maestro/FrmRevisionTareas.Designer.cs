﻿namespace SistemaEducativo.Views.Maestro
{
    partial class FrmRevisionTareas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewTareas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            fechaEntregada = new DataGridViewTextBoxColumn();
            calificacion = new DataGridViewTextBoxColumn();
            btnCalificarTarea = new Button();
            lblCalificacionStatic = new Label();
            textBoxCalificacion = new TextBox();
            btnVisualizarTarea = new Button();
            textBoxFiltroNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.AllowUserToAddRows = false;
            dataGridViewTareas.AllowUserToDeleteRows = false;
            dataGridViewTareas.AllowUserToResizeColumns = false;
            dataGridViewTareas.AllowUserToResizeRows = false;
            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.BackgroundColor = Color.FromArgb(221, 223, 244);
            dataGridViewTareas.BorderStyle = BorderStyle.None;
            dataGridViewTareas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewTareas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Columns.AddRange(new DataGridViewColumn[] { id, nombre, estado, fechaEntregada, calificacion });
            dataGridViewTareas.EnableHeadersVisualStyles = false;
            dataGridViewTareas.GridColor = Color.FromArgb(221, 223, 244);
            dataGridViewTareas.Location = new Point(0, 33);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.ReadOnly = true;
            dataGridViewTareas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTareas.RowHeadersVisible = false;
            dataGridViewTareas.RowHeadersWidth = 51;
            dataGridViewTareas.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(221, 223, 244);
            dataGridViewTareas.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewTareas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 254, 255);
            dataGridViewTareas.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            dataGridViewTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTareas.Size = new Size(451, 242);
            dataGridViewTareas.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // estado
            // 
            estado.FillWeight = 70F;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // fechaEntregada
            // 
            fechaEntregada.FillWeight = 90F;
            fechaEntregada.HeaderText = "Fecha Entrega";
            fechaEntregada.Name = "fechaEntregada";
            fechaEntregada.ReadOnly = true;
            // 
            // calificacion
            // 
            calificacion.FillWeight = 60F;
            calificacion.HeaderText = "Calificación";
            calificacion.Name = "calificacion";
            calificacion.ReadOnly = true;
            // 
            // btnCalificarTarea
            // 
            btnCalificarTarea.BackColor = Color.FromArgb(51, 63, 167);
            btnCalificarTarea.FlatAppearance.BorderSize = 0;
            btnCalificarTarea.FlatStyle = FlatStyle.Flat;
            btnCalificarTarea.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalificarTarea.ForeColor = SystemColors.Window;
            btnCalificarTarea.Location = new Point(457, 225);
            btnCalificarTarea.Name = "btnCalificarTarea";
            btnCalificarTarea.Size = new Size(127, 38);
            btnCalificarTarea.TabIndex = 1;
            btnCalificarTarea.Text = "Calificar";
            btnCalificarTarea.UseVisualStyleBackColor = false;
            // 
            // lblCalificacionStatic
            // 
            lblCalificacionStatic.AutoSize = true;
            lblCalificacionStatic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalificacionStatic.Location = new Point(457, 33);
            lblCalificacionStatic.Name = "lblCalificacionStatic";
            lblCalificacionStatic.Size = new Size(68, 15);
            lblCalificacionStatic.TabIndex = 2;
            lblCalificacionStatic.Text = "Calificacion";
            // 
            // textBoxCalificacion
            // 
            textBoxCalificacion.BorderStyle = BorderStyle.None;
            textBoxCalificacion.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCalificacion.Location = new Point(457, 51);
            textBoxCalificacion.MaxLength = 2;
            textBoxCalificacion.Name = "textBoxCalificacion";
            textBoxCalificacion.Size = new Size(127, 23);
            textBoxCalificacion.TabIndex = 5;
            // 
            // btnVisualizarTarea
            // 
            btnVisualizarTarea.BackColor = Color.FromArgb(254, 254, 255);
            btnVisualizarTarea.FlatAppearance.BorderSize = 0;
            btnVisualizarTarea.FlatStyle = FlatStyle.Flat;
            btnVisualizarTarea.Location = new Point(457, 80);
            btnVisualizarTarea.Name = "btnVisualizarTarea";
            btnVisualizarTarea.Size = new Size(127, 38);
            btnVisualizarTarea.TabIndex = 6;
            btnVisualizarTarea.Text = "Visualizar Tarea";
            btnVisualizarTarea.UseVisualStyleBackColor = false;
            // 
            // textBoxFiltroNombre
            // 
            textBoxFiltroNombre.BorderStyle = BorderStyle.None;
            textBoxFiltroNombre.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFiltroNombre.Location = new Point(0, 4);
            textBoxFiltroNombre.Name = "textBoxFiltroNombre";
            textBoxFiltroNombre.PlaceholderText = "Nombre del Alumno";
            textBoxFiltroNombre.Size = new Size(451, 23);
            textBoxFiltroNombre.TabIndex = 7;
            // 
            // FrmRevisionTareas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(592, 275);
            Controls.Add(textBoxFiltroNombre);
            Controls.Add(btnVisualizarTarea);
            Controls.Add(textBoxCalificacion);
            Controls.Add(lblCalificacionStatic);
            Controls.Add(btnCalificarTarea);
            Controls.Add(dataGridViewTareas);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRevisionTareas";
            Text = "Revision Tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCalificacionStatic;
        private Button button2;
        public DataGridView dataGridViewTareas;
        public Button btnCalificarTarea;
        public Button btnVisualizarTarea;
        public TextBox textBoxCalificacion;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn fechaEntregada;
        private DataGridViewTextBoxColumn calificacion;
        public TextBox textBoxFiltroNombre;
    }
}