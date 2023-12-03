namespace QLPK
{
    partial class frmDSBS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.MABS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUYENNGANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(330, 61);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(213, 22);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(560, 52);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 31);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.Location = new System.Drawing.Point(674, 52);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(92, 31);
            this.btnThemMoi.TabIndex = 3;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvBacSi
            // 
            this.dgvBacSi.AllowUserToAddRows = false;
            this.dgvBacSi.AllowUserToDeleteRows = false;
            this.dgvBacSi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABS,
            this.TENBS,
            this.CHUYENNGANH,
            this.btnXoa});
            this.dgvBacSi.Location = new System.Drawing.Point(0, 113);
            this.dgvBacSi.MultiSelect = false;
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.RowHeadersWidth = 51;
            this.dgvBacSi.RowTemplate.Height = 24;
            this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBacSi.Size = new System.Drawing.Size(807, 352);
            this.dgvBacSi.TabIndex = 4;
            this.dgvBacSi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBacSi_CellClick);
            this.dgvBacSi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBacSi_CellDoubleClick);
            // 
            // MABS
            // 
            this.MABS.DataPropertyName = "MABS";
            this.MABS.HeaderText = "Mã bác sĩ";
            this.MABS.MinimumWidth = 6;
            this.MABS.Name = "MABS";
            this.MABS.ReadOnly = true;
            // 
            // TENBS
            // 
            this.TENBS.DataPropertyName = "TENBS";
            this.TENBS.HeaderText = "Tên bác sĩ";
            this.TENBS.MinimumWidth = 6;
            this.TENBS.Name = "TENBS";
            this.TENBS.ReadOnly = true;
            // 
            // CHUYENNGANH
            // 
            this.CHUYENNGANH.DataPropertyName = "CHUYENNGANH";
            this.CHUYENNGANH.HeaderText = "Chuyên ngành";
            this.CHUYENNGANH.MinimumWidth = 6;
            this.CHUYENNGANH.Name = "CHUYENNGANH";
            this.CHUYENNGANH.ReadOnly = true;
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
            // frmDSBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 465);
            this.Controls.Add(this.dgvBacSi);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frmDSBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bác sĩ";
            this.Load += new System.EventHandler(this.frmDSBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUYENNGANH;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}