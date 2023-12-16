namespace QLPK
{
    partial class frmDSBNChuaCoHoaDon
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
            this.dgvBNChuaCoHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBNChuaCoHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBNChuaCoHoaDon
            // 
            this.dgvBNChuaCoHoaDon.AllowUserToAddRows = false;
            this.dgvBNChuaCoHoaDon.AllowUserToDeleteRows = false;
            this.dgvBNChuaCoHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBNChuaCoHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBNChuaCoHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBNChuaCoHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvBNChuaCoHoaDon.MultiSelect = false;
            this.dgvBNChuaCoHoaDon.Name = "dgvBNChuaCoHoaDon";
            this.dgvBNChuaCoHoaDon.ReadOnly = true;
            this.dgvBNChuaCoHoaDon.RowHeadersWidth = 51;
            this.dgvBNChuaCoHoaDon.RowTemplate.Height = 24;
            this.dgvBNChuaCoHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBNChuaCoHoaDon.Size = new System.Drawing.Size(800, 450);
            this.dgvBNChuaCoHoaDon.TabIndex = 1;
            this.dgvBNChuaCoHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBNChuaCoHoaDon_CellDoubleClick);
            // 
            // frmDSBNChuaCoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBNChuaCoHoaDon);
            this.Name = "frmDSBNChuaCoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bệnh nhân chưa có hóa đơn";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBNChuaCoHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBNChuaCoHoaDon;
    }
}