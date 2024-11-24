namespace SistemaEducativo.Views.Maestro
{
    partial class FrmRegistroGeneracion
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
            comboBoxCarreras = new ComboBox();
            lblCarreraStatic = new Label();
            btnRegistrar = new Button();
            textBoxNombreGeneracion = new TextBox();
            SuspendLayout();
            // 
            // comboBoxCarreras
            // 
            comboBoxCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarreras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCarreras.FormattingEnabled = true;
            comboBoxCarreras.Location = new Point(51, 91);
            comboBoxCarreras.Name = "comboBoxCarreras";
            comboBoxCarreras.Size = new Size(134, 29);
            comboBoxCarreras.TabIndex = 0;
            // 
            // lblCarreraStatic
            // 
            lblCarreraStatic.AutoSize = true;
            lblCarreraStatic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarreraStatic.Location = new Point(51, 64);
            lblCarreraStatic.Name = "lblCarreraStatic";
            lblCarreraStatic.Size = new Size(62, 21);
            lblCarreraStatic.TabIndex = 1;
            lblCarreraStatic.Text = "Carrera";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(110, 165);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreGeneracion
            // 
            textBoxNombreGeneracion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreGeneracion.Location = new Point(51, 126);
            textBoxNombreGeneracion.Name = "textBoxNombreGeneracion";
            textBoxNombreGeneracion.Size = new Size(134, 29);
            textBoxNombreGeneracion.TabIndex = 3;
            // 
            // FrmRegistroGeneracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNombreGeneracion);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCarreraStatic);
            Controls.Add(comboBoxCarreras);
            Name = "FrmRegistroGeneracion";
            Text = "FrmRegistroGeneracion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox comboBoxCarreras;
        private Label lblCarreraStatic;
        public Button btnRegistrar;
        public TextBox textBoxNombreGeneracion;
    }
}