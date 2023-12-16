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
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLapHDMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMoiCT_HoaDon = new System.Windows.Forms.Button();
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
            this.dgvDSHoaDonDaLap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.TENBN,
            this.TENDV,
            this.SOLUONGDV,
            this.MADT,
            this.TENBS,
            this.NGAYLAP,
            this.TONGTIEN,
            this.btnXoa});
            this.dgvDSHoaDonDaLap.Location = new System.Drawing.Point(0, 131);
            this.dgvDSHoaDonDaLap.MultiSelect = false;
            this.dgvDSHoaDonDaLap.Name = "dgvDSHoaDonDaLap";
            this.dgvDSHoaDonDaLap.ReadOnly = true;
            this.dgvDSHoaDonDaLap.RowHeadersWidth = 51;
            this.dgvDSHoaDonDaLap.RowTemplate.Height = 24;
            this.dgvDSHoaDonDaLap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDonDaLap.Size = new System.Drawing.Size(1157, 367);
            this.dgvDSHoaDonDaLap.TabIndex = 0;
            this.dgvDSHoaDonDaLap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDonDaLap_CellClick);
            this.dgvDSHoaDonDaLap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDonDaLap_CellDoubleClick);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.MinimumWidth = 6;
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // TENBN
            // 
            this.TENBN.DataPropertyName = "TENBN";
            this.TENBN.HeaderText = "Tên bệnh nhân";
            this.TENBN.MinimumWidth = 6;
            this.TENBN.Name = "TENBN";
            this.TENBN.ReadOnly = true;
            // 
            // TENDV
            // 
            this.TENDV.DataPropertyName = "TENDV";
            this.TENDV.HeaderText = "Tên dịch vụ";
            this.TENDV.MinimumWidth = 6;
            this.TENDV.Name = "TENDV";
            this.TENDV.ReadOnly = true;
            // 
            // SOLUONGDV
            // 
            this.SOLUONGDV.DataPropertyName = "SOLUONGDV";
            this.SOLUONGDV.HeaderText = "Số lượng";
            this.SOLUONGDV.MinimumWidth = 6;
            this.SOLUONGDV.Name = "SOLUONGDV";
            this.SOLUONGDV.ReadOnly = true;
            // 
            // MADT
            // 
            this.MADT.DataPropertyName = "MADT";
            this.MADT.HeaderText = "Mã đơn thuốc";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            this.MADT.ReadOnly = true;
            // 
            // TENBS
            // 
            this.TENBS.DataPropertyName = "TENBS";
            this.TENBS.HeaderText = "Tên bác sĩ";
            this.TENBS.MinimumWidth = 6;
            this.TENBS.Name = "TENBS";
            this.TENBS.ReadOnly = true;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            // 
            // btnLapHDMoi
            // 
            this.btnLapHDMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapHDMoi.Location = new System.Drawing.Point(946, 39);
            this.btnLapHDMoi.Name = "btnLapHDMoi";
            this.btnLapHDMoi.Size = new System.Drawing.Size(164, 31);
            this.btnLapHDMoi.TabIndex = 13;
            this.btnLapHDMoi.Text = "Lập hóa đơn mới";
            this.btnLapHDMoi.UseVisualStyleBackColor = true;
            this.btnLapHDMoi.Click += new System.EventHandler(this.btnLapHDMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(828, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 32);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(533, 47);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(264, 22);
            this.txtTuKhoa.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ khóa";
            // 
            // btnThemMoiCT_HoaDon
            // 
            this.btnThemMoiCT_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiCT_HoaDon.Location = new System.Drawing.Point(946, 86);
            this.btnThemMoiCT_HoaDon.Name = "btnThemMoiCT_HoaDon";
            this.btnThemMoiCT_HoaDon.Size = new System.Drawing.Size(164, 30);
            this.btnThemMoiCT_HoaDon.TabIndex = 14;
            this.btnThemMoiCT_HoaDon.Text = "Thêm chi tiết hóa đơn";
            this.btnThemMoiCT_HoaDon.UseVisualStyleBackColor = true;
            this.btnThemMoiCT_HoaDon.Click += new System.EventHandler(this.btnThemMoiCT_HoaDon_Click);
            // 
            // frmDSHoaDonDaLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 498);
            this.Controls.Add(this.btnThemMoiCT_HoaDon);
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
        private System.Windows.Forms.Button btnThemMoiCT_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}