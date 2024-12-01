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
            lblBienvenida = new Label();
            panelSubMenu = new Panel();
            panel2 = new Panel();
            lblGestionStatic = new Label();
            panel6 = new Panel();
            btnCerrarSesion = new Button();
            panel3 = new Panel();
            btnGrupos = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
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
            lblUsuario = new Label();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(220, 73);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(124, 30);
            lblBienvenida.TabIndex = 31;
            lblBienvenida.Text = "Bienvenido";
            // 
            // panelSubMenu
            // 
            panelSubMenu.BackColor = Color.White;
            panelSubMenu.Location = new Point(238, 162);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(596, 275);
            panelSubMenu.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblGestionStatic);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(2, 35);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 435);
            panel2.TabIndex = 29;
            // 
            // lblGestionStatic
            // 
            lblGestionStatic.AutoSize = true;
            lblGestionStatic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGestionStatic.Location = new Point(74, 38);
            lblGestionStatic.Name = "lblGestionStatic";
            lblGestionStatic.Size = new Size(72, 17);
            lblGestionStatic.TabIndex = 24;
            lblGestionStatic.Text = "- Gestion -";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCerrarSesion);
            panel6.Location = new Point(0, 315);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 49);
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
            btnCerrarSesion.Location = new Point(-97, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(301, 46);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "                                Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGrupos);
            panel3.Location = new Point(0, 84);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 49);
            panel3.TabIndex = 24;
            // 
            // btnGrupos
            // 
            btnGrupos.BackColor = SystemColors.ControlLightLight;
            btnGrupos.Cursor = Cursors.Hand;
            btnGrupos.FlatAppearance.BorderColor = Color.Black;
            btnGrupos.FlatAppearance.BorderSize = 0;
            btnGrupos.FlatStyle = FlatStyle.Flat;
            btnGrupos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrupos.ForeColor = SystemColors.ControlText;
            btnGrupos.Image = Properties.Resources.GrupoIcon;
            btnGrupos.Location = new Point(-69, 0);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(273, 46);
            btnGrupos.TabIndex = 14;
            btnGrupos.Text = "                        Grupos";
            btnGrupos.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(199, 206, 206);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 806F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Controls.Add(btnMinimizarVentana, 1, 0);
            tableLayoutPanel2.Controls.Add(lblMenuTitulo, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCerrarVentana, 2, 0);
            tableLayoutPanel2.Location = new Point(-1, -1);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(864, 36);
            tableLayoutPanel2.TabIndex = 27;
            // 
            // btnMinimizarVentana
            // 
            btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            btnMinimizarVentana.FlatStyle = FlatStyle.Flat;
            btnMinimizarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnCerrarVentana.ForeColor = SystemColors.ControlText;
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
            pictureBox1.Image = Properties.Resources.PanelWhiteRounded;
            pictureBox1.Location = new Point(220, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.White;
            panelPerfil.Controls.Add(btnPerfil);
            panelPerfil.Controls.Add(lblRol);
            panelPerfil.Controls.Add(pictureBoxMPfp);
            panelPerfil.Controls.Add(lblRolStatic);
            panelPerfil.Controls.Add(lblUsuarioStatic);
            panelPerfil.Controls.Add(lblUsuario);
            panelPerfil.Location = new Point(611, 57);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(229, 65);
            panelPerfil.TabIndex = 33;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.White;
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
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(134, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(46, 15);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PanelWhiteRounded;
            pictureBox2.Location = new Point(599, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // FrmMenuMaestro
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(232, 232, 226);
            ClientSize = new Size(863, 469);
            Controls.Add(panelPerfil);
            Controls.Add(pictureBox2);
            Controls.Add(lblBienvenida);
            Controls.Add(panelSubMenu);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(pictureBox1);
            Name = "FrmMenuMaestro";
            Text = "FrmMenuMaestro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        public Button btnRegistrarGeneracion;
        public Label lblBienvenida;
        public Panel panelSubMenu;
        private Panel panel2;
        private Label lblGestionStatic;
        private Panel panel6;
        public Button btnCerrarSesion;
        private Panel panel3;
        public Button btnGrupos;
        private TableLayoutPanel tableLayoutPanel2;
        public Button btnMinimizarVentana;
        public Label lblMenuTitulo;
        public Button btnCerrarVentana;
        private PictureBox pictureBox1;
        public Panel panelPerfil;
        public Button btnPerfil;
        public Label lblRol;
        private PictureBox pictureBoxMPfp;
        private Label lblRolStatic;
        private Label lblUsuarioStatic;
        public Label lblUsuario;
        private PictureBox pictureBox2;
    }
}