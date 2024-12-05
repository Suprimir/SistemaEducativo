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
            flowLayoutPanelTareas.Location = new Point(66, 56);
            flowLayoutPanelTareas.Margin = new Padding(0);
            flowLayoutPanelTareas.Name = "flowLayoutPanelTareas";
            flowLayoutPanelTareas.Size = new Size(543, 250);
            flowLayoutPanelTareas.TabIndex = 10;
            // 
            // FrmGestionTareasAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 367);
            Controls.Add(flowLayoutPanelTareas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGestionTareasAlumno";
            Text = "FrmGestionTareasAlumno";
            ResumeLayout(false);
        }

        #endregion
        public FlowLayoutPanel flowLayoutPanelTareas;
    }
}