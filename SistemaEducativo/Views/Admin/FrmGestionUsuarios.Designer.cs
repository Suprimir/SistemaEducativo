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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewUsuarios = new DataGridView();
            textBoxFiltroUsuarios = new TextBox();
            comboBoxFiltroRol = new ComboBox();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            verCalificacionesToolStripMenuItem = new ToolStripMenuItem();
            id = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            grupoID = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewCheckBoxColumn();
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
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.BackgroundColor = Color.FromArgb(251, 225, 141);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 220, 201);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, matricula, nombre, correo, rol, grupoID, editar, eliminar });
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.GridColor = Color.FromArgb(251, 225, 141);
            dataGridViewUsuarios.Location = new Point(0, 86);
            dataGridViewUsuarios.Margin = new Padding(4);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(251, 225, 141);
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(228, 220, 201);
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(746, 258);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // textBoxFiltroUsuarios
            // 
            textBoxFiltroUsuarios.Location = new Point(0, 5);
            textBoxFiltroUsuarios.Margin = new Padding(4);
            textBoxFiltroUsuarios.Name = "textBoxFiltroUsuarios";
            textBoxFiltroUsuarios.Size = new Size(586, 27);
            textBoxFiltroUsuarios.TabIndex = 1;
            // 
            // comboBoxFiltroRol
            // 
            comboBoxFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroRol.FormattingEnabled = true;
            comboBoxFiltroRol.Items.AddRange(new object[] { "", "alumno", "maestro", "admin" });
            comboBoxFiltroRol.Location = new Point(595, 5);
            comboBoxFiltroRol.Margin = new Padding(4);
            comboBoxFiltroRol.Name = "comboBoxFiltroRol";
            comboBoxFiltroRol.Size = new Size(150, 28);
            comboBoxFiltroRol.TabIndex = 2;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(0, 41);
            panelMenuStrip.Margin = new Padding(4);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(746, 38);
            panelMenuStrip.TabIndex = 11;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, verCalificacionesToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Size = new Size(746, 38);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(112, 34);
            crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(131, 34);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // verCalificacionesToolStripMenuItem
            // 
            verCalificacionesToolStripMenuItem.Name = "verCalificacionesToolStripMenuItem";
            verCalificacionesToolStripMenuItem.Size = new Size(139, 34);
            verCalificacionesToolStripMenuItem.Text = "Ver Calificaciones";
            // 
            // id
            // 
            id.FillWeight = 80F;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            // 
            // matricula
            // 
            matricula.FillWeight = 60F;
            matricula.HeaderText = "Matricula";
            matricula.MinimumWidth = 6;
            matricula.Name = "matricula";
            matricula.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // rol
            // 
            rol.FillWeight = 50F;
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.ReadOnly = true;
            // 
            // grupoID
            // 
            grupoID.FillWeight = 42F;
            grupoID.HeaderText = "Grupo";
            grupoID.MinimumWidth = 6;
            grupoID.Name = "grupoID";
            grupoID.ReadOnly = true;
            // 
            // editar
            // 
            editar.FillWeight = 35F;
            editar.HeaderText = "";
            editar.Image = Properties.Resources.editarIcon;
            editar.MinimumWidth = 6;
            editar.Name = "editar";
            // 
            // eliminar
            // 
            eliminar.FillWeight = 35F;
            eliminar.HeaderText = "";
            eliminar.MinimumWidth = 6;
            eliminar.Name = "eliminar";
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(745, 344);
            Controls.Add(panelMenuStrip);
            Controls.Add(comboBoxFiltroRol);
            Controls.Add(textBoxFiltroUsuarios);
            Controls.Add(dataGridViewUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
        public ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        public ToolStripMenuItem verCalificacionesToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn grupoID;
        private DataGridViewImageColumn editar;
        private DataGridViewCheckBoxColumn eliminar;
    }
}