namespace SistemaEducativo.Views.Maestro
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
            dataGridViewTareas = new DataGridView();
            btnCalificarTarea = new Button();
            lblCalificacionStatic = new Label();
            textBoxCalificacion = new TextBox();
            btnVisualizarTarea = new Button();
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
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(20, 15);
            dataGridViewTareas.Margin = new Padding(4, 4, 4, 4);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.ReadOnly = true;
            dataGridViewTareas.RowHeadersVisible = false;
            dataGridViewTareas.RowHeadersWidth = 51;
            dataGridViewTareas.Size = new Size(544, 311);
            dataGridViewTareas.TabIndex = 0;
            // 
            // btnCalificarTarea
            // 
            btnCalificarTarea.Location = new Point(571, 279);
            btnCalificarTarea.Margin = new Padding(4, 4, 4, 4);
            btnCalificarTarea.Name = "btnCalificarTarea";
            btnCalificarTarea.Size = new Size(159, 48);
            btnCalificarTarea.TabIndex = 1;
            btnCalificarTarea.Text = "Calificar";
            btnCalificarTarea.UseVisualStyleBackColor = true;
            // 
            // lblCalificacionStatic
            // 
            lblCalificacionStatic.AutoSize = true;
            lblCalificacionStatic.Location = new Point(571, 15);
            lblCalificacionStatic.Margin = new Padding(4, 0, 4, 0);
            lblCalificacionStatic.Name = "lblCalificacionStatic";
            lblCalificacionStatic.Size = new Size(86, 20);
            lblCalificacionStatic.TabIndex = 2;
            lblCalificacionStatic.Text = "Calificacion";
            // 
            // textBoxCalificacion
            // 
            textBoxCalificacion.Location = new Point(571, 38);
            textBoxCalificacion.Margin = new Padding(4, 4, 4, 4);
            textBoxCalificacion.Name = "textBoxCalificacion";
            textBoxCalificacion.Size = new Size(158, 27);
            textBoxCalificacion.TabIndex = 5;
            // 
            // btnVisualizarTarea
            // 
            btnVisualizarTarea.Location = new Point(571, 74);
            btnVisualizarTarea.Margin = new Padding(4, 4, 4, 4);
            btnVisualizarTarea.Name = "btnVisualizarTarea";
            btnVisualizarTarea.Size = new Size(159, 48);
            btnVisualizarTarea.TabIndex = 6;
            btnVisualizarTarea.Text = "Visualizar Tarea";
            btnVisualizarTarea.UseVisualStyleBackColor = true;
            // 
            // FrmRevisionTareas
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(745, 344);
            Controls.Add(btnVisualizarTarea);
            Controls.Add(textBoxCalificacion);
            Controls.Add(lblCalificacionStatic);
            Controls.Add(btnCalificarTarea);
            Controls.Add(dataGridViewTareas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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
    }
}