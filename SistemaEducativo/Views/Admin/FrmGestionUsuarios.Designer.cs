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
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            editarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            verCalificacionesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            panelMenuStrip.SuspendLayout();
            menuStripTareasMaestro.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.AllowUserToResizeColumns = false;
            dataGridViewUsuarios.AllowUserToResizeRows = false;
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(16, 78);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(561, 183);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // textBoxFiltroUsuarios
            // 
            textBoxFiltroUsuarios.Location = new Point(16, 15);
            textBoxFiltroUsuarios.Name = "textBoxFiltroUsuarios";
            textBoxFiltroUsuarios.Size = new Size(434, 23);
            textBoxFiltroUsuarios.TabIndex = 1;
            // 
            // comboBoxFiltroRol
            // 
            comboBoxFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroRol.FormattingEnabled = true;
            comboBoxFiltroRol.Items.AddRange(new object[] { "", "alumno", "maestro", "admin" });
            comboBoxFiltroRol.Location = new Point(456, 15);
            comboBoxFiltroRol.Name = "comboBoxFiltroRol";
            comboBoxFiltroRol.Size = new Size(121, 23);
            comboBoxFiltroRol.TabIndex = 2;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(16, 42);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(561, 30);
            panelMenuStrip.TabIndex = 11;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem, editarUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, verCalificacionesToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(561, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(90, 26);
            crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // editarUsuarioToolStripMenuItem
            // 
            editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            editarUsuarioToolStripMenuItem.Size = new Size(92, 26);
            editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(105, 26);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // verCalificacionesToolStripMenuItem
            // 
            verCalificacionesToolStripMenuItem.Name = "verCalificacionesToolStripMenuItem";
            verCalificacionesToolStripMenuItem.Size = new Size(111, 26);
            verCalificacionesToolStripMenuItem.Text = "Ver Calificaciones";
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(panelMenuStrip);
            Controls.Add(comboBoxFiltroRol);
            Controls.Add(textBoxFiltroUsuarios);
            Controls.Add(dataGridViewUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionUsuarios";
            Text = "Gestionar Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            panelMenuStrip.ResumeLayout(false);
            panelMenuStrip.PerformLayout();
            menuStripTareasMaestro.ResumeLayout(false);
            menuStripTareasMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewUsuarios;
        public TextBox textBoxFiltroUsuarios;
        public ComboBox comboBoxFiltroRol;
        private Panel panelMenuStrip;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem crearUsuarioToolStripMenuItem;
        public ToolStripMenuItem editarUsuarioToolStripMenuItem;
        public ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        public ToolStripMenuItem verCalificacionesToolStripMenuItem;
    }
}