namespace QLPK
{
    partial class frmDSBNChuaCoDonThuoc
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
            this.dgvBNChuaCoDonThuoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBNChuaCoDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBNChuaCoDonThuoc
            // 
            this.dgvBNChuaCoDonThuoc.AllowUserToAddRows = false;
            this.dgvBNChuaCoDonThuoc.AllowUserToDeleteRows = false;
            this.dgvBNChuaCoDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBNChuaCoDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBNChuaCoDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBNChuaCoDonThuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvBNChuaCoDonThuoc.MultiSelect = false;
            this.dgvBNChuaCoDonThuoc.Name = "dgvBNChuaCoDonThuoc";
            this.dgvBNChuaCoDonThuoc.ReadOnly = true;
            this.dgvBNChuaCoDonThuoc.RowHeadersWidth = 51;
            this.dgvBNChuaCoDonThuoc.RowTemplate.Height = 24;
            this.dgvBNChuaCoDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBNChuaCoDonThuoc.Size = new System.Drawing.Size(800, 450);
            this.dgvBNChuaCoDonThuoc.TabIndex = 0;
            this.dgvBNChuaCoDonThuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBNChuaCoDonThuoc_CellDoubleClick);
            // 
            // frmDSBNChuaCoDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBNChuaCoDonThuoc);
            this.Name = "frmDSBNChuaCoDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bệnh nhân chưa được kê đơn thuốc";
            this.Load += new System.EventHandler(this.frmDSBNChuaCoDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBNChuaCoDonThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBNChuaCoDonThuoc;
    }
}