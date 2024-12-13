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
            eliminarGrupoToolStripMenuItem = new ToolStripMenuItem();
            asignarMaestrosToolStripMenuItem = new ToolStripMenuItem();
            id = new DataGridViewTextBoxColumn();
            carrera = new DataGridViewTextBoxColumn();
            nombreGrupo = new DataGridViewTextBoxColumn();
            semestreActual = new DataGridViewTextBoxColumn();
            fechaInicio = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewCheckBoxColumn();
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
            dataGridViewGrupos.BackgroundColor = Color.FromArgb(221, 223, 244);
            dataGridViewGrupos.BorderStyle = BorderStyle.None;
            dataGridViewGrupos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewGrupos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Columns.AddRange(new DataGridViewColumn[] { id, carrera, nombreGrupo, semestreActual, fechaInicio, editar, eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(251, 225, 141);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGrupos.EnableHeadersVisualStyles = false;
            dataGridViewGrupos.GridColor = Color.FromArgb(221, 223, 244);
            dataGridViewGrupos.Location = new Point(0, 69);
            dataGridViewGrupos.MultiSelect = false;
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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
            dataGridViewGrupos.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(221, 223, 244);
            dataGridViewGrupos.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewGrupos.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 254, 255);
            dataGridViewGrupos.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.Size = new Size(597, 206);
            dataGridViewGrupos.TabIndex = 0;
            // 
            // textBoxFiltroNombre
            // 
            textBoxFiltroNombre.BorderStyle = BorderStyle.None;
            textBoxFiltroNombre.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFiltroNombre.Location = new Point(0, 4);
            textBoxFiltroNombre.Name = "textBoxFiltroNombre";
            textBoxFiltroNombre.PlaceholderText = "Nombre del Grupo";
            textBoxFiltroNombre.Size = new Size(444, 23);
            textBoxFiltroNombre.TabIndex = 6;
            // 
            // comboBoxFiltroCarrera
            // 
            comboBoxFiltroCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroCarrera.FlatStyle = FlatStyle.Flat;
            comboBoxFiltroCarrera.FormattingEnabled = true;
            comboBoxFiltroCarrera.Items.AddRange(new object[] { "" });
            comboBoxFiltroCarrera.Location = new Point(450, 4);
            comboBoxFiltroCarrera.Name = "comboBoxFiltroCarrera";
            comboBoxFiltroCarrera.Size = new Size(147, 23);
            comboBoxFiltroCarrera.TabIndex = 7;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(0, 33);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(597, 30);
            panelMenuStrip.TabIndex = 13;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(51, 63, 167);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearGrupoToolStripMenuItem, eliminarGrupoToolStripMenuItem, asignarMaestrosToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(597, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearGrupoToolStripMenuItem
            // 
            crearGrupoToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crearGrupoToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            crearGrupoToolStripMenuItem.Name = "crearGrupoToolStripMenuItem";
            crearGrupoToolStripMenuItem.Size = new Size(82, 26);
            crearGrupoToolStripMenuItem.Text = "Crear Grupo";
            // 
            // eliminarGrupoToolStripMenuItem
            // 
            eliminarGrupoToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarGrupoToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            eliminarGrupoToolStripMenuItem.Name = "eliminarGrupoToolStripMenuItem";
            eliminarGrupoToolStripMenuItem.Size = new Size(98, 26);
            eliminarGrupoToolStripMenuItem.Text = "Eliminar Grupo";
            // 
            // asignarMaestrosToolStripMenuItem
            // 
            asignarMaestrosToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asignarMaestrosToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            asignarMaestrosToolStripMenuItem.Name = "asignarMaestrosToolStripMenuItem";
            asignarMaestrosToolStripMenuItem.Size = new Size(110, 26);
            asignarMaestrosToolStripMenuItem.Text = "Asignar Maestros";
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            // 
            // carrera
            // 
            carrera.FillWeight = 120.815475F;
            carrera.HeaderText = "Carrera";
            carrera.MinimumWidth = 6;
            carrera.Name = "carrera";
            carrera.ReadOnly = true;
            // 
            // nombreGrupo
            // 
            nombreGrupo.FillWeight = 120.815475F;
            nombreGrupo.HeaderText = "Nombre Grupo";
            nombreGrupo.MinimumWidth = 6;
            nombreGrupo.Name = "nombreGrupo";
            nombreGrupo.ReadOnly = true;
            // 
            // semestreActual
            // 
            semestreActual.FillWeight = 55F;
            semestreActual.HeaderText = "Semestre";
            semestreActual.MinimumWidth = 6;
            semestreActual.Name = "semestreActual";
            semestreActual.ReadOnly = true;
            semestreActual.Visible = false;
            // 
            // fechaInicio
            // 
            fechaInicio.FillWeight = 120.815475F;
            fechaInicio.HeaderText = "Fecha Inicio";
            fechaInicio.MinimumWidth = 6;
            fechaInicio.Name = "fechaInicio";
            fechaInicio.ReadOnly = true;
            // 
            // editar
            // 
            editar.FillWeight = 40F;
            editar.HeaderText = "";
            editar.Image = Properties.Resources.editarIcon;
            editar.MinimumWidth = 6;
            editar.Name = "editar";
            editar.Resizable = DataGridViewTriState.True;
            // 
            // eliminar
            // 
            eliminar.FillWeight = 40F;
            eliminar.HeaderText = "";
            eliminar.MinimumWidth = 6;
            eliminar.Name = "eliminar";
            // 
            // FrmGestionGrupos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
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
        public ToolStripMenuItem eliminarGrupoToolStripMenuItem;
        public ToolStripMenuItem asignarMaestrosToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn carrera;
        private DataGridViewTextBoxColumn nombreGrupo;
        private DataGridViewTextBoxColumn semestreActual;
        private DataGridViewTextBoxColumn fechaInicio;
        private DataGridViewImageColumn editar;
        private DataGridViewCheckBoxColumn eliminar;
    }
}