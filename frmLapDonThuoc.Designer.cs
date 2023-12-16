namespace QLPK
{
    partial class frmLapDonThuoc
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
            this.cbbMaThuoc = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbSoLuong = new System.Windows.Forms.MaskedTextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbMaThuoc
            // 
            this.cbbMaThuoc.FormattingEnabled = true;
            this.cbbMaThuoc.Location = new System.Drawing.Point(254, 132);
            this.cbbMaThuoc.Name = "cbbMaThuoc";
            this.cbbMaThuoc.Size = new System.Drawing.Size(216, 24);
            this.cbbMaThuoc.TabIndex = 17;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(333, 235);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(219, 235);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã đơn thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số lượng";
            // 
            // mtbSoLuong
            // 
            this.mtbSoLuong.Location = new System.Drawing.Point(254, 183);
            this.mtbSoLuong.Mask = "00000";
            this.mtbSoLuong.Name = "mtbSoLuong";
            this.mtbSoLuong.Size = new System.Drawing.Size(100, 22);
            this.mtbSoLuong.TabIndex = 18;
            this.mtbSoLuong.ValidatingType = typeof(int);
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(254, 85);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(216, 22);
            this.txtMaDT.TabIndex = 19;
            // 
            // frmLapDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 334);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.mtbSoLuong);
            this.Controls.Add(this.cbbMaThuoc);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLapDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLapDonThuoc";
            this.Load += new System.EventHandler(this.frmLapDonThuoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaThuoc;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbSoLuong;
        private System.Windows.Forms.TextBox txtMaDT;
    }
}