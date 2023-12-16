namespace QLPK
{
    partial class frmLapHoaDon
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
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.mtbSoLuong = new System.Windows.Forms.MaskedTextBox();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(190, 63);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(216, 22);
            this.txtMaHD.TabIndex = 27;
            // 
            // mtbSoLuong
            // 
            this.mtbSoLuong.Location = new System.Drawing.Point(190, 161);
            this.mtbSoLuong.Mask = "00000";
            this.mtbSoLuong.Name = "mtbSoLuong";
            this.mtbSoLuong.Size = new System.Drawing.Size(100, 22);
            this.mtbSoLuong.TabIndex = 26;
            this.mtbSoLuong.ValidatingType = typeof(int);
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Location = new System.Drawing.Point(190, 110);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(216, 24);
            this.cbbMaDV.TabIndex = 25;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(269, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(155, 213);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số lượng";
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 307);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.mtbSoLuong);
            this.Controls.Add(this.cbbMaDV);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLapHoaDon";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.MaskedTextBox mtbSoLuong;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}