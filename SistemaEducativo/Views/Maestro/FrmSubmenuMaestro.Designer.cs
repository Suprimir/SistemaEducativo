namespace SistemaEducativo.Views.Maestro
{
    partial class FrmSubmenuMaestro
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
            lblGruposAsignados = new Label();
            lblCantGruposStatic = new Label();
            label1 = new Label();
            lblTareasPendientes = new Label();
            lblHora = new Label();
            label2 = new Label();
            timerMenu = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BuhoSubmenuMaestro;
            pictureBox1.Location = new Point(29, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblGruposAsignados
            // 
            lblGruposAsignados.AutoSize = true;
            lblGruposAsignados.Location = new Point(442, 42);
            lblGruposAsignados.Name = "lblGruposAsignados";
            lblGruposAsignados.Size = new Size(68, 15);
            lblGruposAsignados.TabIndex = 1;
            lblGruposAsignados.Text = "cantGrupos";
            // 
            // lblCantGruposStatic
            // 
            lblCantGruposStatic.AutoSize = true;
            lblCantGruposStatic.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantGruposStatic.Location = new Point(229, 40);
            lblCantGruposStatic.Name = "lblCantGruposStatic";
            lblCantGruposStatic.Size = new Size(122, 17);
            lblCantGruposStatic.TabIndex = 2;
            lblCantGruposStatic.Text = "Grupos Asignados:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 71);
            label1.Name = "label1";
            label1.Size = new Size(193, 17);
            label1.TabIndex = 3;
            label1.Text = "Tareas Pendientes por Revisar:";
            // 
            // lblTareasPendientes
            // 
            lblTareasPendientes.AutoSize = true;
            lblTareasPendientes.Location = new Point(442, 73);
            lblTareasPendientes.Name = "lblTareasPendientes";
            lblTareasPendientes.Size = new Size(63, 15);
            lblTareasPendientes.TabIndex = 4;
            lblTareasPendientes.Text = "cantTareas";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(442, 229);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(31, 15);
            lblHora.TabIndex = 16;
            lblHora.Text = "hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 227);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 15;
            label2.Text = "Hora Actual";
            // 
            // timerMenu
            // 
            timerMenu.Interval = 1000;
            // 
            // FrmSubmenuMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(596, 275);
            Controls.Add(lblHora);
            Controls.Add(label2);
            Controls.Add(lblTareasPendientes);
            Controls.Add(label1);
            Controls.Add(lblCantGruposStatic);
            Controls.Add(lblGruposAsignados);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSubmenuMaestro";
            Text = "FrmSubmenuMaestro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCantGruposStatic;
        private Label label1;
        public Label lblTareasPendientes;
        public Label lblGruposAsignados;
        public Label lblHora;
        private Label label2;
        public System.Windows.Forms.Timer timerMenu;
    }
}