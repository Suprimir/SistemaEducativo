namespace SistemaEducativo.Views.Alumno
{
    partial class FrmSubmenuAlumno
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblTareasPendientes = new Label();
            lblHora = new Label();
            timerMenu = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gatoAlumno;
            pictureBox1.Location = new Point(36, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 39);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 5;
            label1.Text = "Tareas Pendientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 218);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 6;
            label2.Text = "Hora Actual";
            // 
            // lblTareasPendientes
            // 
            lblTareasPendientes.AutoSize = true;
            lblTareasPendientes.Location = new Point(449, 41);
            lblTareasPendientes.Name = "lblTareasPendientes";
            lblTareasPendientes.Size = new Size(63, 15);
            lblTareasPendientes.TabIndex = 7;
            lblTareasPendientes.Text = "cantTareas";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(449, 220);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(31, 15);
            lblHora.TabIndex = 8;
            lblHora.Text = "hora";
            // 
            // timerMenu
            // 
            timerMenu.Interval = 1000;
            // 
            // FrmSubmenuAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(596, 275);
            Controls.Add(lblHora);
            Controls.Add(lblTareasPendientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSubmenuAlumno";
            Text = "FrmSubmenuAlumno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        public Label lblTareasPendientes;
        public Label lblHora;
        public System.Windows.Forms.Timer timerMenu;
    }
}