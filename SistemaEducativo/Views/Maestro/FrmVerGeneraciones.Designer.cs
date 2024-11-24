namespace SistemaEducativo.Views.Maestro
{
    partial class FrmVerGeneraciones
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
            dataGridViewGSP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGSP).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGSP
            // 
            dataGridViewGSP.AllowUserToAddRows = false;
            dataGridViewGSP.AllowUserToDeleteRows = false;
            dataGridViewGSP.AllowUserToResizeColumns = false;
            dataGridViewGSP.AllowUserToResizeRows = false;
            dataGridViewGSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGSP.Location = new Point(23, 89);
            dataGridViewGSP.MultiSelect = false;
            dataGridViewGSP.Name = "dataGridViewGSP";
            dataGridViewGSP.ReadOnly = true;
            dataGridViewGSP.RowHeadersVisible = false;
            dataGridViewGSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGSP.ShowEditingIcon = false;
            dataGridViewGSP.Size = new Size(501, 333);
            dataGridViewGSP.TabIndex = 0;
            // 
            // FrmVerGSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(dataGridViewGSP);
            Name = "FrmVerGSP";
            Text = "FrmVerGeneraciones";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridViewGSP;
    }
}