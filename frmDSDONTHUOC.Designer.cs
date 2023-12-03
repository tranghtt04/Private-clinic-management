namespace QLPK
{
    partial class frmDSDONTHUOC
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
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.MADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADT,
            this.MABS,
            this.MABN,
            this.btnXoa});
            this.dgvDonThuoc.Location = new System.Drawing.Point(0, 132);
            this.dgvDonThuoc.MultiSelect = false;
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.RowHeadersWidth = 51;
            this.dgvDonThuoc.RowTemplate.Height = 24;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(1151, 316);
            this.dgvDonThuoc.TabIndex = 13;
            this.dgvDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonThuoc_CellClick);
            this.dgvDonThuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonThuoc_CellDoubleClick);
            // 
            // MADT
            // 
            this.MADT.DataPropertyName = "MADT";
            this.MADT.HeaderText = "Mã đơn thuốc";
            this.MADT.MinimumWidth = 6;
            this.MADT.Name = "MADT";
            this.MADT.ReadOnly = true;
            // 
            // MABS
            // 
            this.MABS.DataPropertyName = "TENBS";
            this.MABS.HeaderText = "Tên bác sĩ";
            this.MABS.MinimumWidth = 6;
            this.MABS.Name = "MABS";
            this.MABS.ReadOnly = true;
            // 
            // MABN
            // 
            this.MABN.DataPropertyName = "TENBN";
            this.MABN.HeaderText = "Tên bệnh nhân";
            this.MABN.MinimumWidth = 6;
            this.MABN.Name = "MABN";
            this.MABN.ReadOnly = true;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Từ khóa";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.Location = new System.Drawing.Point(994, 57);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(90, 34);
            this.btnThemMoi.TabIndex = 11;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(879, 57);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 34);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(586, 69);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(269, 22);
            this.txtTuKhoa.TabIndex = 9;
            // 
            // frmDSDONTHUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 448);
            this.Controls.Add(this.dgvDonThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Name = "frmDSDONTHUOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đơn thuốc";
            this.Load += new System.EventHandler(this.frmDSDONTHUOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABN;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}