using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK
{
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon(string mahoadon)
        {
            this.mahoadon = mahoadon;
            InitializeComponent();
        }
        private string mahoadon;
        private Database db;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var tt = float.Parse(mtbSoLuong.Text);
            }
            catch
            {
                MessageBox.Show("Số lượng phải là kiểu số");
                mtbSoLuong.Select();
                return;
            }
            string sql = "";
            string mhd = txtMaHD.Text;
            string soluong = mtbSoLuong.Text;
            List<CustormParameter> lst = new List<CustormParameter>();
            if (string.IsNullOrEmpty(mahoadon))
            {
                sql = "ThemMoiCT_HoaDon";
                lst.Add(new CustormParameter()
                {
                    key = "@MAHD",
                    value = mhd
                });
            }
            else
            {
                sql = "UpdateCT_HoaDon";
                lst.Add(new CustormParameter()
                {
                    key = "@MAHD",
                    value = mahoadon
                });
            }
            lst.Add(new CustormParameter()
            {
                key = "@MADV",
                value = cbbMaDV.SelectedValue.ToString() //lấy giá trị được chọn của combobox
            });
            lst.Add(new CustormParameter()
            {
                key = "@SOLUONG",
                value = soluong
            });
            var rs = db.ExCute(sql, lst);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(mahoadon))//nếu thêm mới
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn-dịch vụ thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật chi tiết hóa đơn-dịch vụ thành công");
                }
                this.Dispose();//đóng form sau khi thêm mới/ cập nhật thành công
            }
            else//nếu không thành công
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
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
            cbbMaDV.DataSource = db.SelectData("SelectAllDVKham", lst);
            cbbMaDV.DisplayMember = "TENDV"; //thuộc tính hiển thị của combobox
            cbbMaDV.ValueMember = "MADV"; //giá trị (key) của combobox

            if (string.IsNullOrEmpty(mahoadon))
            {
                this.Text = "Thêm mới chi tiết hóa đơn-dịch vụ";
            }
            else
            {
                this.Text = "Cập nhật chi tiết hóa đơn-dịch vụ";
                var r = db.Select("selectCT_HoaDon '" + mahoadon + "'");
                txtMaHD.Text = r["MAHD"].ToString();
                cbbMaDV.Text = r["MADV"].ToString();
                mtbSoLuong.Text = r["SOLUONG"].ToString();
            }
        }
    }
}
