namespace SistemaEducativo.Views.Maestro
{
    partial class FrmGestionGrupos
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
            dataGridViewGrupos = new DataGridView();
            btnCrearGrupo = new Button();
            btnEditarGrupo = new Button();
            btnEliminarGrupo = new Button();
            btnAsignarMaestro = new Button();
            textBoxFiltroNombre = new TextBox();
            comboBoxFiltroCarrera = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.AllowUserToAddRows = false;
            dataGridViewGrupos.AllowUserToDeleteRows = false;
            dataGridViewGrupos.AllowUserToResizeColumns = false;
            dataGridViewGrupos.AllowUserToResizeRows = false;
            dataGridViewGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Location = new Point(16, 42);
            dataGridViewGrupos.MultiSelect = false;
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.Size = new Size(435, 219);
            dataGridViewGrupos.TabIndex = 0;
            // 
            // btnCrearGrupo
            // 
            btnCrearGrupo.Location = new Point(457, 42);
            btnCrearGrupo.Name = "btnCrearGrupo";
            btnCrearGrupo.Size = new Size(127, 38);
            btnCrearGrupo.TabIndex = 1;
            btnCrearGrupo.Text = "Crear Grupo";
            btnCrearGrupo.UseVisualStyleBackColor = true;
            // 
            // btnEditarGrupo
            // 
            btnEditarGrupo.Location = new Point(457, 86);
            btnEditarGrupo.Name = "btnEditarGrupo";
            btnEditarGrupo.Size = new Size(127, 38);
            btnEditarGrupo.TabIndex = 2;
            btnEditarGrupo.Text = "Editar Grupo";
            btnEditarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarGrupo
            // 
            btnEliminarGrupo.Location = new Point(457, 130);
            btnEliminarGrupo.Name = "btnEliminarGrupo";
            btnEliminarGrupo.Size = new Size(127, 38);
            btnEliminarGrupo.TabIndex = 3;
            btnEliminarGrupo.Text = "Eliminar Grupo";
            btnEliminarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnAsignarMaestro
            // 
            btnAsignarMaestro.Location = new Point(457, 174);
            btnAsignarMaestro.Name = "btnAsignarMaestro";
            btnAsignarMaestro.Size = new Size(127, 38);
            btnAsignarMaestro.TabIndex = 5;
            btnAsignarMaestro.Text = "Asignar Maestros";
            btnAsignarMaestro.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltroNombre
            // 
            textBoxFiltroNombre.Location = new Point(16, 13);
            textBoxFiltroNombre.Name = "textBoxFiltroNombre";
            textBoxFiltroNombre.Size = new Size(266, 23);
            textBoxFiltroNombre.TabIndex = 6;
            // 
            // comboBoxFiltroCarrera
            // 
            comboBoxFiltroCarrera.FormattingEnabled = true;
            comboBoxFiltroCarrera.Location = new Point(288, 13);
            comboBoxFiltroCarrera.Name = "comboBoxFiltroCarrera";
            comboBoxFiltroCarrera.Size = new Size(163, 23);
            comboBoxFiltroCarrera.TabIndex = 7;
            // 
            // FrmGestionGrupos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(596, 275);
            Controls.Add(comboBoxFiltroCarrera);
            Controls.Add(textBoxFiltroNombre);
            Controls.Add(btnAsignarMaestro);
            Controls.Add(btnEliminarGrupo);
            Controls.Add(btnEditarGrupo);
            Controls.Add(btnCrearGrupo);
            Controls.Add(dataGridViewGrupos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionGrupos";
            Text = "Gestionar Grupos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewGrupos;
        public TextBox textBoxFiltroNombre;
        public ComboBox comboBoxFiltroCarrera;
        public Button btnCrearGrupo;
        public Button btnEditarGrupo;
        public Button btnEliminarGrupo;
        public Button btnAsignarMaestro;
    }
}