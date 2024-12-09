namespace SistemaEducativo.Views.Admin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 220, 201);
            dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGrupos.BackgroundColor = Color.FromArgb(251, 225, 141);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGrupos.Location = new Point(20, 98);
            dataGridViewGrupos.Margin = new Padding(4);
            dataGridViewGrupos.MultiSelect = false;
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(251, 225, 141);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewGrupos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(251, 225, 141);
            dataGridViewGrupos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.Size = new Size(699, 229);
            dataGridViewGrupos.TabIndex = 0;
            // 
            // textBoxFiltroNombre
            // 
            textBoxFiltroNombre.Location = new Point(20, 16);
            textBoxFiltroNombre.Margin = new Padding(4);
            textBoxFiltroNombre.Name = "textBoxFiltroNombre";
            textBoxFiltroNombre.Size = new Size(332, 27);
            textBoxFiltroNombre.TabIndex = 6;
            // 
            // comboBoxFiltroCarrera
            // 
            comboBoxFiltroCarrera.FormattingEnabled = true;
            comboBoxFiltroCarrera.Location = new Point(360, 16);
            comboBoxFiltroCarrera.Margin = new Padding(4);
            comboBoxFiltroCarrera.Name = "comboBoxFiltroCarrera";
            comboBoxFiltroCarrera.Size = new Size(203, 28);
            comboBoxFiltroCarrera.TabIndex = 7;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(20, 52);
            panelMenuStrip.Margin = new Padding(4);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(699, 38);
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
            menuStripTareasMaestro.Size = new Size(699, 38);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearGrupoToolStripMenuItem
            // 
            crearGrupoToolStripMenuItem.Name = "crearGrupoToolStripMenuItem";
            crearGrupoToolStripMenuItem.Size = new Size(103, 34);
            crearGrupoToolStripMenuItem.Text = "Crear Grupo";
            // 
            // editarGrupoToolStripMenuItem
            // 
            editarGrupoToolStripMenuItem.Name = "editarGrupoToolStripMenuItem";
            editarGrupoToolStripMenuItem.Size = new Size(107, 34);
            editarGrupoToolStripMenuItem.Text = "Editar Grupo";
            // 
            // eliminarGrupoToolStripMenuItem
            // 
            eliminarGrupoToolStripMenuItem.Name = "eliminarGrupoToolStripMenuItem";
            eliminarGrupoToolStripMenuItem.Size = new Size(122, 34);
            eliminarGrupoToolStripMenuItem.Text = "Eliminar Grupo";
            // 
            // asignarMaestrosToolStripMenuItem
            // 
            asignarMaestrosToolStripMenuItem.Name = "asignarMaestrosToolStripMenuItem";
            asignarMaestrosToolStripMenuItem.Size = new Size(137, 34);
            asignarMaestrosToolStripMenuItem.Text = "Asignar Maestros";
            // 
            // FrmGestionGrupos
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(745, 344);
            Controls.Add(panelMenuStrip);
            Controls.Add(comboBoxFiltroCarrera);
            Controls.Add(textBoxFiltroNombre);
            Controls.Add(dataGridViewGrupos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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