namespace SistemaEducativo.Views.Maestro
{
    partial class FrmGestionGruposAsignados
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
            id = new DataGridViewTextBoxColumn();
            grupoNombre = new DataGridViewTextBoxColumn();
            materia = new DataGridViewTextBoxColumn();
            semestre = new DataGridViewTextBoxColumn();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            verAlumnosToolStripMenuItem = new ToolStripMenuItem();
            verTareasToolStripMenuItem = new ToolStripMenuItem();
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
            dataGridViewGrupos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Columns.AddRange(new DataGridViewColumn[] { id, grupoNombre, materia, semestre });
            dataGridViewGrupos.Location = new Point(16, 48);
            dataGridViewGrupos.MultiSelect = false;
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.Size = new Size(559, 213);
            dataGridViewGrupos.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.Visible = false;
            // 
            // grupoNombre
            // 
            grupoNombre.HeaderText = "Nombre Grupo";
            grupoNombre.Name = "grupoNombre";
            // 
            // materia
            // 
            materia.HeaderText = "Materia";
            materia.Name = "materia";
            // 
            // semestre
            // 
            semestre.HeaderText = "Semestre";
            semestre.Name = "semestre";
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(16, 12);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(559, 30);
            panelMenuStrip.TabIndex = 14;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { verAlumnosToolStripMenuItem, verTareasToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(559, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // verAlumnosToolStripMenuItem
            // 
            verAlumnosToolStripMenuItem.Name = "verAlumnosToolStripMenuItem";
            verAlumnosToolStripMenuItem.Size = new Size(86, 26);
            verAlumnosToolStripMenuItem.Text = "Ver Alumnos";
            // 
            // verTareasToolStripMenuItem
            // 
            verTareasToolStripMenuItem.Name = "verTareasToolStripMenuItem";
            verTareasToolStripMenuItem.Size = new Size(71, 26);
            verTareasToolStripMenuItem.Text = "Ver Tareas";
            // 
            // FrmGestionGruposAsignados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(panelMenuStrip);
            Controls.Add(dataGridViewGrupos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionGruposAsignados";
            Text = "FrmGestionGruposAsignados";
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
        private Panel panelMenuStrip;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem verAlumnosToolStripMenuItem;
        public ToolStripMenuItem verTareasToolStripMenuItem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn grupoNombre;
        private DataGridViewTextBoxColumn materia;
        private DataGridViewTextBoxColumn semestre;
    }
}