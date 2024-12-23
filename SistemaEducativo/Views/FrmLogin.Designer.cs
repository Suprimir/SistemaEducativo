﻿namespace SistemaEducativo
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            textBoxUsuario = new TextBox();
            textBoxPass = new TextBox();
            btnIniciarSesion = new Button();
            pictureBox2 = new PictureBox();
            btnCerrarVentana = new Button();
            btnMinimizarVentana = new Button();
            tableLayoutPanelCustom = new TableLayoutPanel();
            lblLoginTitle = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanelCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.Window;
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsuario.Location = new Point(108, 201);
            textBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuario.MaxLength = 10;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario";
            textBoxUsuario.Size = new Size(194, 26);
            textBoxUsuario.TabIndex = 1;
            textBoxUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPass
            // 
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.Location = new Point(108, 265);
            textBoxPass.Margin = new Padding(3, 2, 3, 2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '●';
            textBoxPass.PlaceholderText = "Contraseña";
            textBoxPass.Size = new Size(194, 26);
            textBoxPass.TabIndex = 2;
            textBoxPass.TextAlign = HorizontalAlignment.Center;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.Black;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.MouseDownBackColor = SystemColors.ControlText;
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = SystemColors.ControlText;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = SystemColors.ControlLightLight;
            btnIniciarSesion.Location = new Point(108, 327);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(164, 39);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bunnyLogin;
            pictureBox2.Location = new Point(389, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 288);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnCerrarVentana
            // 
            btnCerrarVentana.FlatAppearance.BorderSize = 0;
            btnCerrarVentana.FlatStyle = FlatStyle.Flat;
            btnCerrarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarVentana.ForeColor = SystemColors.ControlLightLight;
            btnCerrarVentana.Location = new Point(679, 0);
            btnCerrarVentana.Margin = new Padding(0);
            btnCerrarVentana.Name = "btnCerrarVentana";
            btnCerrarVentana.Size = new Size(29, 37);
            btnCerrarVentana.TabIndex = 0;
            btnCerrarVentana.TabStop = false;
            btnCerrarVentana.Text = "X";
            btnCerrarVentana.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarVentana
            // 
            btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            btnMinimizarVentana.FlatStyle = FlatStyle.Flat;
            btnMinimizarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizarVentana.ForeColor = SystemColors.ControlLightLight;
            btnMinimizarVentana.Location = new Point(650, 0);
            btnMinimizarVentana.Margin = new Padding(0);
            btnMinimizarVentana.Name = "btnMinimizarVentana";
            btnMinimizarVentana.Size = new Size(29, 37);
            btnMinimizarVentana.TabIndex = 8;
            btnMinimizarVentana.TabStop = false;
            btnMinimizarVentana.Text = "-";
            btnMinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCustom
            // 
            tableLayoutPanelCustom.BackColor = Color.FromArgb(51, 63, 167);
            tableLayoutPanelCustom.ColumnCount = 3;
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 650F));
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanelCustom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCustom.Controls.Add(lblLoginTitle, 0, 0);
            tableLayoutPanelCustom.Controls.Add(btnCerrarVentana, 2, 0);
            tableLayoutPanelCustom.Controls.Add(btnMinimizarVentana, 1, 0);
            tableLayoutPanelCustom.Location = new Point(0, -1);
            tableLayoutPanelCustom.Margin = new Padding(0);
            tableLayoutPanelCustom.Name = "tableLayoutPanelCustom";
            tableLayoutPanelCustom.RowCount = 1;
            tableLayoutPanelCustom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCustom.Size = new Size(708, 37);
            tableLayoutPanelCustom.TabIndex = 9;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = SystemColors.ControlLightLight;
            lblLoginTitle.Location = new Point(3, 3);
            lblLoginTitle.Margin = new Padding(3, 3, 3, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(168, 30);
            lblLoginTitle.TabIndex = 10;
            lblLoginTitle.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userIcon;
            pictureBox1.Location = new Point(77, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.passIcon;
            pictureBox3.Location = new Point(77, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.logInBox;
            pictureBoxLogin.Location = new Point(23, 66);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(335, 341);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 5;
            pictureBoxLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(254, 254, 255);
            ClientSize = new Size(708, 429);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanelCustom);
            Controls.Add(pictureBox2);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxPass);
            Controls.Add(pictureBoxLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanelCustom.ResumeLayout(false);
            tableLayoutPanelCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox textBoxUsuario;
        public TextBox textBoxPass;
        public Button btnIniciarSesion;
        private PictureBox pictureBox2;
        private Label lblLoginTitle;
        public Button btnCerrarVentana;
        public Button btnMinimizarVentana;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxLogin;
        public TableLayoutPanel tableLayoutPanelCustom;
    }
}
