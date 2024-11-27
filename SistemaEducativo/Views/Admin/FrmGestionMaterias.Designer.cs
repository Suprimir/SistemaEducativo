namespace SistemaEducativo.Views.Admin
{
    partial class FrmGestionMaterias
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
            dataGridViewMaterias = new DataGridView();
            btnCrearMateria = new Button();
            btnEditarMateria = new Button();
            btnEliminarMateria = new Button();
            textBoxFiltroMateria = new TextBox();
            comboBoxFiltroCarrera = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterias.Location = new Point(16, 42);
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.Size = new Size(435, 219);
            dataGridViewMaterias.TabIndex = 0;
            // 
            // btnCrearMateria
            // 
            btnCrearMateria.Location = new Point(457, 42);
            btnCrearMateria.Name = "btnCrearMateria";
            btnCrearMateria.Size = new Size(127, 38);
            btnCrearMateria.TabIndex = 1;
            btnCrearMateria.Text = "Crear Materia";
            btnCrearMateria.UseVisualStyleBackColor = true;
            // 
            // btnEditarMateria
            // 
            btnEditarMateria.Location = new Point(457, 86);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(127, 38);
            btnEditarMateria.TabIndex = 2;
            btnEditarMateria.Text = "Editar Materia";
            btnEditarMateria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Location = new Point(457, 130);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(127, 38);
            btnEliminarMateria.TabIndex = 3;
            btnEliminarMateria.Text = "Eliminar Materia";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltroMateria
            // 
            textBoxFiltroMateria.Location = new Point(16, 13);
            textBoxFiltroMateria.Name = "textBoxFiltroMateria";
            textBoxFiltroMateria.Size = new Size(308, 23);
            textBoxFiltroMateria.TabIndex = 4;
            // 
            // comboBoxFiltroCarrera
            // 
            comboBoxFiltroCarrera.FormattingEnabled = true;
            comboBoxFiltroCarrera.Location = new Point(330, 13);
            comboBoxFiltroCarrera.Name = "comboBoxFiltroCarrera";
            comboBoxFiltroCarrera.Size = new Size(121, 23);
            comboBoxFiltroCarrera.TabIndex = 5;
            // 
            // FrmGestionMaterias
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(596, 275);
            Controls.Add(comboBoxFiltroCarrera);
            Controls.Add(textBoxFiltroMateria);
            Controls.Add(btnEliminarMateria);
            Controls.Add(btnEditarMateria);
            Controls.Add(btnCrearMateria);
            Controls.Add(dataGridViewMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionMaterias";
            Text = "FrmGestionMaterias";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewMaterias;
        public TextBox textBoxFiltroMateria;
        public ComboBox comboBoxFiltroCarrera;
        public Button btnCrearMateria;
        public Button btnEditarMateria;
        public Button btnEliminarMateria;
    }
}