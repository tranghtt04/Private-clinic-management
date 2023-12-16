namespace QLPK
{
    partial class frmDSDonThuocDaLap
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
            this.btnLapDTMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSDonThuocDaLap = new System.Windows.Forms.DataGridView();
            this.btnThemMoiCT_DonThuoc = new System.Windows.Forms.Button();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonThuocDaLap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLapDTMoi
            // 
            this.btnLapDTMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapDTMoi.Location = new System.Drawing.Point(1165, 26);
            this.btnLapDTMoi.Name = "btnLapDTMoi";
            this.btnLapDTMoi.Size = new System.Drawing.Size(171, 31);
            this.btnLapDTMoi.TabIndex = 9;
            this.btnLapDTMoi.Text = "Lập đơn thuốc mới";
            this.btnLapDTMoi.UseVisualStyleBackColor = true;
            this.btnLapDTMoi.Click += new System.EventHandler(this.btnLapDTMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(1028, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 32);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(733, 35);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(264, 22);
            this.txtTuKhoa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ khóa";
            // 
            // dgvDSDonThuocDaLap
            // 
            this.dgvDSDonThuocDaLap.AllowUserToAddRows = false;
            this.dgvDSDonThuocDaLap.AllowUserToDeleteRows = false;
            this.dgvDSDonThuocDaLap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDonThuocDaLap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDonThuocDaLap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDonThuocDaLap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADT,
            this.TENBN,
            this.TENBS,
            this.TENTHUOC,
            this.SOLUONG,
            this.GIATHUOC,
            this.btnXoa});
            this.dgvDSDonThuocDaLap.Location = new System.Drawing.Point(0, 118);
            this.dgvDSDonThuocDaLap.MultiSelect = false;
            this.dgvDSDonThuocDaLap.Name = "dgvDSDonThuocDaLap";
            this.dgvDSDonThuocDaLap.ReadOnly = true;
            this.dgvDSDonThuocDaLap.RowHeadersWidth = 51;
            this.dgvDSDonThuocDaLap.RowTemplate.Height = 24;
            this.dgvDSDonThuocDaLap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDonThuocDaLap.Size = new System.Drawing.Size(1372, 390);
            this.dgvDSDonThuocDaLap.TabIndex = 5;
            this.dgvDSDonThuocDaLap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonThuocDaLap_CellClick);
            this.dgvDSDonThuocDaLap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDonThuocDaLap_CellDoubleClick);
            // 
            // btnThemMoiCT_DonThuoc
            // 
            this.btnThemMoiCT_DonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoiCT_DonThuoc.Location = new System.Drawing.Point(1165, 73);
            this.btnThemMoiCT_DonThuoc.Name = "btnThemMoiCT_DonThuoc";
            this.btnThemMoiCT_DonThuoc.Size = new System.Drawing.Size(171, 30);
            this.btnThemMoiCT_DonThuoc.TabIndex = 10;
            this.btnThemMoiCT_DonThuoc.Text = "Thêm chi tiết đơn thuốc";
            this.btnThemMoiCT_DonThuoc.UseVisualStyleBackColor = true;
            this.btnThemMoiCT_DonThuoc.Click += new System.EventHandler(this.btnThemMoiCT_DonThuoc_Click);
            // 
            // MADT
            // 
            this.MADT.DataPropertyName = "MADT";
            this.MADT.HeaderText = "Mã đơn thuốc";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            this.MADT.ReadOnly = true;
            // 
            // TENBN
            // 
            this.TENBN.DataPropertyName = "TENBN";
            this.TENBN.HeaderText = "Tên bệnh nhân";
            this.TENBN.MinimumWidth = 6;
            this.TENBN.Name = "TENBN";
            this.TENBN.ReadOnly = true;
            // 
            // TENBS
            // 
            this.TENBS.DataPropertyName = "TENBS";
            this.TENBS.HeaderText = "Tên bác sĩ";
            this.TENBS.MinimumWidth = 6;
            this.TENBS.Name = "TENBS";
            this.TENBS.ReadOnly = true;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.DataPropertyName = "TENTHUOC";
            this.TENTHUOC.HeaderText = "Tên thuốc";
            this.TENTHUOC.MinimumWidth = 6;
            this.TENTHUOC.Name = "TENTHUOC";
            this.TENTHUOC.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // GIATHUOC
            // 
            this.GIATHUOC.DataPropertyName = "GIATHUOC";
            this.GIATHUOC.HeaderText = "Giá thuốc";
            this.GIATHUOC.MinimumWidth = 6;
            this.GIATHUOC.Name = "GIATHUOC";
            this.GIATHUOC.ReadOnly = true;
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
            // frmDSDonThuocDaLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 509);
            this.Controls.Add(this.btnThemMoiCT_DonThuoc);
            this.Controls.Add(this.btnLapDTMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSDonThuocDaLap);
            this.Name = "frmDSDonThuocDaLap";
            this.Text = "Danh sách đơn thuốc đã lập";
            this.Load += new System.EventHandler(this.frmDSDonThuocDaLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDonThuocDaLap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapDTMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDonThuocDaLap;
        private System.Windows.Forms.Button btnThemMoiCT_DonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATHUOC;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}