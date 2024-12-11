namespace SistemaEducativo.Views.Alumno
{
    partial class FrmGestionTareasAlumno
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
            flowLayoutPanelTareas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelTareas
            // 
            flowLayoutPanelTareas.AutoScroll = true;
            flowLayoutPanelTareas.Location = new Point(0, 0);
            flowLayoutPanelTareas.Margin = new Padding(0);
            flowLayoutPanelTareas.Name = "flowLayoutPanelTareas";
            flowLayoutPanelTareas.Size = new Size(596, 275);
            flowLayoutPanelTareas.TabIndex = 10;
            // 
            // FrmGestionTareasAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 223, 244);
            ClientSize = new Size(596, 275);
            Controls.Add(flowLayoutPanelTareas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTareasAlumno";
            Text = "FrmGestionTareasAlumno";
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel flowLayoutPanelTareas;
    }
}