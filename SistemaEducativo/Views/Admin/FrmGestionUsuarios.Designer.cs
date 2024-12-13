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
            id = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            grupoID = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewCheckBoxColumn();
            textBoxFiltroUsuarios = new TextBox();
            comboBoxFiltroRol = new ComboBox();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearUsuarioToolStripMenuItem = new ToolStripMenuItem();
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
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.BackgroundColor = Color.FromArgb(221, 223, 244);
            dataGridViewUsuarios.BorderStyle = BorderStyle.None;
            dataGridViewUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 63, 167);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, matricula, nombre, correo, rol, grupoID, editar, eliminar });
            dataGridViewUsuarios.EnableHeadersVisualStyles = false;
            dataGridViewUsuarios.GridColor = Color.FromArgb(221, 223, 244);
            dataGridViewUsuarios.Location = new Point(0, 69);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(221, 223, 244);
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText;
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 254, 255);
            dataGridViewUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(597, 206);
            dataGridViewUsuarios.TabIndex = 0;
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
            // textBoxFiltroUsuarios
            // 
            textBoxFiltroUsuarios.BorderStyle = BorderStyle.None;
            textBoxFiltroUsuarios.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFiltroUsuarios.Location = new Point(0, 4);
            textBoxFiltroUsuarios.Name = "textBoxFiltroUsuarios";
            textBoxFiltroUsuarios.PlaceholderText = "Nombre de Usuario";
            textBoxFiltroUsuarios.Size = new Size(470, 23);
            textBoxFiltroUsuarios.TabIndex = 1;
            // 
            // comboBoxFiltroRol
            // 
            comboBoxFiltroRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroRol.FlatStyle = FlatStyle.Flat;
            comboBoxFiltroRol.FormattingEnabled = true;
            comboBoxFiltroRol.Items.AddRange(new object[] { "", "Alumno", "Maestro", "Admin" });
            comboBoxFiltroRol.Location = new Point(476, 4);
            comboBoxFiltroRol.Name = "comboBoxFiltroRol";
            comboBoxFiltroRol.Size = new Size(121, 23);
            comboBoxFiltroRol.TabIndex = 2;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(0, 33);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(597, 30);
            panelMenuStrip.TabIndex = 11;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(51, 63, 167);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearUsuarioToolStripMenuItem, eliminarUsuarioToolStripMenuItem, verCalificacionesToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(597, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            crearUsuarioToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crearUsuarioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            crearUsuarioToolStripMenuItem.Size = new Size(89, 26);
            crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            eliminarUsuarioToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarUsuarioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            eliminarUsuarioToolStripMenuItem.Size = new Size(105, 26);
            eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            // 
            // verCalificacionesToolStripMenuItem
            // 
            verCalificacionesToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verCalificacionesToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            verCalificacionesToolStripMenuItem.Name = "verCalificacionesToolStripMenuItem";
            verCalificacionesToolStripMenuItem.Size = new Size(111, 26);
            verCalificacionesToolStripMenuItem.Text = "Ver Calificaciones";
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
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