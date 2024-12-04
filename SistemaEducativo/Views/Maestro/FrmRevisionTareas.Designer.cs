namespace SistemaEducativo.Views.Maestro
{
    partial class FrmRevisionTareas
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
            dataGridViewTareas = new DataGridView();
            button1 = new Button();
            lblCalificacionStatic = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.AllowUserToAddRows = false;
            dataGridViewTareas.AllowUserToDeleteRows = false;
            dataGridViewTareas.AllowUserToResizeColumns = false;
            dataGridViewTareas.AllowUserToResizeRows = false;
            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(16, 12);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.ReadOnly = true;
            dataGridViewTareas.RowHeadersVisible = false;
            dataGridViewTareas.Size = new Size(435, 249);
            dataGridViewTareas.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(457, 223);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 1;
            button1.Text = "Calificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblCalificacionStatic
            // 
            lblCalificacionStatic.AutoSize = true;
            lblCalificacionStatic.Location = new Point(457, 12);
            lblCalificacionStatic.Name = "lblCalificacionStatic";
            lblCalificacionStatic.Size = new Size(69, 15);
            lblCalificacionStatic.TabIndex = 2;
            lblCalificacionStatic.Text = "Calificacion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(457, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(457, 59);
            button2.Name = "button2";
            button2.Size = new Size(127, 38);
            button2.TabIndex = 6;
            button2.Text = "Visualizar Tarea";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmRevisionTareas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(596, 275);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(lblCalificacionStatic);
            Controls.Add(button1);
            Controls.Add(dataGridViewTareas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRevisionTareas";
            Text = "Revision Tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lblCalificacionStatic;
        private TextBox textBox1;
        private Button button2;
        public DataGridView dataGridViewTareas;
    }
}