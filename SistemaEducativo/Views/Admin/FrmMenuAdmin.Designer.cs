﻿namespace SistemaEducativo.Views.Admin
{
    partial class FrmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAdmin));
            pictureBoxMPfp = new PictureBox();
            btnGrupos = new Button();
            panelPerfil = new Panel();
            contextMenuStripPerfil = new ContextMenuStrip(components);
            configurarPerfilToolStripMenuItem = new ToolStripMenuItem();
            btnPerfil = new Button();
            lblRol = new Label();
            lblRolStatic = new Label();
            lblUsuarioStatic = new Label();
            lblMatricula = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            btnCarreras = new Button();
            lblGestionStatic = new Label();
            panel5 = new Panel();
            btnMaterias = new Button();
            panel4 = new Panel();
            btnUsuarios = new Button();
            panel3 = new Panel();
            panel6 = new Panel();
            btnCerrarSesion = new Button();
            panelSubMenu = new Panel();
            lblBienvenida = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btnCerrarVentana = new Button();
            lblMenuTitulo = new Label();
            btnMinimizarVentana = new Button();
            tableLayoutPanelCustom = new TableLayoutPanel();
            lblBienvenidaSub = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).BeginInit();
            panelPerfil.SuspendLayout();
            contextMenuStripPerfil.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanelCustom.SuspendLayout();
            SuspendLayout();
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
            // btnGrupos
            // 
            btnGrupos.BackColor = Color.FromArgb(221, 223, 244);
            btnGrupos.Cursor = Cursors.Hand;
            btnGrupos.FlatAppearance.BorderColor = Color.FromArgb(221, 223, 244);
            btnGrupos.FlatAppearance.BorderSize = 0;
            btnGrupos.FlatStyle = FlatStyle.Flat;
            btnGrupos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrupos.ForeColor = SystemColors.ControlText;
            btnGrupos.Image = Properties.Resources.GrupoIcon;
            btnGrupos.Location = new Point(-80, 0);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(273, 46);
            btnGrupos.TabIndex = 1;
            btnGrupos.Text = "                        Grupos";
            btnGrupos.UseVisualStyleBackColor = false;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.FromArgb(221, 223, 244);
            panelPerfil.ContextMenuStrip = contextMenuStripPerfil;
            panelPerfil.Controls.Add(btnPerfil);
            panelPerfil.Controls.Add(lblRol);
            panelPerfil.Controls.Add(pictureBoxMPfp);
            panelPerfil.Controls.Add(lblRolStatic);
            panelPerfil.Controls.Add(lblUsuarioStatic);
            panelPerfil.Controls.Add(lblMatricula);
            panelPerfil.Location = new Point(611, 57);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(229, 65);
            panelPerfil.TabIndex = 22;
            // 
            // contextMenuStripPerfil
            // 
            contextMenuStripPerfil.BackColor = Color.FromArgb(221, 223, 244);
            contextMenuStripPerfil.Items.AddRange(new ToolStripItem[] { configurarPerfilToolStripMenuItem });
            contextMenuStripPerfil.Name = "contextMenuStripPerfil";
            contextMenuStripPerfil.RenderMode = ToolStripRenderMode.System;
            contextMenuStripPerfil.ShowCheckMargin = true;
            contextMenuStripPerfil.ShowItemToolTips = false;
            contextMenuStripPerfil.Size = new Size(219, 30);
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
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(221, 223, 244);
            btnPerfil.ContextMenuStrip = contextMenuStripPerfil;
            btnPerfil.Cursor = Cursors.Hand;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Image = Properties.Resources.ArrowDown;
            btnPerfil.Location = new Point(205, 44);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(24, 21);
            btnPerfil.TabIndex = 13;
            btnPerfil.TabStop = false;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 223, 244);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(lblGestionStatic);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(7, 7);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 237);
            panel2.TabIndex = 23;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnCarreras);
            panel7.Location = new Point(0, 188);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(204, 49);
            panel7.TabIndex = 27;
            // 
            // btnCarreras
            // 
            btnCarreras.BackColor = Color.FromArgb(221, 223, 244);
            btnCarreras.Cursor = Cursors.Hand;
            btnCarreras.FlatAppearance.BorderColor = Color.FromArgb(221, 223, 244);
            btnCarreras.FlatAppearance.BorderSize = 0;
            btnCarreras.FlatStyle = FlatStyle.Flat;
            btnCarreras.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarreras.ForeColor = SystemColors.ControlText;
            btnCarreras.Image = Properties.Resources.tituloIcon;
            btnCarreras.Location = new Point(-83, 0);
            btnCarreras.Name = "btnCarreras";
            btnCarreras.Size = new Size(273, 46);
            btnCarreras.TabIndex = 3;
            btnCarreras.Text = "                        Carreras";
            btnCarreras.UseVisualStyleBackColor = false;
            // 
            // lblGestionStatic
            // 
            lblGestionStatic.AutoSize = true;
            lblGestionStatic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGestionStatic.Location = new Point(59, 15);
            lblGestionStatic.Name = "lblGestionStatic";
            lblGestionStatic.Size = new Size(72, 17);
            lblGestionStatic.TabIndex = 24;
            lblGestionStatic.Text = "- Gestion -";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnMaterias);
            panel5.Location = new Point(0, 139);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 49);
            panel5.TabIndex = 26;
            // 
            // btnMaterias
            // 
            btnMaterias.BackColor = Color.FromArgb(221, 223, 244);
            btnMaterias.Cursor = Cursors.Hand;
            btnMaterias.FlatAppearance.BorderColor = Color.FromArgb(221, 223, 244);
            btnMaterias.FlatAppearance.BorderSize = 0;
            btnMaterias.FlatStyle = FlatStyle.Flat;
            btnMaterias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaterias.ForeColor = SystemColors.ControlText;
            btnMaterias.Image = Properties.Resources.MateriasIcon;
            btnMaterias.Location = new Point(-83, 0);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(273, 46);
            btnMaterias.TabIndex = 3;
            btnMaterias.Text = "                        Materias";
            btnMaterias.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnUsuarios);
            panel4.Location = new Point(0, 90);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 49);
            panel4.TabIndex = 25;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(221, 223, 244);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(221, 223, 244);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = SystemColors.ControlText;
            btnUsuarios.Image = Properties.Resources.UsuarioIcon;
            btnUsuarios.Location = new Point(-80, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(273, 46);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "                        Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGrupos);
            panel3.Location = new Point(0, 38);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 49);
            panel3.TabIndex = 24;
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
            btnCerrarSesion.Location = new Point(-102, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(301, 46);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "                                Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.FromArgb(221, 223, 244);
            panelSubMenu.Location = new Point(239, 163);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(596, 275);
            panelSubMenu.TabIndex = 24;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(23, 67);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(124, 30);
            lblBienvenida.TabIndex = 25;
            lblBienvenida.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PanelRounded;
            pictureBox1.Location = new Point(221, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PanelRounded;
            pictureBox2.Location = new Point(599, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.PanelRounded;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(9, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 249);
            panel1.TabIndex = 28;
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
            btnCerrarVentana.TabStop = false;
            btnCerrarVentana.Text = "X";
            btnCerrarVentana.UseVisualStyleBackColor = true;
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
            btnMinimizarVentana.TabStop = false;
            btnMinimizarVentana.Text = "-";
            btnMinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCustom
            // 
            tableLayoutPanelCustom.BackColor = Color.FromArgb(51, 63, 167);
            tableLayoutPanelCustom.ColumnCount = 3;
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 806F));
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanelCustom.Controls.Add(btnMinimizarVentana, 1, 0);
            tableLayoutPanelCustom.Controls.Add(lblMenuTitulo, 0, 0);
            tableLayoutPanelCustom.Controls.Add(btnCerrarVentana, 2, 0);
            tableLayoutPanelCustom.Location = new Point(0, 0);
            tableLayoutPanelCustom.Margin = new Padding(0);
            tableLayoutPanelCustom.Name = "tableLayoutPanelCustom";
            tableLayoutPanelCustom.RowCount = 1;
            tableLayoutPanelCustom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCustom.Size = new Size(864, 36);
            tableLayoutPanelCustom.TabIndex = 11;
            // 
            // lblBienvenidaSub
            // 
            lblBienvenidaSub.AutoSize = true;
            lblBienvenidaSub.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenidaSub.Location = new Point(23, 92);
            lblBienvenidaSub.Name = "lblBienvenidaSub";
            lblBienvenidaSub.Size = new Size(87, 21);
            lblBienvenidaSub.TabIndex = 29;
            lblBienvenidaSub.Text = "Bienvenido";
            // 
            // FrmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(254, 254, 255);
            ClientSize = new Size(863, 469);
            Controls.Add(lblBienvenidaSub);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panelPerfil);
            Controls.Add(lblBienvenida);
            Controls.Add(panelSubMenu);
            Controls.Add(tableLayoutPanelCustom);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenuAdmin";
            Text = "FrmMenuAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).EndInit();
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            contextMenuStripPerfil.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanelCustom.ResumeLayout(false);
            tableLayoutPanelCustom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        public Button btnRegistrarGeneracion;
        public Button btnGrupos;
        public Button btnPerfil;
        private Label lblUsuarioStatic;
        private Label lblRolStatic;
        public Button btnMaterias;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        public Button btnUsuarios;
        private Panel panel5;
        public Button button2;
        private Panel panel6;
        public Button btnCerrarSesion;
        private Label lblGestionStatic;
        public Label lblRol;
        public Label lblMatricula;
        public ContextMenuStrip contextMenuStripPerfil;
        public Panel panelPerfil;
        public ToolStripMenuItem configurarPerfilToolStripMenuItem;
        public Panel panelSubMenu;
        private PictureBox pictureBox1;
        public Label lblBienvenida;
        private PictureBox pictureBox2;
        private Panel panel1;
        public Button btnCerrarVentana;
        public Label lblMenuTitulo;
        public Button btnMinimizarVentana;
        public Label lblBienvenidaSub;
        public TableLayoutPanel tableLayoutPanelCustom;
        public PictureBox pictureBoxMPfp;
        private Panel panel7;
        public Button btnCarreras;
    }
}