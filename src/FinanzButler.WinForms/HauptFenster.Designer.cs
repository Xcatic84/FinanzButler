namespace FinanzButler.WinForms
{
    partial class HauptFenster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBuchungen = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBuchungen).BeginInit();
            SuspendLayout();
            // 
            // dgvBuchungen
            // 
            dgvBuchungen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuchungen.Dock = DockStyle.Fill;
            dgvBuchungen.Location = new Point(0, 0);
            dgvBuchungen.Name = "dgvBuchungen";
            dgvBuchungen.RowHeadersWidth = 51;
            dgvBuchungen.Size = new Size(882, 553);
            dgvBuchungen.TabIndex = 0;
            // 
            // HauptFenster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(dgvBuchungen);
            Name = "HauptFenster";
            Text = "Finanz Butler";
            ((System.ComponentModel.ISupportInitialize)dgvBuchungen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBuchungen;
    }
}
