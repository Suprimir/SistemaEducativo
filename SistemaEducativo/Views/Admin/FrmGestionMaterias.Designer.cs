﻿namespace SistemaEducativo.Views.Admin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewMaterias = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombreMateria = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            semestre = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewCheckBoxColumn();
            textBoxFiltroMateria = new TextBox();
            comboBoxFiltroCarrera = new ComboBox();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearMateriaToolStripMenuItem = new ToolStripMenuItem();
            eliminarMateriaToolStripMenuItem = new ToolStripMenuItem();
            asignarMateriaToolStripMenuItem = new ToolStripMenuItem();
            desasignarMateriaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            panelMenuStrip.SuspendLayout();
            menuStripTareasMaestro.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.AllowUserToAddRows = false;
            dataGridViewMaterias.AllowUserToDeleteRows = false;
            dataGridViewMaterias.AllowUserToResizeColumns = false;
            dataGridViewMaterias.AllowUserToResizeRows = false;
            dataGridViewMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterias.BackgroundColor = Color.FromArgb(251, 225, 141);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterias.Columns.AddRange(new DataGridViewColumn[] { id, nombreMateria, descripcion, semestre, editar, eliminar });
            dataGridViewMaterias.EnableHeadersVisualStyles = false;
            dataGridViewMaterias.GridColor = Color.FromArgb(251, 225, 141);
            dataGridViewMaterias.Location = new Point(0, 69);
            dataGridViewMaterias.MultiSelect = false;
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.RowHeadersVisible = false;
            dataGridViewMaterias.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(251, 225, 141);
            dataGridViewMaterias.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewMaterias.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(228, 220, 201);
            dataGridViewMaterias.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            dataGridViewMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaterias.Size = new Size(597, 206);
            dataGridViewMaterias.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // nombreMateria
            // 
            nombreMateria.FillWeight = 50F;
            nombreMateria.HeaderText = "Materia";
            nombreMateria.Name = "nombreMateria";
            nombreMateria.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // semestre
            // 
            semestre.FillWeight = 25F;
            semestre.HeaderText = "Semestre";
            semestre.Name = "semestre";
            semestre.ReadOnly = true;
            semestre.Visible = false;
            // 
            // editar
            // 
            editar.FillWeight = 15F;
            editar.HeaderText = "";
            editar.Image = Properties.Resources.editarIcon;
            editar.Name = "editar";
            // 
            // eliminar
            // 
            eliminar.FillWeight = 15F;
            eliminar.HeaderText = "";
            eliminar.Name = "eliminar";
            // 
            // textBoxFiltroMateria
            // 
            textBoxFiltroMateria.Location = new Point(0, 4);
            textBoxFiltroMateria.Name = "textBoxFiltroMateria";
            textBoxFiltroMateria.Size = new Size(470, 23);
            textBoxFiltroMateria.TabIndex = 4;
            // 
            // comboBoxFiltroCarrera
            // 
            comboBoxFiltroCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroCarrera.FormattingEnabled = true;
            comboBoxFiltroCarrera.Items.AddRange(new object[] { "" });
            comboBoxFiltroCarrera.Location = new Point(475, 4);
            comboBoxFiltroCarrera.Name = "comboBoxFiltroCarrera";
            comboBoxFiltroCarrera.Size = new Size(121, 23);
            comboBoxFiltroCarrera.TabIndex = 5;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(-1, 33);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(597, 30);
            panelMenuStrip.TabIndex = 12;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearMateriaToolStripMenuItem, eliminarMateriaToolStripMenuItem, asignarMateriaToolStripMenuItem, desasignarMateriaToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(597, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearMateriaToolStripMenuItem
            // 
            crearMateriaToolStripMenuItem.Name = "crearMateriaToolStripMenuItem";
            crearMateriaToolStripMenuItem.Size = new Size(90, 26);
            crearMateriaToolStripMenuItem.Text = "Crear Materia";
            // 
            // eliminarMateriaToolStripMenuItem
            // 
            eliminarMateriaToolStripMenuItem.Name = "eliminarMateriaToolStripMenuItem";
            eliminarMateriaToolStripMenuItem.Size = new Size(105, 26);
            eliminarMateriaToolStripMenuItem.Text = "Eliminar Materia";
            // 
            // asignarMateriaToolStripMenuItem
            // 
            asignarMateriaToolStripMenuItem.Name = "asignarMateriaToolStripMenuItem";
            asignarMateriaToolStripMenuItem.Size = new Size(102, 26);
            asignarMateriaToolStripMenuItem.Text = "Asignar Materia";
            // 
            // desasignarMateriaToolStripMenuItem
            // 
            desasignarMateriaToolStripMenuItem.Name = "desasignarMateriaToolStripMenuItem";
            desasignarMateriaToolStripMenuItem.Size = new Size(119, 26);
            desasignarMateriaToolStripMenuItem.Text = "Desasignar Materia";
            // 
            // FrmGestionMaterias
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(panelMenuStrip);
            Controls.Add(comboBoxFiltroCarrera);
            Controls.Add(textBoxFiltroMateria);
            Controls.Add(dataGridViewMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionMaterias";
            Text = "FrmGestionMaterias";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).EndInit();
            panelMenuStrip.ResumeLayout(false);
            panelMenuStrip.PerformLayout();
            menuStripTareasMaestro.ResumeLayout(false);
            menuStripTareasMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public DataGridView dataGridViewMaterias;
        public TextBox textBoxFiltroMateria;
        public ComboBox comboBoxFiltroCarrera;
        private Panel panelMenuStrip;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem crearMateriaToolStripMenuItem;
        public ToolStripMenuItem eliminarMateriaToolStripMenuItem;
        public ToolStripMenuItem asignarMateriaToolStripMenuItem;
        public ToolStripMenuItem desasignarMateriaToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombreMateria;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn semestre;
        private DataGridViewImageColumn editar;
        private DataGridViewCheckBoxColumn eliminar;
    }
}