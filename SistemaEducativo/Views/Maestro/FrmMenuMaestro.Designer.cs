namespace SistemaEducativo.Views.Maestro
{
    partial class FrmMenuMaestro
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
            components = new System.ComponentModel.Container();
            panelSubMenu = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            btnMinimizarVentana = new Button();
            lblMenuTitulo = new Label();
            btnCerrarVentana = new Button();
            pictureBox1 = new PictureBox();
            panelPerfil = new Panel();
            btnPerfil = new Button();
            lblRol = new Label();
            pictureBoxMPfp = new PictureBox();
            lblRolStatic = new Label();
            lblUsuarioStatic = new Label();
            lblMatricula = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel8 = new Panel();
            btnGrupos = new Button();
            panel6 = new Panel();
            btnCerrarSesion = new Button();
            lblBienvenidaSub = new Label();
            lblBienvenida = new Label();
            contextMenuStripPerfil = new ContextMenuStrip(components);
            configurarPerfilToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            contextMenuStripPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(221, 223, 244);
            panelSubMenu.Location = new Point(238, 162);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(596, 275);
            panelSubMenu.TabIndex = 30;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.FromArgb(51, 63, 167);
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 806F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel.Controls.Add(btnMinimizarVentana, 1, 0);
            tableLayoutPanel.Controls.Add(lblMenuTitulo, 0, 0);
            tableLayoutPanel.Controls.Add(btnCerrarVentana, 2, 0);
            tableLayoutPanel.Location = new Point(-1, -1);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(864, 36);
            tableLayoutPanel.TabIndex = 27;
            // 
            // btnMinimizarVentana
            // 
            btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            btnMinimizarVentana.FlatStyle = FlatStyle.Flat;
            btnMinimizarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizarVentana.ForeColor = SystemColors.ControlLightLight;
            btnMinimizarVentana.Location = new Point(806, 0);
            btnMinimizarVentana.Margin = new Padding(0);
            btnMinimizarVentana.Name = "btnMinimizarVentana";
            btnMinimizarVentana.Size = new Size(29, 36);
            btnMinimizarVentana.TabIndex = 8;
            btnMinimizarVentana.Text = "-";
            btnMinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // lblMenuTitulo
            // 
            lblMenuTitulo.AutoSize = true;
            lblMenuTitulo.Cursor = Cursors.Hand;
            lblMenuTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitulo.ForeColor = SystemColors.ControlLightLight;
            lblMenuTitulo.Location = new Point(3, 3);
            lblMenuTitulo.Margin = new Padding(3, 3, 3, 0);
            lblMenuTitulo.Name = "lblMenuTitulo";
            lblMenuTitulo.Size = new Size(70, 30);
            lblMenuTitulo.TabIndex = 10;
            lblMenuTitulo.Text = "Menú";
            // 
            // btnCerrarVentana
            // 
            btnCerrarVentana.FlatAppearance.BorderSize = 0;
            btnCerrarVentana.FlatStyle = FlatStyle.Flat;
            btnCerrarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarVentana.ForeColor = SystemColors.ControlLightLight;
            btnCerrarVentana.Location = new Point(835, 0);
            btnCerrarVentana.Margin = new Padding(0);
            btnCerrarVentana.Name = "btnCerrarVentana";
            btnCerrarVentana.Size = new Size(29, 36);
            btnCerrarVentana.TabIndex = 0;
            btnCerrarVentana.Text = "X";
            btnCerrarVentana.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PanelRounded;
            pictureBox1.Location = new Point(220, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.FromArgb(221, 223, 244);
            panelPerfil.Controls.Add(btnPerfil);
            panelPerfil.Controls.Add(lblRol);
            panelPerfil.Controls.Add(pictureBoxMPfp);
            panelPerfil.Controls.Add(lblRolStatic);
            panelPerfil.Controls.Add(lblUsuarioStatic);
            panelPerfil.Controls.Add(lblMatricula);
            panelPerfil.Location = new Point(611, 57);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(229, 65);
            panelPerfil.TabIndex = 33;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(221, 223, 244);
            btnPerfil.Cursor = Cursors.Hand;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Image = Properties.Resources.ArrowDown;
            btnPerfil.Location = new Point(205, 44);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(24, 21);
            btnPerfil.TabIndex = 13;
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(134, 40);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(21, 15);
            lblRol.TabIndex = 11;
            lblRol.Text = "rol";
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMPfp
            // 
            pictureBoxMPfp.Image = Properties.Resources.maestroPfp;
            pictureBoxMPfp.Location = new Point(0, 0);
            pictureBoxMPfp.Margin = new Padding(0);
            pictureBoxMPfp.Name = "pictureBoxMPfp";
            pictureBoxMPfp.Size = new Size(64, 64);
            pictureBoxMPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMPfp.TabIndex = 11;
            pictureBoxMPfp.TabStop = false;
            // 
            // lblRolStatic
            // 
            lblRolStatic.AutoSize = true;
            lblRolStatic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolStatic.Location = new Point(73, 40);
            lblRolStatic.Name = "lblRolStatic";
            lblRolStatic.Size = new Size(28, 15);
            lblRolStatic.TabIndex = 11;
            lblRolStatic.Text = "Rol:";
            lblRolStatic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioStatic
            // 
            lblUsuarioStatic.AutoSize = true;
            lblUsuarioStatic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioStatic.Location = new Point(73, 10);
            lblUsuarioStatic.Name = "lblUsuarioStatic";
            lblUsuarioStatic.Size = new Size(62, 15);
            lblUsuarioStatic.TabIndex = 12;
            lblUsuarioStatic.Text = "Matricula:";
            lblUsuarioStatic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(134, 10);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(46, 15);
            lblMatricula.TabIndex = 11;
            lblMatricula.Text = "usuario";
            lblMatricula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PanelRounded;
            pictureBox2.Location = new Point(599, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 225, 141);
            panel1.BackgroundImage = Properties.Resources.PanelRounded;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(9, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 249);
            panel1.TabIndex = 35;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(221, 223, 244);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel8);
            panel4.Location = new Point(7, 7);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(187, 237);
            panel4.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 24;
            label1.Text = "- Gestion -";
            // 
            // panel8
            // 
            panel8.Controls.Add(btnGrupos);
            panel8.Location = new Point(0, 84);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(204, 49);
            panel8.TabIndex = 24;
            // 
            // btnGrupos
            // 
            btnGrupos.BackColor = Color.FromArgb(221, 223, 244);
            btnGrupos.Cursor = Cursors.Hand;
            btnGrupos.FlatAppearance.BorderColor = Color.Black;
            btnGrupos.FlatAppearance.BorderSize = 0;
            btnGrupos.FlatStyle = FlatStyle.Flat;
            btnGrupos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrupos.ForeColor = SystemColors.ControlText;
            btnGrupos.Image = Properties.Resources.GrupoIcon;
            btnGrupos.Location = new Point(-80, 0);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(273, 46);
            btnGrupos.TabIndex = 14;
            btnGrupos.Text = "                        Grupos";
            btnGrupos.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCerrarSesion);
            panel6.Location = new Point(16, 408);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(189, 49);
            panel6.TabIndex = 27;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.Desktop;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.Black;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Image = Properties.Resources.CerrarSesionIcon;
            btnCerrarSesion.Location = new Point(-108, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(301, 46);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "                                Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // lblBienvenidaSub
            // 
            lblBienvenidaSub.AutoSize = true;
            lblBienvenidaSub.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenidaSub.Location = new Point(23, 92);
            lblBienvenidaSub.Name = "lblBienvenidaSub";
            lblBienvenidaSub.Size = new Size(87, 21);
            lblBienvenidaSub.TabIndex = 37;
            lblBienvenidaSub.Text = "Bienvenido";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(23, 67);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(124, 30);
            lblBienvenida.TabIndex = 36;
            lblBienvenida.Text = "Bienvenido";
            // 
            // contextMenuStripPerfil
            // 
            contextMenuStripPerfil.AutoSize = false;
            contextMenuStripPerfil.Items.AddRange(new ToolStripItem[] { configurarPerfilToolStripMenuItem });
            contextMenuStripPerfil.Name = "contextMenuStripPerfil";
            contextMenuStripPerfil.RenderMode = ToolStripRenderMode.System;
            contextMenuStripPerfil.ShowCheckMargin = true;
            contextMenuStripPerfil.Size = new Size(229, 52);
            // 
            // configurarPerfilToolStripMenuItem
            // 
            configurarPerfilToolStripMenuItem.AutoSize = false;
            configurarPerfilToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            configurarPerfilToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            configurarPerfilToolStripMenuItem.Image = Properties.Resources.EditarPerfilIcon;
            configurarPerfilToolStripMenuItem.Name = "configurarPerfilToolStripMenuItem";
            configurarPerfilToolStripMenuItem.Size = new Size(229, 26);
            configurarPerfilToolStripMenuItem.Text = "Configurar Perfil";
            // 
            // FrmMenuMaestro
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(254, 254, 255);
            ClientSize = new Size(863, 469);
            Controls.Add(lblBienvenidaSub);
            Controls.Add(lblBienvenida);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panelPerfil);
            Controls.Add(pictureBox2);
            Controls.Add(panelSubMenu);
            Controls.Add(tableLayoutPanel);
            Controls.Add(pictureBox1);
            Name = "FrmMenuMaestro";
            Text = "FrmMenuMaestro";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            contextMenuStripPerfil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        public Button btnRegistrarGeneracion;
        public Panel panelSubMenu;
        private TableLayoutPanel tableLayoutPanel;
        public Button btnMinimizarVentana;
        public Label lblMenuTitulo;
        public Button btnCerrarVentana;
        private PictureBox pictureBox1;
        public Panel panelPerfil;
        public Button btnPerfil;
        public Label lblRol;
        private Label lblRolStatic;
        private Label lblUsuarioStatic;
        public Label lblMatricula;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Panel panel8;
        public Button btnGrupos;
        private Panel panel6;
        public Button btnCerrarSesion;
        public Label lblBienvenidaSub;
        public Label lblBienvenida;
        public PictureBox pictureBoxMPfp;
        public ContextMenuStrip contextMenuStripPerfil;
        public ToolStripMenuItem configurarPerfilToolStripMenuItem;
    }
}