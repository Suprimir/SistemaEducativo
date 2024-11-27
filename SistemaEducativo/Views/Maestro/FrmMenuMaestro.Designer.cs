namespace SistemaEducativo.Views.Maestro
{
    partial class FrmMenuMaestro
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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblMenuTitle = new Label();
            btnCerrarVentana = new Button();
            btnMinimizarVentana = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblRol = new Label();
            lblRolStatic = new Label();
            lblUsuario = new Label();
            lblUsuarioStatic = new Label();
            pictureBoxMPfp = new PictureBox();
            btnGestionTareas = new Button();
            dataGridViewGrupos = new DataGridView();
            lblGruposStatic = new Label();
            dataGridViewTareas = new DataGridView();
            label1 = new Label();
            btnCerrarSesion = new Button();
            btnConfigurarPerfil = new Button();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 717F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Controls.Add(lblMenuTitle, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCerrarVentana, 2, 0);
            tableLayoutPanel2.Controls.Add(btnMinimizarVentana, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(775, 37);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuTitle.Location = new Point(3, 3);
            lblMenuTitle.Margin = new Padding(3, 3, 3, 0);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(70, 30);
            lblMenuTitle.TabIndex = 10;
            lblMenuTitle.Text = "Menú";
            // 
            // btnCerrarVentana
            // 
            btnCerrarVentana.FlatAppearance.BorderSize = 0;
            btnCerrarVentana.FlatStyle = FlatStyle.Flat;
            btnCerrarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarVentana.Location = new Point(746, 0);
            btnCerrarVentana.Margin = new Padding(0);
            btnCerrarVentana.Name = "btnCerrarVentana";
            btnCerrarVentana.Size = new Size(29, 37);
            btnCerrarVentana.TabIndex = 0;
            btnCerrarVentana.Text = "X";
            btnCerrarVentana.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarVentana
            // 
            btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            btnMinimizarVentana.FlatStyle = FlatStyle.Flat;
            btnMinimizarVentana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizarVentana.Location = new Point(717, 0);
            btnMinimizarVentana.Margin = new Padding(0);
            btnMinimizarVentana.Name = "btnMinimizarVentana";
            btnMinimizarVentana.Size = new Size(29, 37);
            btnMinimizarVentana.TabIndex = 8;
            btnMinimizarVentana.Text = "-";
            btnMinimizarVentana.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel3);
            flowLayoutPanel1.Controls.Add(pictureBoxMPfp);
            flowLayoutPanel1.Location = new Point(20, 47);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(204, 65);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblRol, 1, 1);
            tableLayoutPanel3.Controls.Add(lblRolStatic, 0, 1);
            tableLayoutPanel3.Controls.Add(lblUsuario, 1, 0);
            tableLayoutPanel3.Controls.Add(lblUsuarioStatic, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(141, 52);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Dock = DockStyle.Fill;
            lblRol.Location = new Point(73, 26);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(65, 26);
            lblRol.TabIndex = 11;
            lblRol.Text = "rol";
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRolStatic
            // 
            lblRolStatic.AutoSize = true;
            lblRolStatic.Dock = DockStyle.Fill;
            lblRolStatic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolStatic.Location = new Point(3, 26);
            lblRolStatic.Name = "lblRolStatic";
            lblRolStatic.Size = new Size(64, 26);
            lblRolStatic.TabIndex = 11;
            lblRolStatic.Text = "Rol:";
            lblRolStatic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Location = new Point(73, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(65, 26);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioStatic
            // 
            lblUsuarioStatic.AutoSize = true;
            lblUsuarioStatic.Dock = DockStyle.Fill;
            lblUsuarioStatic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioStatic.Location = new Point(3, 0);
            lblUsuarioStatic.Name = "lblUsuarioStatic";
            lblUsuarioStatic.Size = new Size(64, 26);
            lblUsuarioStatic.TabIndex = 12;
            lblUsuarioStatic.Text = "Usuario:";
            lblUsuarioStatic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMPfp
            // 
            pictureBoxMPfp.Image = Properties.Resources.maestroPfp;
            pictureBoxMPfp.Location = new Point(141, 0);
            pictureBoxMPfp.Margin = new Padding(0);
            pictureBoxMPfp.Name = "pictureBoxMPfp";
            pictureBoxMPfp.Size = new Size(63, 64);
            pictureBoxMPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMPfp.TabIndex = 11;
            pictureBoxMPfp.TabStop = false;
            // 
            // btnGestionTareas
            // 
            btnGestionTareas.Location = new Point(20, 126);
            btnGestionTareas.Name = "btnGestionTareas";
            btnGestionTareas.Size = new Size(204, 46);
            btnGestionTareas.TabIndex = 14;
            btnGestionTareas.Text = "Gestionar Tareas";
            btnGestionTareas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Location = new Point(258, 73);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.Size = new Size(488, 141);
            dataGridViewGrupos.TabIndex = 15;
            // 
            // lblGruposStatic
            // 
            lblGruposStatic.AutoSize = true;
            lblGruposStatic.Location = new Point(258, 53);
            lblGruposStatic.Name = "lblGruposStatic";
            lblGruposStatic.Size = new Size(103, 15);
            lblGruposStatic.TabIndex = 16;
            lblGruposStatic.Text = "Grupos Asignados";
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(258, 267);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.Size = new Size(488, 141);
            dataGridViewTareas.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 249);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 18;
            label1.Text = "Ultimas Tareas";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(23, 362);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(204, 46);
            btnCerrarSesion.TabIndex = 19;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnConfigurarPerfil
            // 
            btnConfigurarPerfil.Location = new Point(20, 189);
            btnConfigurarPerfil.Name = "btnConfigurarPerfil";
            btnConfigurarPerfil.Size = new Size(204, 46);
            btnConfigurarPerfil.TabIndex = 20;
            btnConfigurarPerfil.Text = "Configurar Perfil";
            btnConfigurarPerfil.UseVisualStyleBackColor = true;
            // 
            // FrmMenuMaestro
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(773, 446);
            Controls.Add(btnConfigurarPerfil);
            Controls.Add(btnCerrarSesion);
            Controls.Add(label1);
            Controls.Add(dataGridViewTareas);
            Controls.Add(lblGruposStatic);
            Controls.Add(dataGridViewGrupos);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnGestionTareas);
            Controls.Add(tableLayoutPanel2);
            Name = "FrmMenuMaestro";
            Text = "FrmMenuMaestro";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMPfp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label lblMenuTitle;
        public Button btnCerrarVentana;
        public Button btnMinimizarVentana;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblRol;
        private Label lblRolStatic;
        private Label lblUsuario;
        private Label lblUsuarioStatic;
        private PictureBox pictureBoxMPfp;
        public Button btnRegistrarGeneracion;
        public Button btnGestionTareas;
        private Label lblGruposStatic;
        private Label label1;
        public Button btnCerrarSesion;
        public Button btnConfigurarPerfil;
        public DataGridView dataGridViewGrupos;
        public DataGridView dataGridViewTareas;
    }
}