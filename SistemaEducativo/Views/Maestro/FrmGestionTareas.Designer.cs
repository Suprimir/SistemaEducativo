namespace SistemaEducativo.Views.Maestro
{
    partial class FrmGestionTareas
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
            btnCrearTarea = new Button();
            btnEditarTarea = new Button();
            btnEliminarTarea = new Button();
            comboBoxFiltroGrupos = new ComboBox();
            dateTimePickerFiltroFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(12, 100);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.Size = new Size(441, 256);
            dataGridViewTareas.TabIndex = 0;
            // 
            // btnCrearTarea
            // 
            btnCrearTarea.Location = new Point(468, 100);
            btnCrearTarea.Name = "btnCrearTarea";
            btnCrearTarea.Size = new Size(140, 51);
            btnCrearTarea.TabIndex = 1;
            btnCrearTarea.Text = "Crear Tarea";
            btnCrearTarea.UseVisualStyleBackColor = true;
            // 
            // btnEditarTarea
            // 
            btnEditarTarea.Location = new Point(468, 157);
            btnEditarTarea.Name = "btnEditarTarea";
            btnEditarTarea.Size = new Size(140, 51);
            btnEditarTarea.TabIndex = 2;
            btnEditarTarea.Text = "Editar Tarea";
            btnEditarTarea.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(468, 214);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(140, 51);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            // 
            // comboBoxFiltroGrupos
            // 
            comboBoxFiltroGrupos.FormattingEnabled = true;
            comboBoxFiltroGrupos.Location = new Point(50, 59);
            comboBoxFiltroGrupos.Name = "comboBoxFiltroGrupos";
            comboBoxFiltroGrupos.Size = new Size(121, 23);
            comboBoxFiltroGrupos.TabIndex = 4;
            // 
            // dateTimePickerFiltroFecha
            // 
            dateTimePickerFiltroFecha.Location = new Point(205, 56);
            dateTimePickerFiltroFecha.Name = "dateTimePickerFiltroFecha";
            dateTimePickerFiltroFecha.Size = new Size(200, 23);
            dateTimePickerFiltroFecha.TabIndex = 5;
            // 
            // FrmGestionTareas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(626, 373);
            Controls.Add(dateTimePickerFiltroFecha);
            Controls.Add(comboBoxFiltroGrupos);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnEditarTarea);
            Controls.Add(btnCrearTarea);
            Controls.Add(dataGridViewTareas);
            Name = "FrmGestionTareas";
            Text = "FrmGestionTareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTareas;
        private Button btnCrearTarea;
        private Button btnEditarTarea;
        private Button btnEliminarTarea;
        private ComboBox comboBoxFiltroGrupos;
        private DateTimePicker dateTimePickerFiltroFecha;
    }
}