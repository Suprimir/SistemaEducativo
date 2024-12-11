namespace SistemaEducativo.Views
{
    partial class FrmConfiguracionPerfil
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
            textBoxContraseñaActual = new TextBox();
            textBoxContraseñaNueva = new TextBox();
            btnActualizarPerfil = new Button();
            btnSubirFoto = new Button();
            pictureBoxPfp = new PictureBox();
            openFileDialogPfp = new OpenFileDialog();
            checkBoxContraseña = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPfp).BeginInit();
            SuspendLayout();
            // 
            // textBoxContraseñaActual
            // 
            textBoxContraseñaActual.BorderStyle = BorderStyle.None;
            textBoxContraseñaActual.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContraseñaActual.Location = new Point(10, 12);
            textBoxContraseñaActual.Name = "textBoxContraseñaActual";
            textBoxContraseñaActual.PlaceholderText = "Contraseña Actual";
            textBoxContraseñaActual.Size = new Size(156, 23);
            textBoxContraseñaActual.TabIndex = 1;
            // 
            // textBoxContraseñaNueva
            // 
            textBoxContraseñaNueva.BorderStyle = BorderStyle.None;
            textBoxContraseñaNueva.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContraseñaNueva.Location = new Point(10, 59);
            textBoxContraseñaNueva.Name = "textBoxContraseñaNueva";
            textBoxContraseñaNueva.PlaceholderText = "Contraseña Nueva";
            textBoxContraseñaNueva.Size = new Size(156, 23);
            textBoxContraseñaNueva.TabIndex = 2;
            // 
            // btnActualizarPerfil
            // 
            btnActualizarPerfil.BackColor = Color.FromArgb(51, 63, 167);
            btnActualizarPerfil.FlatAppearance.BorderSize = 0;
            btnActualizarPerfil.FlatStyle = FlatStyle.Flat;
            btnActualizarPerfil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarPerfil.ForeColor = SystemColors.ControlLightLight;
            btnActualizarPerfil.Location = new Point(209, 141);
            btnActualizarPerfil.Name = "btnActualizarPerfil";
            btnActualizarPerfil.Size = new Size(80, 23);
            btnActualizarPerfil.TabIndex = 3;
            btnActualizarPerfil.Text = "Actualizar";
            btnActualizarPerfil.UseVisualStyleBackColor = false;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.BackColor = Color.White;
            btnSubirFoto.FlatAppearance.BorderSize = 0;
            btnSubirFoto.FlatStyle = FlatStyle.Flat;
            btnSubirFoto.Location = new Point(209, 84);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(75, 23);
            btnSubirFoto.TabIndex = 4;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPfp
            // 
            pictureBoxPfp.BackColor = Color.White;
            pictureBoxPfp.Image = Properties.Resources.userIcon;
            pictureBoxPfp.Location = new Point(209, 12);
            pictureBoxPfp.Name = "pictureBoxPfp";
            pictureBoxPfp.Size = new Size(75, 75);
            pictureBoxPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPfp.TabIndex = 5;
            pictureBoxPfp.TabStop = false;
            // 
            // openFileDialogPfp
            // 
            openFileDialogPfp.FileName = "openFileDialogPfp";
            // 
            // checkBoxContraseña
            // 
            checkBoxContraseña.AutoSize = true;
            checkBoxContraseña.Location = new Point(32, 88);
            checkBoxContraseña.Name = "checkBoxContraseña";
            checkBoxContraseña.Size = new Size(134, 19);
            checkBoxContraseña.TabIndex = 6;
            checkBoxContraseña.Text = "Cambiar Contraseña";
            checkBoxContraseña.UseVisualStyleBackColor = true;
            // 
            // FrmConfiguracionPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(304, 175);
            Controls.Add(checkBoxContraseña);
            Controls.Add(pictureBoxPfp);
            Controls.Add(btnSubirFoto);
            Controls.Add(btnActualizarPerfil);
            Controls.Add(textBoxContraseñaNueva);
            Controls.Add(textBoxContraseñaActual);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmConfiguracionPerfil";
            Text = "Configurar Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPfp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnActualizarPerfil;
        public Button btnSubirFoto;
        public TextBox textBoxContraseñaActual;
        public TextBox textBoxContraseñaNueva;
        public PictureBox pictureBoxPfp;
        public OpenFileDialog openFileDialogPfp;
        public CheckBox checkBoxContraseña;
    }
}