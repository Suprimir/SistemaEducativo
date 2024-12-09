﻿namespace SistemaEducativo.Views.Maestro
{
    partial class FrmVistaAlumnos
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
            dataGridViewAlumnos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            nombreCompleto = new DataGridViewTextBoxColumn();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            verCalificacionesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).BeginInit();
            panelMenuStrip.SuspendLayout();
            menuStripTareasMaestro.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            dataGridViewAlumnos.AllowUserToAddRows = false;
            dataGridViewAlumnos.AllowUserToDeleteRows = false;
            dataGridViewAlumnos.AllowUserToResizeColumns = false;
            dataGridViewAlumnos.AllowUserToResizeRows = false;
            dataGridViewAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlumnos.Columns.AddRange(new DataGridViewColumn[] { id, matricula, nombreCompleto });
            dataGridViewAlumnos.Location = new Point(16, 48);
            dataGridViewAlumnos.MultiSelect = false;
            dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            dataGridViewAlumnos.RowHeadersVisible = false;
            dataGridViewAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlumnos.Size = new Size(559, 213);
            dataGridViewAlumnos.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.Visible = false;
            // 
            // matricula
            // 
            matricula.HeaderText = "Matricula";
            matricula.Name = "matricula";
            // 
            // nombreCompleto
            // 
            nombreCompleto.HeaderText = "Nombre Completo";
            nombreCompleto.Name = "nombreCompleto";
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(16, 12);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(559, 30);
            panelMenuStrip.TabIndex = 15;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { verCalificacionesToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(559, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // verCalificacionesToolStripMenuItem
            // 
            verCalificacionesToolStripMenuItem.Name = "verCalificacionesToolStripMenuItem";
            verCalificacionesToolStripMenuItem.Size = new Size(111, 26);
            verCalificacionesToolStripMenuItem.Text = "Ver Calificaciones";
            // 
            // FrmVistaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(panelMenuStrip);
            Controls.Add(dataGridViewAlumnos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVistaAlumnos";
            Text = "FrmVistaAlumnos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlumnos).EndInit();
            panelMenuStrip.ResumeLayout(false);
            panelMenuStrip.PerformLayout();
            menuStripTareasMaestro.ResumeLayout(false);
            menuStripTareasMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridViewAlumnos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nombreCompleto;
        private Panel panelMenuStrip;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem verCalificacionesToolStripMenuItem;
    }
}