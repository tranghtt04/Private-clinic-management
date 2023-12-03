namespace QLPK
{
    partial class frmHoaDon
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
            this.cbbMaDT = new System.Windows.Forms.ComboBox();
            this.cbbBenhNhan = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbNgayLap = new System.Windows.Forms.MaskedTextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbMaDT
            // 
            this.cbbMaDT.FormattingEnabled = true;
            this.cbbMaDT.Location = new System.Drawing.Point(227, 170);
            this.cbbMaDT.Name = "cbbMaDT";
            this.cbbMaDT.Size = new System.Drawing.Size(216, 24);
            this.cbbMaDT.TabIndex = 17;
            // 
            // cbbBenhNhan
            // 
            this.cbbBenhNhan.FormattingEnabled = true;
            this.cbbBenhNhan.Location = new System.Drawing.Point(227, 121);
            this.cbbBenhNhan.Name = "cbbBenhNhan";
            this.cbbBenhNhan.Size = new System.Drawing.Size(216, 24);
            this.cbbBenhNhan.TabIndex = 16;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(302, 327);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(192, 327);
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
            this.label3.Location = new System.Drawing.Point(125, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã đơn thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bệnh nhân";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(227, 73);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(216, 22);
            this.txtMaHD.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày lập";
            // 
            // mtbNgayLap
            // 
            this.mtbNgayLap.Location = new System.Drawing.Point(227, 218);
            this.mtbNgayLap.Mask = "00/00/0000";
            this.mtbNgayLap.Name = "mtbNgayLap";
            this.mtbNgayLap.Size = new System.Drawing.Size(100, 22);
            this.mtbNgayLap.TabIndex = 19;
            this.mtbNgayLap.ValidatingType = typeof(System.DateTime);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(227, 264);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(216, 22);
            this.txtTongTien.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tổng tiền";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 396);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbNgayLap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMaDT);
            this.Controls.Add(this.cbbBenhNhan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaDT;
        private System.Windows.Forms.ComboBox cbbBenhNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbNgayLap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
    }
}