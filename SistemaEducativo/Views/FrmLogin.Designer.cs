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
            pictureBox1 = new PictureBox();
            textBoxUsuario = new TextBox();
            textBoxPass = new TextBox();
            btnIniciarSesion = new Button();
            lblUsuarioStatic = new Label();
            lblPassStatic = new Label();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCerrarVentana = new Button();
            btnMinimizarVentana = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.borderLogin;
            pictureBox1.Location = new Point(-3, 46);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 362);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsuario.Location = new Point(198, 115);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(228, 34);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.Location = new Point(198, 188);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(228, 34);
            textBoxPass.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(281, 255);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(145, 38);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioStatic
            // 
            lblUsuarioStatic.AutoSize = true;
            lblUsuarioStatic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioStatic.Location = new Point(74, 121);
            lblUsuarioStatic.Name = "lblUsuarioStatic";
            lblUsuarioStatic.Size = new Size(84, 28);
            lblUsuarioStatic.TabIndex = 4;
            lblUsuarioStatic.Text = "Usuario";
            // 
            // lblPassStatic
            // 
            lblPassStatic.AutoSize = true;
            lblPassStatic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassStatic.Location = new Point(74, 191);
            lblPassStatic.Name = "lblPassStatic";
            lblPassStatic.Size = new Size(118, 28);
            lblPassStatic.TabIndex = 5;
            lblPassStatic.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.gatoTrono;
            pictureBox2.Location = new Point(457, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 245);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.HotTrack;
            flowLayoutPanel1.Controls.Add(btnCerrarVentana);
            flowLayoutPanel1.Controls.Add(btnMinimizarVentana);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(-3, -1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(744, 47);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // btnCerrarVentana
            // 
            btnCerrarVentana.Location = new Point(700, 3);
            btnCerrarVentana.Name = "btnCerrarVentana";
            btnCerrarVentana.Size = new Size(41, 41);
            btnCerrarVentana.TabIndex = 0;
            btnCerrarVentana.Text = "X";
            btnCerrarVentana.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarVentana
            // 
            btnMinimizarVentana.Location = new Point(653, 3);
            btnMinimizarVentana.Name = "btnMinimizarVentana";
            btnMinimizarVentana.Size = new Size(41, 41);
            btnMinimizarVentana.TabIndex = 1;
            btnMinimizarVentana.Text = "-";
            btnMinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(739, 404);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(lblPassStatic);
            Controls.Add(lblUsuarioStatic);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUsuario);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUsuarioStatic;
        private Label lblPassStatic;
        public TextBox textBoxUsuario;
        public TextBox textBoxPass;
        public Button btnIniciarSesion;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnCerrarVentana;
        public Button btnMinimizarVentana;
    }
}
