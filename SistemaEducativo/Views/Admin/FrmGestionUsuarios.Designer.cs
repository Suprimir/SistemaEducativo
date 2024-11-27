namespace SistemaEducativo.Views.Maestro
{
    partial class FrmGestionUsuarios
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
            dataGridViewUsuarios = new DataGridView();
            textBoxFiltroUsuarios = new TextBox();
            comboBoxFiltroRol = new ComboBox();
            btnCrearUsuario = new Button();
            btnEditarUsuario = new Button();
            btnEliminarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(16, 42);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.Size = new Size(435, 219);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // textBoxFiltroUsuarios
            // 
            textBoxFiltroUsuarios.Location = new Point(16, 15);
            textBoxFiltroUsuarios.Name = "textBoxFiltroUsuarios";
            textBoxFiltroUsuarios.Size = new Size(308, 23);
            textBoxFiltroUsuarios.TabIndex = 1;
            // 
            // comboBoxFiltroRol
            // 
            comboBoxFiltroRol.FormattingEnabled = true;
            comboBoxFiltroRol.Location = new Point(330, 15);
            comboBoxFiltroRol.Name = "comboBoxFiltroRol";
            comboBoxFiltroRol.Size = new Size(121, 23);
            comboBoxFiltroRol.TabIndex = 2;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(457, 42);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(127, 38);
            btnCrearUsuario.TabIndex = 3;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(457, 86);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(127, 38);
            btnEditarUsuario.TabIndex = 4;
            btnEditarUsuario.Text = "Editar Usuario";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(457, 130);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(127, 38);
            btnEliminarUsuario.TabIndex = 5;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(596, 275);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnCrearUsuario);
            Controls.Add(comboBoxFiltroRol);
            Controls.Add(textBoxFiltroUsuarios);
            Controls.Add(dataGridViewUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios";
            Text = "Gestionar Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewUsuarios;
        public TextBox textBoxFiltroUsuarios;
        public Button btnCrearUsuario;
        public Button btnEditarUsuario;
        public Button btnEliminarUsuario;
        public ComboBox comboBoxFiltroRol;
    }
}