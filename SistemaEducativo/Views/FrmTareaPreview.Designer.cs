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
            pictureBox1 = new PictureBox();
            lblExtension = new Label();
            lblPeso = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 73);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtension.Location = new Point(79, 9);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(75, 20);
            lblExtension.TabIndex = 1;
            lblExtension.Text = "extension";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(79, 46);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(41, 20);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "peso";
            // 
            // FrmTareaPreview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(174, 75);
            Controls.Add(lblPeso);
            Controls.Add(lblExtension);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTareaPreview";
            Text = "FrmTareaPreview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pictureBox1;
        public Label lblExtension;
        public Label lblPeso;
    }
}