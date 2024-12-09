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
            textBoxContraseñaActual.Location = new Point(12, 37);
            textBoxContraseñaActual.Name = "textBoxContraseñaActual";
            textBoxContraseñaActual.PlaceholderText = "Contraseña Actual";
            textBoxContraseñaActual.Size = new Size(134, 23);
            textBoxContraseñaActual.TabIndex = 1;
            // 
            // textBoxContraseñaNueva
            // 
            textBoxContraseñaNueva.Location = new Point(12, 75);
            textBoxContraseñaNueva.Name = "textBoxContraseñaNueva";
            textBoxContraseñaNueva.PlaceholderText = "Contraseña Nueva";
            textBoxContraseñaNueva.Size = new Size(134, 23);
            textBoxContraseñaNueva.TabIndex = 2;
            // 
            // btnActualizarPerfil
            // 
            btnActualizarPerfil.Location = new Point(12, 136);
            btnActualizarPerfil.Name = "btnActualizarPerfil";
            btnActualizarPerfil.Size = new Size(233, 23);
            btnActualizarPerfil.TabIndex = 3;
            btnActualizarPerfil.Text = "Actualizar";
            btnActualizarPerfil.UseVisualStyleBackColor = true;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Location = new Point(170, 90);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(75, 23);
            btnSubirFoto.TabIndex = 4;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPfp
            // 
            pictureBoxPfp.Image = Properties.Resources.userIcon;
            pictureBoxPfp.Location = new Point(170, 9);
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
            checkBoxContraseña.Location = new Point(12, 12);
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
            ClientSize = new Size(257, 171);
            Controls.Add(checkBoxContraseña);
            Controls.Add(pictureBoxPfp);
            Controls.Add(btnSubirFoto);
            Controls.Add(btnActualizarPerfil);
            Controls.Add(textBoxContraseñaNueva);
            Controls.Add(textBoxContraseñaActual);
            Name = "FrmConfiguracionPerfil";
            Text = "FrmConfiguracionPerfil";
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