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
            dataGridViewTareas = new DataGridView();
            btnVerTarea = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(16, 12);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.RowHeadersVisible = false;
            dataGridViewTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTareas.Size = new Size(435, 249);
            dataGridViewTareas.TabIndex = 2;
            // 
            // btnVerTarea
            // 
            btnVerTarea.Location = new Point(457, 12);
            btnVerTarea.Name = "btnVerTarea";
            btnVerTarea.Size = new Size(127, 38);
            btnVerTarea.TabIndex = 3;
            btnVerTarea.Text = "Ver Tarea";
            btnVerTarea.UseVisualStyleBackColor = true;
            // 
            // FrmGestionTareasAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 275);
            Controls.Add(btnVerTarea);
            Controls.Add(dataGridViewTareas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTareasAlumno";
            Text = "FrmGestionTareasAlumno";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridViewTareas;
        public Button btnVerTarea;
    }
}