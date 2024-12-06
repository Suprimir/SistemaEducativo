namespace SistemaEducativo.Views.Maestro
{
    partial class FrmGestionTareas
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
            flowLayoutPanelTareas = new FlowLayoutPanel();
            panelMenuStrip = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearTareaToolStripMenuItem = new ToolStripMenuItem();
            editarTareaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem = new ToolStripMenuItem();
            panelMenuStrip.SuspendLayout();
            menuStripTareasMaestro.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTareas
            // 
            flowLayoutPanelTareas.AutoScroll = true;
            flowLayoutPanelTareas.Location = new Point(17, 45);
            flowLayoutPanelTareas.Margin = new Padding(0);
            flowLayoutPanelTareas.Name = "flowLayoutPanelTareas";
            flowLayoutPanelTareas.Size = new Size(557, 221);
            flowLayoutPanelTareas.TabIndex = 9;
            // 
            // panelMenuStrip
            // 
            panelMenuStrip.AutoSize = true;
            panelMenuStrip.Controls.Add(menuStripTareasMaestro);
            panelMenuStrip.Location = new Point(17, 12);
            panelMenuStrip.Name = "panelMenuStrip";
            panelMenuStrip.Size = new Size(540, 30);
            panelMenuStrip.TabIndex = 10;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.BackgroundImageLayout = ImageLayout.None;
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearTareaToolStripMenuItem, editarTareaToolStripMenuItem, eliminarTareaToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Padding = new Padding(5, 2, 0, 2);
            menuStripTareasMaestro.Size = new Size(540, 30);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearTareaToolStripMenuItem
            // 
            crearTareaToolStripMenuItem.Name = "crearTareaToolStripMenuItem";
            crearTareaToolStripMenuItem.Size = new Size(78, 26);
            crearTareaToolStripMenuItem.Text = "Crear Tarea";
            // 
            // editarTareaToolStripMenuItem
            // 
            editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            editarTareaToolStripMenuItem.Size = new Size(80, 26);
            editarTareaToolStripMenuItem.Text = "Editar Tarea";
            // 
            // eliminarTareaToolStripMenuItem
            // 
            eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            eliminarTareaToolStripMenuItem.Size = new Size(93, 26);
            eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            // 
            // FrmGestionTareas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(596, 275);
            Controls.Add(panelMenuStrip);
            Controls.Add(flowLayoutPanelTareas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTareas";
            Text = "FrmGestionTareas";
            panelMenuStrip.ResumeLayout(false);
            panelMenuStrip.PerformLayout();
            menuStripTareasMaestro.ResumeLayout(false);
            menuStripTareasMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public FlowLayoutPanel flowLayoutPanelTareas;
        private Panel panelMenuStrip;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem crearTareaToolStripMenuItem;
        public ToolStripMenuItem editarTareaToolStripMenuItem;
        public ToolStripMenuItem eliminarTareaToolStripMenuItem;
    }
}