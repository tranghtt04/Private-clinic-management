namespace QLPK
{
    partial class frmDSHoaDonDaLap
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
            this.dgvDSHoaDonDaLap = new System.Windows.Forms.DataGridView();
            this.btnLapHDMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDonDaLap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHoaDonDaLap
            // 
            this.dgvDSHoaDonDaLap.AllowUserToAddRows = false;
            this.dgvDSHoaDonDaLap.AllowUserToDeleteRows = false;
            this.dgvDSHoaDonDaLap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSHoaDonDaLap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDonDaLap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDonDaLap.Location = new System.Drawing.Point(0, 91);
            this.dgvDSHoaDonDaLap.MultiSelect = false;
            this.dgvDSHoaDonDaLap.Name = "dgvDSHoaDonDaLap";
            this.dgvDSHoaDonDaLap.ReadOnly = true;
            this.dgvDSHoaDonDaLap.RowHeadersWidth = 51;
            this.dgvDSHoaDonDaLap.RowTemplate.Height = 24;
            this.dgvDSHoaDonDaLap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDonDaLap.Size = new System.Drawing.Size(1157, 359);
            this.dgvDSHoaDonDaLap.TabIndex = 0;
            // 
            // btnLapHDMoi
            // 
            this.btnLapHDMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapHDMoi.Location = new System.Drawing.Point(982, 39);
            this.btnLapHDMoi.Name = "btnLapHDMoi";
            this.btnLapHDMoi.Size = new System.Drawing.Size(128, 31);
            this.btnLapHDMoi.TabIndex = 13;
            this.btnLapHDMoi.Text = "Lập hóa đơn mới";
            this.btnLapHDMoi.UseVisualStyleBackColor = true;
            this.btnLapHDMoi.Click += new System.EventHandler(this.btnLapHDMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(858, 39);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 32);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(563, 48);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(264, 22);
            this.txtTuKhoa.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ khóa";
            // 
            // frmDSHoaDonDaLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.btnLapHDMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSHoaDonDaLap);
            this.Name = "frmDSHoaDonDaLap";
            this.Text = "Danh sách hóa đơn đã lập";
            this.Load += new System.EventHandler(this.frmDSHoaDonDaLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDonDaLap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHoaDonDaLap;
        private System.Windows.Forms.Button btnLapHDMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label1;
    }
}