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
            lblContraseñaStatic = new Label();
            textBoxContraseña = new TextBox();
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
            lblMatriculaStatic.Location = new Point(12, 66);
            lblMatriculaStatic.Name = "lblMatriculaStatic";
            lblMatriculaStatic.Size = new Size(57, 15);
            lblMatriculaStatic.TabIndex = 0;
            lblMatriculaStatic.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.BorderStyle = BorderStyle.None;
            textBoxMatricula.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMatricula.Location = new Point(12, 84);
            textBoxMatricula.MaxLength = 10;
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(143, 23);
            textBoxMatricula.TabIndex = 1;
            // 
            // lblContraseñaStatic
            // 
            lblContraseñaStatic.AutoSize = true;
            lblContraseñaStatic.Location = new Point(12, 119);
            lblContraseñaStatic.Name = "lblContraseñaStatic";
            lblContraseñaStatic.Size = new Size(67, 15);
            lblContraseñaStatic.TabIndex = 3;
            lblContraseñaStatic.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BorderStyle = BorderStyle.None;
            textBoxContraseña.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContraseña.Location = new Point(12, 137);
            textBoxContraseña.MaxLength = 50;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(143, 23);
            textBoxContraseña.TabIndex = 4;
            // 
            // lblNombreStatic
            // 
            lblNombreStatic.AutoSize = true;
            lblNombreStatic.Location = new Point(12, 11);
            lblNombreStatic.Name = "lblNombreStatic";
            lblNombreStatic.Size = new Size(51, 15);
            lblNombreStatic.TabIndex = 6;
            lblNombreStatic.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.None;
            textBoxNombre.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(12, 29);
            textBoxNombre.MaxLength = 50;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(143, 23);
            textBoxNombre.TabIndex = 7;
            // 
            // lblApellidoPStatic
            // 
            lblApellidoPStatic.AutoSize = true;
            lblApellidoPStatic.Location = new Point(162, 11);
            lblApellidoPStatic.Name = "lblApellidoPStatic";
            lblApellidoPStatic.Size = new Size(69, 15);
            lblApellidoPStatic.TabIndex = 8;
            lblApellidoPStatic.Text = "Ap. Paterno";
            // 
            // lblApellidoMStatic
            // 
            lblApellidoMStatic.AutoSize = true;
            lblApellidoMStatic.Location = new Point(268, 11);
            lblApellidoMStatic.Name = "lblApellidoMStatic";
            lblApellidoMStatic.Size = new Size(73, 15);
            lblApellidoMStatic.TabIndex = 9;
            lblApellidoMStatic.Text = "Ap. Materno";
            // 
            // textBoxApellidoP
            // 
            textBoxApellidoP.BorderStyle = BorderStyle.None;
            textBoxApellidoP.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApellidoP.Location = new Point(162, 29);
            textBoxApellidoP.MaxLength = 30;
            textBoxApellidoP.Name = "textBoxApellidoP";
            textBoxApellidoP.Size = new Size(100, 23);
            textBoxApellidoP.TabIndex = 10;
            // 
            // textBoxApellidoM
            // 
            textBoxApellidoM.BorderStyle = BorderStyle.None;
            textBoxApellidoM.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApellidoM.Location = new Point(268, 29);
            textBoxApellidoM.MaxLength = 30;
            textBoxApellidoM.Name = "textBoxApellidoM";
            textBoxApellidoM.Size = new Size(100, 23);
            textBoxApellidoM.TabIndex = 11;
            // 
            // lblCorreoStatic
            // 
            lblCorreoStatic.AutoSize = true;
            lblCorreoStatic.Location = new Point(12, 178);
            lblCorreoStatic.Name = "lblCorreoStatic";
            lblCorreoStatic.Size = new Size(43, 15);
            lblCorreoStatic.TabIndex = 12;
            lblCorreoStatic.Text = "Correo";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCorreo.Location = new Point(12, 196);
            textBoxCorreo.MaxLength = 50;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(200, 23);
            textBoxCorreo.TabIndex = 13;
            // 
            // checkBoxCorreo
            // 
            checkBoxCorreo.AutoSize = true;
            checkBoxCorreo.Checked = true;
            checkBoxCorreo.CheckState = CheckState.Checked;
            checkBoxCorreo.Location = new Point(15, 225);
            checkBoxCorreo.Name = "checkBoxCorreo";
            checkBoxCorreo.Size = new Size(64, 19);
            checkBoxCorreo.TabIndex = 14;
            checkBoxCorreo.Text = "Default";
            checkBoxCorreo.UseVisualStyleBackColor = true;
            // 
            // comboBoxRol
            // 
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FlatStyle = FlatStyle.Flat;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Alumno", "Maestro", "Admin" });
            comboBoxRol.Location = new Point(268, 196);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(99, 23);
            comboBoxRol.TabIndex = 15;
            // 
            // lblRolStatic
            // 
            lblRolStatic.AutoSize = true;
            lblRolStatic.Location = new Point(268, 178);
            lblRolStatic.Name = "lblRolStatic";
            lblRolStatic.Size = new Size(24, 15);
            lblRolStatic.TabIndex = 16;
            lblRolStatic.Text = "Rol";
            // 
            // comboBoxGrupo
            // 
            comboBoxGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrupo.FlatStyle = FlatStyle.Flat;
            comboBoxGrupo.FormattingEnabled = true;
            comboBoxGrupo.Location = new Point(268, 260);
            comboBoxGrupo.Name = "comboBoxGrupo";
            comboBoxGrupo.Size = new Size(100, 23);
            comboBoxGrupo.TabIndex = 17;
            // 
            // lblAsignarGStatic
            // 
            lblAsignarGStatic.AutoSize = true;
            lblAsignarGStatic.Location = new Point(268, 242);
            lblAsignarGStatic.Name = "lblAsignarGStatic";
            lblAsignarGStatic.Size = new Size(88, 15);
            lblAsignarGStatic.TabIndex = 18;
            lblAsignarGStatic.Text = "Asignar Grupos";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = Color.FromArgb(51, 63, 167);
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarUsuario.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarUsuario.Location = new Point(10, 260);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(200, 23);
            btnRegistrarUsuario.TabIndex = 19;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.BackColor = Color.White;
            btnSubirFoto.FlatAppearance.BorderSize = 0;
            btnSubirFoto.FlatStyle = FlatStyle.Flat;
            btnSubirFoto.Location = new Point(268, 137);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(100, 23);
            btnSubirFoto.TabIndex = 20;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPfp
            // 
            pictureBoxPfp.BackColor = Color.White;
            pictureBoxPfp.Image = Properties.Resources.userIcon;
            pictureBoxPfp.Location = new Point(281, 63);
            pictureBoxPfp.Name = "pictureBoxPfp";
            pictureBoxPfp.Size = new Size(75, 75);
            pictureBoxPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPfp.TabIndex = 21;
            pictureBoxPfp.TabStop = false;
            // 
            // FrmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(394, 304);
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
            Controls.Add(textBoxContraseña);
            Controls.Add(lblContraseñaStatic);
            Controls.Add(textBoxMatricula);
            Controls.Add(lblMatriculaStatic);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmRegistroUsuario";
            Text = "Registrar Usuario";
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
        public TextBox textBoxContraseña;
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