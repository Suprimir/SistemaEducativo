namespace SistemaEducativo.Views
{
    partial class FrmTareaPreview
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
            pictureBoxFileIcon = new PictureBox();
            lblExtension = new Label();
            lblPeso = new Label();
            btnVerArchivo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFileIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFileIcon
            // 
            pictureBoxFileIcon.Location = new Point(12, 7);
            pictureBoxFileIcon.Margin = new Padding(3, 2, 3, 2);
            pictureBoxFileIcon.Name = "pictureBoxFileIcon";
            pictureBoxFileIcon.Size = new Size(39, 42);
            pictureBoxFileIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFileIcon.TabIndex = 0;
            pictureBoxFileIcon.TabStop = false;
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtension.Location = new Point(57, 7);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(58, 15);
            lblExtension.TabIndex = 1;
            lblExtension.Text = "extension";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(57, 34);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "peso";
            // 
            // btnVerArchivo
            // 
            btnVerArchivo.FlatAppearance.BorderSize = 0;
            btnVerArchivo.FlatStyle = FlatStyle.Flat;
            btnVerArchivo.Image = Properties.Resources.searchIcon;
            btnVerArchivo.Location = new Point(129, 34);
            btnVerArchivo.Name = "btnVerArchivo";
            btnVerArchivo.Size = new Size(23, 23);
            btnVerArchivo.TabIndex = 3;
            btnVerArchivo.UseVisualStyleBackColor = true;
            // 
            // FrmTareaPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 255);
            ClientSize = new Size(152, 56);
            Controls.Add(btnVerArchivo);
            Controls.Add(lblPeso);
            Controls.Add(lblExtension);
            Controls.Add(pictureBoxFileIcon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmTareaPreview";
            Text = "FrmTareaPreview";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFileIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBoxFileIcon;
        public Label lblExtension;
        public Label lblPeso;
        public Button btnVerArchivo;
    }
}