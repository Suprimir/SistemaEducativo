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
            panel1 = new Panel();
            menuStripTareasMaestro = new MenuStrip();
            crearTareaToolStripMenuItem = new ToolStripMenuItem();
            editarTareaToolStripMenuItem = new ToolStripMenuItem();
            eliminarTareaToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            comboBoxParciales = new ComboBox();
            lblParcialStatic = new Label();
            panel1.SuspendLayout();
            menuStripTareasMaestro.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTareas
            // 
            flowLayoutPanelTareas.AutoScroll = true;
            flowLayoutPanelTareas.Location = new Point(20, 80);
            flowLayoutPanelTareas.Margin = new Padding(0);
            flowLayoutPanelTareas.Name = "flowLayoutPanelTareas";
            flowLayoutPanelTareas.Size = new Size(697, 239);
            flowLayoutPanelTareas.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStripTareasMaestro);
            panel1.Location = new Point(20, 43);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 37);
            panel1.TabIndex = 10;
            // 
            // menuStripTareasMaestro
            // 
            menuStripTareasMaestro.BackColor = Color.FromArgb(228, 220, 201);
            menuStripTareasMaestro.Dock = DockStyle.Fill;
            menuStripTareasMaestro.ImageScalingSize = new Size(20, 20);
            menuStripTareasMaestro.Items.AddRange(new ToolStripItem[] { crearTareaToolStripMenuItem, editarTareaToolStripMenuItem, eliminarTareaToolStripMenuItem });
            menuStripTareasMaestro.Location = new Point(0, 0);
            menuStripTareasMaestro.Name = "menuStripTareasMaestro";
            menuStripTareasMaestro.Size = new Size(697, 37);
            menuStripTareasMaestro.TabIndex = 2;
            menuStripTareasMaestro.Text = "menuStrip1";
            // 
            // crearTareaToolStripMenuItem
            // 
            crearTareaToolStripMenuItem.AutoSize = false;
            crearTareaToolStripMenuItem.Name = "crearTareaToolStripMenuItem";
            crearTareaToolStripMenuItem.Size = new Size(230, 33);
            crearTareaToolStripMenuItem.Text = "Crear Tarea";
            // 
            // editarTareaToolStripMenuItem
            // 
            editarTareaToolStripMenuItem.AutoSize = false;
            editarTareaToolStripMenuItem.Name = "editarTareaToolStripMenuItem";
            editarTareaToolStripMenuItem.Size = new Size(230, 33);
            editarTareaToolStripMenuItem.Text = "Editar Tarea";
            // 
            // eliminarTareaToolStripMenuItem
            // 
            eliminarTareaToolStripMenuItem.AutoSize = false;
            eliminarTareaToolStripMenuItem.Name = "eliminarTareaToolStripMenuItem";
            eliminarTareaToolStripMenuItem.Size = new Size(231, 33);
            eliminarTareaToolStripMenuItem.Text = "Eliminar Tarea";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(540, 27);
            textBox1.TabIndex = 11;
            // 
            // comboBoxParciales
            // 
            comboBoxParciales.FormattingEnabled = true;
            comboBoxParciales.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxParciales.Location = new Point(78, 12);
            comboBoxParciales.Name = "comboBoxParciales";
            comboBoxParciales.Size = new Size(93, 28);
            comboBoxParciales.TabIndex = 12;
            // 
            // lblParcialStatic
            // 
            lblParcialStatic.AutoSize = true;
            lblParcialStatic.Location = new Point(20, 15);
            lblParcialStatic.Name = "lblParcialStatic";
            lblParcialStatic.Size = new Size(52, 20);
            lblParcialStatic.TabIndex = 13;
            lblParcialStatic.Text = "Parcial";
            // 
            // FrmGestionTareas
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(251, 225, 141);
            ClientSize = new Size(745, 344);
            Controls.Add(lblParcialStatic);
            Controls.Add(comboBoxParciales);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanelTareas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmGestionTareas";
            Text = "FrmGestionTareas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStripTareasMaestro.ResumeLayout(false);
            menuStripTareasMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public FlowLayoutPanel flowLayoutPanelTareas;
        private Panel panel1;
        public MenuStrip menuStripTareasMaestro;
        public ToolStripMenuItem crearTareaToolStripMenuItem;
        public ToolStripMenuItem editarTareaToolStripMenuItem;
        public ToolStripMenuItem eliminarTareaToolStripMenuItem;
        private TextBox textBox1;
        private ComboBox comboBoxParciales;
        private Label lblParcialStatic;
    }
}