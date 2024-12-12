namespace SistemaEducativo
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
            textBoxUsuario = new TextBox();
            textBoxPass = new TextBox();
            btnIniciarSesion = new Button();
            pictureBox2 = new PictureBox();
            btnCerrarVentana = new Button();
            btnMinimizarVentana = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblLoginTitle = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            textBoxUsuario.Location = new Point(135, 251);
            textBoxUsuario.Margin = new Padding(4, 2, 4, 2);
            textBoxUsuario.MaxLength = 10;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario";
            textBoxUsuario.Size = new Size(242, 32);
            textBoxUsuario.TabIndex = 1;
            textBoxUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPass
            // 
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.Location = new Point(135, 331);
            textBoxPass.Margin = new Padding(4, 2, 4, 2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '●';
            textBoxPass.PlaceholderText = "Contraseña";
            textBoxPass.Size = new Size(242, 32);
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
            btnIniciarSesion.Location = new Point(135, 409);
            btnIniciarSesion.Margin = new Padding(4, 4, 4, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(205, 49);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bunnyLogin;
            pictureBox2.Location = new Point(486, 119);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(365, 360);
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
            btnCerrarVentana.Location = new Point(848, 0);
            btnCerrarVentana.Margin = new Padding(0);
            btnCerrarVentana.Name = "btnCerrarVentana";
            btnCerrarVentana.Size = new Size(36, 46);
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
            btnMinimizarVentana.Location = new Point(812, 0);
            btnMinimizarVentana.Margin = new Padding(0);
            btnMinimizarVentana.Name = "btnMinimizarVentana";
            btnMinimizarVentana.Size = new Size(36, 46);
            btnMinimizarVentana.TabIndex = 8;
            btnMinimizarVentana.TabStop = false;
            btnMinimizarVentana.Text = "-";
            btnMinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(51, 63, 167);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 812F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(lblLoginTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCerrarVentana, 2, 0);
            tableLayoutPanel1.Controls.Add(btnMinimizarVentana, 1, 0);
            tableLayoutPanel1.Location = new Point(0, -1);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(885, 46);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = SystemColors.ControlLightLight;
            lblLoginTitle.Location = new Point(4, 4);
            lblLoginTitle.Margin = new Padding(4, 4, 4, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(217, 37);
            lblLoginTitle.TabIndex = 10;
            lblLoginTitle.Text = "Inicio de Sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userIcon;
            pictureBox1.Location = new Point(96, 252);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.passIcon;
            pictureBox3.Location = new Point(96, 332);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.logInBox;
            pictureBoxLogin.Location = new Point(29, 82);
            pictureBoxLogin.Margin = new Padding(4, 4, 4, 4);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(419, 426);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 5;
            pictureBoxLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(254, 254, 255);
            ClientSize = new Size(885, 536);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxPass);
            Controls.Add(pictureBoxLogin);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FrmLogin";
            Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblLoginTitle;
        public Button btnCerrarVentana;
        public Button btnMinimizarVentana;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxLogin;
    }
}
