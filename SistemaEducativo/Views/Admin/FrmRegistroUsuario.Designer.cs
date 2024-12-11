namespace SistemaEducativo.Views.Admin
{
    partial class FrmRegistroUsuario
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
            lblMatriculaStatic = new Label();
            textBoxMatricula = new TextBox();
            checkBoxMatricula = new CheckBox();
            lblContraseñaStatic = new Label();
            textBoxContraseña = new TextBox();
            checkBoxContraseña = new CheckBox();
            lblNombreStatic = new Label();
            textBoxNombre = new TextBox();
            lblApellidoPStatic = new Label();
            lblApellidoMStatic = new Label();
            textBoxApellidoP = new TextBox();
            textBoxApellidoM = new TextBox();
            lblCorreoStatic = new Label();
            textBoxCorreo = new TextBox();
            checkBoxCorreo = new CheckBox();
            comboBoxRol = new ComboBox();
            lblRolStatic = new Label();
            comboBoxGrupo = new ComboBox();
            lblAsignarGStatic = new Label();
            btnRegistrarUsuario = new Button();
            btnSubirFoto = new Button();
            pictureBoxPfp = new PictureBox();
            openFileDialogPfp = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPfp).BeginInit();
            SuspendLayout();
            // 
            // lblMatriculaStatic
            // 
            lblMatriculaStatic.AutoSize = true;
            lblMatriculaStatic.Location = new Point(32, 98);
            lblMatriculaStatic.Margin = new Padding(4, 0, 4, 0);
            lblMatriculaStatic.Name = "lblMatriculaStatic";
            lblMatriculaStatic.Size = new Size(71, 20);
            lblMatriculaStatic.TabIndex = 0;
            lblMatriculaStatic.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(122, 94);
            textBoxMatricula.Margin = new Padding(4, 4, 4, 4);
            textBoxMatricula.MaxLength = 10;
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(159, 27);
            textBoxMatricula.TabIndex = 1;
            // 
            // checkBoxMatricula
            // 
            checkBoxMatricula.AutoSize = true;
            checkBoxMatricula.Location = new Point(202, 125);
            checkBoxMatricula.Margin = new Padding(4, 4, 4, 4);
            checkBoxMatricula.Name = "checkBoxMatricula";
            checkBoxMatricula.Size = new Size(80, 24);
            checkBoxMatricula.TabIndex = 2;
            checkBoxMatricula.Text = "Default";
            checkBoxMatricula.UseVisualStyleBackColor = true;
            // 
            // lblContraseñaStatic
            // 
            lblContraseñaStatic.AutoSize = true;
            lblContraseñaStatic.Location = new Point(32, 162);
            lblContraseñaStatic.Margin = new Padding(4, 0, 4, 0);
            lblContraseñaStatic.Name = "lblContraseñaStatic";
            lblContraseñaStatic.Size = new Size(83, 20);
            lblContraseñaStatic.TabIndex = 3;
            lblContraseñaStatic.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(122, 159);
            textBoxContraseña.Margin = new Padding(4, 4, 4, 4);
            textBoxContraseña.MaxLength = 50;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(159, 27);
            textBoxContraseña.TabIndex = 4;
            // 
            // checkBoxContraseña
            // 
            checkBoxContraseña.AutoSize = true;
            checkBoxContraseña.Location = new Point(202, 195);
            checkBoxContraseña.Margin = new Padding(4, 4, 4, 4);
            checkBoxContraseña.Name = "checkBoxContraseña";
            checkBoxContraseña.Size = new Size(80, 24);
            checkBoxContraseña.TabIndex = 5;
            checkBoxContraseña.Text = "Default";
            checkBoxContraseña.UseVisualStyleBackColor = true;
            // 
            // lblNombreStatic
            // 
            lblNombreStatic.AutoSize = true;
            lblNombreStatic.Location = new Point(32, 25);
            lblNombreStatic.Margin = new Padding(4, 0, 4, 0);
            lblNombreStatic.Name = "lblNombreStatic";
            lblNombreStatic.Size = new Size(64, 20);
            lblNombreStatic.TabIndex = 6;
            lblNombreStatic.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(32, 48);
            textBoxNombre.Margin = new Padding(4, 4, 4, 4);
            textBoxNombre.MaxLength = 50;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(178, 27);
            textBoxNombre.TabIndex = 7;
            // 
            // lblApellidoPStatic
            // 
            lblApellidoPStatic.AutoSize = true;
            lblApellidoPStatic.Location = new Point(219, 25);
            lblApellidoPStatic.Margin = new Padding(4, 0, 4, 0);
            lblApellidoPStatic.Name = "lblApellidoPStatic";
            lblApellidoPStatic.Size = new Size(120, 20);
            lblApellidoPStatic.TabIndex = 8;
            lblApellidoPStatic.Text = "Apellido Paterno";
            // 
            // lblApellidoMStatic
            // 
            lblApellidoMStatic.AutoSize = true;
            lblApellidoMStatic.Location = new Point(351, 25);
            lblApellidoMStatic.Margin = new Padding(4, 0, 4, 0);
            lblApellidoMStatic.Name = "lblApellidoMStatic";
            lblApellidoMStatic.Size = new Size(126, 20);
            lblApellidoMStatic.TabIndex = 9;
            lblApellidoMStatic.Text = "Apellido Materno";
            // 
            // textBoxApellidoP
            // 
            textBoxApellidoP.Location = new Point(219, 48);
            textBoxApellidoP.Margin = new Padding(4, 4, 4, 4);
            textBoxApellidoP.MaxLength = 30;
            textBoxApellidoP.Name = "textBoxApellidoP";
            textBoxApellidoP.Size = new Size(124, 27);
            textBoxApellidoP.TabIndex = 10;
            // 
            // textBoxApellidoM
            // 
            textBoxApellidoM.Location = new Point(351, 48);
            textBoxApellidoM.Margin = new Padding(4, 4, 4, 4);
            textBoxApellidoM.MaxLength = 30;
            textBoxApellidoM.Name = "textBoxApellidoM";
            textBoxApellidoM.Size = new Size(124, 27);
            textBoxApellidoM.TabIndex = 11;
            // 
            // lblCorreoStatic
            // 
            lblCorreoStatic.AutoSize = true;
            lblCorreoStatic.Location = new Point(32, 234);
            lblCorreoStatic.Margin = new Padding(4, 0, 4, 0);
            lblCorreoStatic.Name = "lblCorreoStatic";
            lblCorreoStatic.Size = new Size(54, 20);
            lblCorreoStatic.TabIndex = 12;
            lblCorreoStatic.Text = "Correo";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(32, 256);
            textBoxCorreo.Margin = new Padding(4, 4, 4, 4);
            textBoxCorreo.MaxLength = 50;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(249, 27);
            textBoxCorreo.TabIndex = 13;
            // 
            // checkBoxCorreo
            // 
            checkBoxCorreo.AutoSize = true;
            checkBoxCorreo.Location = new Point(32, 292);
            checkBoxCorreo.Margin = new Padding(4, 4, 4, 4);
            checkBoxCorreo.Name = "checkBoxCorreo";
            checkBoxCorreo.Size = new Size(80, 24);
            checkBoxCorreo.TabIndex = 14;
            checkBoxCorreo.Text = "Default";
            checkBoxCorreo.UseVisualStyleBackColor = true;
            // 
            // comboBoxRol
            // 
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "alumno", "maestro", "admin" });
            comboBoxRol.Location = new Point(350, 256);
            comboBoxRol.Margin = new Padding(4, 4, 4, 4);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(123, 28);
            comboBoxRol.TabIndex = 15;
            // 
            // lblRolStatic
            // 
            lblRolStatic.AutoSize = true;
            lblRolStatic.Location = new Point(350, 234);
            lblRolStatic.Margin = new Padding(4, 0, 4, 0);
            lblRolStatic.Name = "lblRolStatic";
            lblRolStatic.Size = new Size(31, 20);
            lblRolStatic.TabIndex = 16;
            lblRolStatic.Text = "Rol";
            // 
            // comboBoxGrupo
            // 
            comboBoxGrupo.FormattingEnabled = true;
            comboBoxGrupo.Location = new Point(350, 325);
            comboBoxGrupo.Margin = new Padding(4, 4, 4, 4);
            comboBoxGrupo.Name = "comboBoxGrupo";
            comboBoxGrupo.Size = new Size(124, 28);
            comboBoxGrupo.TabIndex = 17;
            // 
            // lblAsignarGStatic
            // 
            lblAsignarGStatic.AutoSize = true;
            lblAsignarGStatic.Location = new Point(350, 302);
            lblAsignarGStatic.Margin = new Padding(4, 0, 4, 0);
            lblAsignarGStatic.Name = "lblAsignarGStatic";
            lblAsignarGStatic.Size = new Size(110, 20);
            lblAsignarGStatic.TabIndex = 18;
            lblAsignarGStatic.Text = "Asignar Grupos";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(32, 325);
            btnRegistrarUsuario.Margin = new Padding(4, 4, 4, 4);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(250, 29);
            btnRegistrarUsuario.TabIndex = 19;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Location = new Point(350, 192);
            btnSubirFoto.Margin = new Padding(4, 4, 4, 4);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(124, 29);
            btnSubirFoto.TabIndex = 20;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPfp
            // 
            pictureBoxPfp.Image = Properties.Resources.userIcon;
            pictureBoxPfp.Location = new Point(361, 94);
            pictureBoxPfp.Margin = new Padding(4, 4, 4, 4);
            pictureBoxPfp.Name = "pictureBoxPfp";
            pictureBoxPfp.Size = new Size(100, 100);
            pictureBoxPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPfp.TabIndex = 21;
            pictureBoxPfp.TabStop = false;
            // 
            // FrmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(515, 380);
            Controls.Add(pictureBoxPfp);
            Controls.Add(btnSubirFoto);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(lblAsignarGStatic);
            Controls.Add(comboBoxGrupo);
            Controls.Add(lblRolStatic);
            Controls.Add(comboBoxRol);
            Controls.Add(checkBoxCorreo);
            Controls.Add(textBoxCorreo);
            Controls.Add(lblCorreoStatic);
            Controls.Add(textBoxApellidoM);
            Controls.Add(textBoxApellidoP);
            Controls.Add(lblApellidoMStatic);
            Controls.Add(lblApellidoPStatic);
            Controls.Add(textBoxNombre);
            Controls.Add(lblNombreStatic);
            Controls.Add(checkBoxContraseña);
            Controls.Add(textBoxContraseña);
            Controls.Add(lblContraseñaStatic);
            Controls.Add(checkBoxMatricula);
            Controls.Add(textBoxMatricula);
            Controls.Add(lblMatriculaStatic);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmRegistroUsuario";
            Text = "FrmRegistroUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPfp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMatriculaStatic;
        private Label lblContraseñaStatic;
        private Label lblNombreStatic;
        private Label lblApellidoPStatic;
        private Label lblApellidoMStatic;
        private Label lblCorreoStatic;
        private Label lblRolStatic;
        public TextBox textBoxNombre;
        public TextBox textBoxApellidoP;
        public TextBox textBoxApellidoM;
        public TextBox textBoxMatricula;
        public CheckBox checkBoxMatricula;
        public TextBox textBoxContraseña;
        public CheckBox checkBoxContraseña;
        public TextBox textBoxCorreo;
        public ComboBox comboBoxRol;
        public ComboBox comboBoxGrupo;
        public Button btnRegistrarUsuario;
        public CheckBox checkBoxCorreo;
        public Label lblAsignarGStatic;
        public PictureBox pictureBoxPfp;
        public Button btnSubirFoto;
        public OpenFileDialog openFileDialogPfp;
    }
}