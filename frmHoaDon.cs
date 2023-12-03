using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon(string mhd)
        {
            this.mhd = mhd;
            InitializeComponent();
        }
        private string mhd;
        private Database db;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<CustormParameter> lst = new List<CustormParameter>()
            {
                new CustormParameter()
                {
                    key = "@tukhoa",
                    value = ""
                }
            };
            //load dữ liệu cho 2 combobox bệnh nhân và đơn thuốc
            cbbBenhNhan.DataSource = db.SelectData("SelectAllBenhNhan", lst);
            cbbBenhNhan.DisplayMember = "TENBN"; //thuộc tính hiển thị của combobox
            cbbBenhNhan.ValueMember = "MABN"; //giá trị (key) của combobox
            //cbbBenhNhan.SelectedIndex = -1;//set combobox không chọn giá trị nào


            cbbMaDT.DataSource = db.SelectData("SelectAllDonThuoc", lst);
            cbbMaDT.DisplayMember = "MADT"; //thuộc tính hiển thị của combobox
            cbbMaDT.ValueMember = "MADT"; //giá trị (key) của combobox
            //cbbBacSi.SelectedIndex = -1; //set combobox không chọn giá trị nào

            if (string.IsNullOrEmpty(mhd))
            {
                this.Text = "Thêm mới hóa đơn";
            }
            else
            {
                this.Text = "Cập nhật thông tin hóa đơn";
                var r = db.Select("selectHoaDon '" + mhd + "'");
                txtMaHD.Text = r["MAHD"].ToString();
                cbbBenhNhan.Text = r["MABN"].ToString();
                cbbMaDT.Text = r["MADT"].ToString();
                mtbNgayLap.Text = r["NGAYLAP"].ToString();
                txtTongTien.Text = r["TONGTIEN"].ToString();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var tt = float.Parse(txtTongTien.Text);
                if (tt <= 0)
                {
                    MessageBox.Show("Tổng tiền phải lớn hơn 0");
                    txtTongTien.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Tổng tiền phải là kiểu số");
                txtTongTien.Select();
                return;
            }
            string sql = "";
            //ràng buộc điều kiện 
            //phải chọn bác sĩ và bệnh nhân mới thực 
            if (cbbBenhNhan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
            if (cbbMaDT.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã đơn thuốc");
                return;
            }//kết thúc ràng buộc

            string mahd = txtMaHD.Text;
            DateTime ngaylap;
            try
            {
                ngaylap = DateTime.ParseExact(mtbNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày lập không hợp lệ");
                mtbNgayLap.Select();//trỏ chuột về mtbNgayLap
                return;//ko thực hiên các câu lệnh phía dưới
            }
            //vì ngày lập ở mtb chúng ta set theo dạng dd/mm/yyyy
            //nên cần phải chuyển lại dạng yyyy-mm-dd
            string tongtien = txtTongTien.Text;

            List<CustormParameter> lst = new List<CustormParameter>();
            if (string.IsNullOrEmpty(mhd))
            {
                sql = "ThemMoiHoaDon";
                lst.Add(new CustormParameter()
                {
                    key = "@mahd",
                    value = mahd
                });
            }
            else
            {
                sql = "UpdateHoaDon";
                lst.Add(new CustormParameter()
                {
                    key = "@MAHD",
                    value = mhd
                });
            }

            lst.Add(new CustormParameter()
            {
                key = "@MABN",
                value = cbbBenhNhan.SelectedValue.ToString() //lấy giá trị được chọn của combobox
            });
            lst.Add(new CustormParameter()
            {
                key = "@MADT",
                value = cbbMaDT.SelectedValue.ToString()
            });
            lst.Add(new CustormParameter()
            {
                key = "@NGAYLAP",
                value = ngaylap.ToString("yyyy-MM-dd")
            });
            lst.Add(new CustormParameter()
            {
                key = "@TONGTIEN",
                value = tongtien
            });

            var rs = db.ExCute(sql, lst);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(mhd))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới hóa đơn thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin hóa đơn thành công");
                }
                this.Dispose();//đóng form sau khi thêm mới/ cập nhật thành công
            }
            else//nếu không thành công
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}
