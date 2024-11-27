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
            SuspendLayout();
            // 
            // lblMatriculaStatic
            // 
            lblMatriculaStatic.AutoSize = true;
            lblMatriculaStatic.Location = new Point(26, 88);
            lblMatriculaStatic.Name = "lblMatriculaStatic";
            lblMatriculaStatic.Size = new Size(57, 15);
            lblMatriculaStatic.TabIndex = 0;
            lblMatriculaStatic.Text = "Matricula";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(124, 85);
            textBoxMatricula.MaxLength = 10;
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(128, 23);
            textBoxMatricula.TabIndex = 1;
            // 
            // checkBoxMatricula
            // 
            checkBoxMatricula.AutoSize = true;
            checkBoxMatricula.Location = new Point(281, 87);
            checkBoxMatricula.Name = "checkBoxMatricula";
            checkBoxMatricula.Size = new Size(64, 19);
            checkBoxMatricula.TabIndex = 2;
            checkBoxMatricula.Text = "Default";
            checkBoxMatricula.UseVisualStyleBackColor = true;
            // 
            // lblContraseñaStatic
            // 
            lblContraseñaStatic.AutoSize = true;
            lblContraseñaStatic.Location = new Point(26, 121);
            lblContraseñaStatic.Name = "lblContraseñaStatic";
            lblContraseñaStatic.Size = new Size(67, 15);
            lblContraseñaStatic.TabIndex = 3;
            lblContraseñaStatic.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(124, 118);
            textBoxContraseña.MaxLength = 50;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(128, 23);
            textBoxContraseña.TabIndex = 4;
            // 
            // checkBoxContraseña
            // 
            checkBoxContraseña.AutoSize = true;
            checkBoxContraseña.Location = new Point(281, 121);
            checkBoxContraseña.Name = "checkBoxContraseña";
            checkBoxContraseña.Size = new Size(64, 19);
            checkBoxContraseña.TabIndex = 5;
            checkBoxContraseña.Text = "Default";
            checkBoxContraseña.UseVisualStyleBackColor = true;
            // 
            // lblNombreStatic
            // 
            lblNombreStatic.AutoSize = true;
            lblNombreStatic.Location = new Point(26, 20);
            lblNombreStatic.Name = "lblNombreStatic";
            lblNombreStatic.Size = new Size(51, 15);
            lblNombreStatic.TabIndex = 6;
            lblNombreStatic.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(26, 38);
            textBoxNombre.MaxLength = 50;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(143, 23);
            textBoxNombre.TabIndex = 7;
            // 
            // lblApellidoPStatic
            // 
            lblApellidoPStatic.AutoSize = true;
            lblApellidoPStatic.Location = new Point(175, 20);
            lblApellidoPStatic.Name = "lblApellidoPStatic";
            lblApellidoPStatic.Size = new Size(95, 15);
            lblApellidoPStatic.TabIndex = 8;
            lblApellidoPStatic.Text = "Apellido Paterno";
            // 
            // lblApellidoMStatic
            // 
            lblApellidoMStatic.AutoSize = true;
            lblApellidoMStatic.Location = new Point(281, 20);
            lblApellidoMStatic.Name = "lblApellidoMStatic";
            lblApellidoMStatic.Size = new Size(99, 15);
            lblApellidoMStatic.TabIndex = 9;
            lblApellidoMStatic.Text = "Apellido Materno";
            // 
            // textBoxApellidoP
            // 
            textBoxApellidoP.Location = new Point(175, 38);
            textBoxApellidoP.MaxLength = 30;
            textBoxApellidoP.Name = "textBoxApellidoP";
            textBoxApellidoP.Size = new Size(100, 23);
            textBoxApellidoP.TabIndex = 10;
            // 
            // textBoxApellidoM
            // 
            textBoxApellidoM.Location = new Point(281, 38);
            textBoxApellidoM.MaxLength = 30;
            textBoxApellidoM.Name = "textBoxApellidoM";
            textBoxApellidoM.Size = new Size(100, 23);
            textBoxApellidoM.TabIndex = 11;
            // 
            // lblCorreoStatic
            // 
            lblCorreoStatic.AutoSize = true;
            lblCorreoStatic.Location = new Point(26, 169);
            lblCorreoStatic.Name = "lblCorreoStatic";
            lblCorreoStatic.Size = new Size(43, 15);
            lblCorreoStatic.TabIndex = 12;
            lblCorreoStatic.Text = "Correo";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(26, 187);
            textBoxCorreo.MaxLength = 50;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(200, 23);
            textBoxCorreo.TabIndex = 13;
            // 
            // checkBoxCorreo
            // 
            checkBoxCorreo.AutoSize = true;
            checkBoxCorreo.Location = new Point(26, 216);
            checkBoxCorreo.Name = "checkBoxCorreo";
            checkBoxCorreo.Size = new Size(64, 19);
            checkBoxCorreo.TabIndex = 14;
            checkBoxCorreo.Text = "Default";
            checkBoxCorreo.UseVisualStyleBackColor = true;
            // 
            // comboBoxRol
            // 
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "alumno", "maestro", "admin" });
            comboBoxRol.Location = new Point(281, 187);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(99, 23);
            comboBoxRol.TabIndex = 15;
            // 
            // lblRolStatic
            // 
            lblRolStatic.AutoSize = true;
            lblRolStatic.Location = new Point(281, 169);
            lblRolStatic.Name = "lblRolStatic";
            lblRolStatic.Size = new Size(24, 15);
            lblRolStatic.TabIndex = 16;
            lblRolStatic.Text = "Rol";
            // 
            // comboBoxGrupo
            // 
            comboBoxGrupo.FormattingEnabled = true;
            comboBoxGrupo.Location = new Point(281, 242);
            comboBoxGrupo.Name = "comboBoxGrupo";
            comboBoxGrupo.Size = new Size(100, 23);
            comboBoxGrupo.TabIndex = 17;
            // 
            // lblAsignarGStatic
            // 
            lblAsignarGStatic.AutoSize = true;
            lblAsignarGStatic.Location = new Point(281, 224);
            lblAsignarGStatic.Name = "lblAsignarGStatic";
            lblAsignarGStatic.Size = new Size(88, 15);
            lblAsignarGStatic.TabIndex = 18;
            lblAsignarGStatic.Text = "Asignar Grupos";
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(26, 242);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(200, 23);
            btnRegistrarUsuario.TabIndex = 19;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(412, 289);
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
            Name = "FrmRegistroUsuario";
            Text = "FrmRegistroUsuario";
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
        private Label lblAsignarGStatic;
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
    }
}