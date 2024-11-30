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
            btnAsignarCarrera = new Button();
            btnDesasignarCarrera = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.AllowUserToAddRows = false;
            dataGridViewMaterias.AllowUserToDeleteRows = false;
            dataGridViewMaterias.AllowUserToResizeColumns = false;
            dataGridViewMaterias.AllowUserToResizeRows = false;
            dataGridViewMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterias.Location = new Point(16, 42);
            dataGridViewMaterias.MultiSelect = false;
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.ReadOnly = true;
            dataGridViewMaterias.RowHeadersVisible = false;
            dataGridViewMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            comboBoxFiltroCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroCarrera.FormattingEnabled = true;
            comboBoxFiltroCarrera.Items.AddRange(new object[] { "" });
            comboBoxFiltroCarrera.Location = new Point(330, 13);
            comboBoxFiltroCarrera.Name = "comboBoxFiltroCarrera";
            comboBoxFiltroCarrera.Size = new Size(121, 23);
            comboBoxFiltroCarrera.TabIndex = 5;
            // 
            // btnAsignarCarrera
            // 
            btnAsignarCarrera.Location = new Point(457, 174);
            btnAsignarCarrera.Name = "btnAsignarCarrera";
            btnAsignarCarrera.Size = new Size(127, 38);
            btnAsignarCarrera.TabIndex = 6;
            btnAsignarCarrera.Text = "Asignar Materia a Carrera\n\n";
            btnAsignarCarrera.UseVisualStyleBackColor = true;
            // 
            // btnDesasignarCarrera
            // 
            btnDesasignarCarrera.Location = new Point(457, 218);
            btnDesasignarCarrera.Name = "btnDesasignarCarrera";
            btnDesasignarCarrera.Size = new Size(127, 38);
            btnDesasignarCarrera.TabIndex = 7;
            btnDesasignarCarrera.Text = "Desasignar Materia de Carrera\n\n";
            btnDesasignarCarrera.UseVisualStyleBackColor = true;
            // 
            // FrmGestionMaterias
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(596, 275);
            Controls.Add(btnDesasignarCarrera);
            Controls.Add(btnAsignarCarrera);
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
        public Button btnAsignarCarrera;
        public Button btnDesasignarCarrera;
    }
}