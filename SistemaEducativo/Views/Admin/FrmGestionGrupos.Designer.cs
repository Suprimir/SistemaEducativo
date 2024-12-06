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
            textBoxFiltroNombre = new TextBox();
            comboBoxFiltroCarrera = new ComboBox();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearGrupoToolStripMenuItem = new ToolStripMenuItem();
            editarGrupoToolStripMenuItem = new ToolStripMenuItem();
            eliminarGrupoToolStripMenuItem = new ToolStripMenuItem();
            asignarMaestrosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            panelMenuStrip.SuspendLayout();
            menuStripTareasMaestro.SuspendLayout();
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
            dataGridViewGrupos.Location = new Point(16, 78);
            dataGridViewGrupos.MultiSelect = false;
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.Size = new Size(559, 183);
            dataGridViewGrupos.TabIndex = 0;
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
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(16, 42);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(559, 30);
            panelMenuStrip.TabIndex = 13;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearGrupoToolStripMenuItem, editarGrupoToolStripMenuItem, eliminarGrupoToolStripMenuItem, asignarMaestrosToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(559, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearGrupoToolStripMenuItem
            // 
            crearGrupoToolStripMenuItem.Name = "crearGrupoToolStripMenuItem";
            crearGrupoToolStripMenuItem.Size = new Size(83, 26);
            crearGrupoToolStripMenuItem.Text = "Crear Grupo";
            // 
            // editarGrupoToolStripMenuItem
            // 
            editarGrupoToolStripMenuItem.Name = "editarGrupoToolStripMenuItem";
            editarGrupoToolStripMenuItem.Size = new Size(85, 26);
            editarGrupoToolStripMenuItem.Text = "Editar Grupo";
            // 
            // eliminarGrupoToolStripMenuItem
            // 
            eliminarGrupoToolStripMenuItem.Name = "eliminarGrupoToolStripMenuItem";
            eliminarGrupoToolStripMenuItem.Size = new Size(98, 26);
            eliminarGrupoToolStripMenuItem.Text = "Eliminar Grupo";
            // 
            // asignarMaestrosToolStripMenuItem
            // 
            asignarMaestrosToolStripMenuItem.Name = "asignarMaestrosToolStripMenuItem";
            asignarMaestrosToolStripMenuItem.Size = new Size(110, 26);
            asignarMaestrosToolStripMenuItem.Text = "Asignar Maestros";
            // 
            // FrmGestionGrupos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(panelMenuStrip);
            Controls.Add(comboBoxFiltroCarrera);
            Controls.Add(textBoxFiltroNombre);
            Controls.Add(dataGridViewGrupos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionGrupos";
            Text = "Gestionar Grupos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            panelMenuStrip.ResumeLayout(false);
            panelMenuStrip.PerformLayout();
            menuStripTareasMaestro.ResumeLayout(false);
            menuStripTareasMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewGrupos;
        public TextBox textBoxFiltroNombre;
        public ComboBox comboBoxFiltroCarrera;
        private Panel panelMenuStrip;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem crearGrupoToolStripMenuItem;
        public ToolStripMenuItem editarGrupoToolStripMenuItem;
        public ToolStripMenuItem eliminarGrupoToolStripMenuItem;
        public ToolStripMenuItem asignarMaestrosToolStripMenuItem;
    }
}