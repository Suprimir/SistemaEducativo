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
            comboBoxFiltroParciales = new ComboBox();
            btnRevisarTareas = new Button();
            lblTareas = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(16, 42);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.RowHeadersVisible = false;
            dataGridViewTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTareas.Size = new Size(435, 219);
            dataGridViewTareas.TabIndex = 0;
            // 
            // btnCrearTarea
            // 
            btnCrearTarea.Location = new Point(457, 42);
            btnCrearTarea.Name = "btnCrearTarea";
            btnCrearTarea.Size = new Size(127, 38);
            btnCrearTarea.TabIndex = 1;
            btnCrearTarea.Text = "Crear Tarea";
            btnCrearTarea.UseVisualStyleBackColor = true;
            // 
            // btnEditarTarea
            // 
            btnEditarTarea.Location = new Point(457, 86);
            btnEditarTarea.Name = "btnEditarTarea";
            btnEditarTarea.Size = new Size(127, 38);
            btnEditarTarea.TabIndex = 2;
            btnEditarTarea.Text = "Editar Tarea";
            btnEditarTarea.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(457, 130);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(127, 38);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            // 
            // comboBoxFiltroParciales
            // 
            comboBoxFiltroParciales.FormattingEnabled = true;
            comboBoxFiltroParciales.Location = new Point(64, 12);
            comboBoxFiltroParciales.Name = "comboBoxFiltroParciales";
            comboBoxFiltroParciales.Size = new Size(121, 23);
            comboBoxFiltroParciales.TabIndex = 4;
            // 
            // btnRevisarTareas
            // 
            btnRevisarTareas.Location = new Point(457, 174);
            btnRevisarTareas.Name = "btnRevisarTareas";
            btnRevisarTareas.Size = new Size(127, 38);
            btnRevisarTareas.TabIndex = 6;
            btnRevisarTareas.Text = "Revisar Tareas";
            btnRevisarTareas.UseVisualStyleBackColor = true;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Location = new Point(16, 15);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(42, 15);
            lblTareas.TabIndex = 7;
            lblTareas.Text = "Parcial";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 8;
            // 
            // FrmGestionTareas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(596, 275);
            Controls.Add(textBox1);
            Controls.Add(lblTareas);
            Controls.Add(btnRevisarTareas);
            Controls.Add(comboBoxFiltroParciales);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnEditarTarea);
            Controls.Add(btnCrearTarea);
            Controls.Add(dataGridViewTareas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTareas";
            Text = "FrmGestionTareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEliminarTarea;
        private ComboBox comboBoxFiltroParciales;
        private Button btnRevisarTareas;
        public DataGridView dataGridViewTareas;
        private Label lblTareas;
        private TextBox textBox1;
        public Button btnCrearTarea;
        public Button btnEditarTarea;
    }
}