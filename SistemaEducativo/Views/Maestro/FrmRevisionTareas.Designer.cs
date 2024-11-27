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
            lblComentariosStatic = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTareas
            // 
            dataGridViewTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTareas.Location = new Point(15, 56);
            dataGridViewTareas.Name = "dataGridViewTareas";
            dataGridViewTareas.Size = new Size(417, 309);
            dataGridViewTareas.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(438, 315);
            button1.Name = "button1";
            button1.Size = new Size(245, 50);
            button1.TabIndex = 1;
            button1.Text = "Calificar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblCalificacionStatic
            // 
            lblCalificacionStatic.AutoSize = true;
            lblCalificacionStatic.Location = new Point(444, 56);
            lblCalificacionStatic.Name = "lblCalificacionStatic";
            lblCalificacionStatic.Size = new Size(69, 15);
            lblCalificacionStatic.TabIndex = 2;
            lblCalificacionStatic.Text = "Calificacion";
            // 
            // lblComentariosStatic
            // 
            lblComentariosStatic.AutoSize = true;
            lblComentariosStatic.Location = new Point(438, 117);
            lblComentariosStatic.Name = "lblComentariosStatic";
            lblComentariosStatic.Size = new Size(75, 15);
            lblComentariosStatic.TabIndex = 3;
            lblComentariosStatic.Text = "Comentarios";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(438, 135);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(245, 124);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 23);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(531, 56);
            button2.Name = "button2";
            button2.Size = new Size(152, 41);
            button2.TabIndex = 6;
            button2.Text = "Visualizar Tarea";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmRevisionTareas
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(704, 380);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(lblComentariosStatic);
            Controls.Add(lblCalificacionStatic);
            Controls.Add(button1);
            Controls.Add(dataGridViewTareas);
            Name = "FrmRevisionTareas";
            Text = "Revision Tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTareas;
        private Button button1;
        private Label lblCalificacionStatic;
        private Label lblComentariosStatic;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button button2;
    }
}