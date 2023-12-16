using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK
{
    public partial class frmLapDonThuoc : Form
    {
        public frmLapDonThuoc(string madonthuoc)
        {
            this.madonthuoc = madonthuoc;
            InitializeComponent();
        }
        private string madonthuoc;
        private Database db;
        private void frmLapDonThuoc_Load(object sender, EventArgs e)
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
            cbbMaThuoc.DataSource = db.SelectData("SelectAllThuoc", lst);
            cbbMaThuoc.DisplayMember = "TENTHUOC"; //thuộc tính hiển thị của combobox
            cbbMaThuoc.ValueMember = "MATHUOC"; //giá trị (key) của combobox
            //cbbBenhNhan.SelectedIndex = -1;//set combobox không chọn giá trị nào
            if (string.IsNullOrEmpty(madonthuoc))
            {
                this.Text = "Thêm mới chi tiết đơn thuốc";
            }
            else
            {
                this.Text = "Cập nhật chi tiết đơn thuốc";
                var r = db.Select("selectCT_DonThuoc '" + madonthuoc + "'");
                txtMaDT.Text = r["MADT"].ToString();
                cbbMaThuoc.Text = r["MATHUOC"].ToString();
                mtbSoLuong.Text = r["SOLUONG"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
            string mdt = txtMaDT.Text;
            string soluong = mtbSoLuong.Text;
            List<CustormParameter> lst = new List<CustormParameter>();
            if (string.IsNullOrEmpty(madonthuoc))
            {
                sql = "ThemMoiCT_DonThuoc";
                lst.Add(new CustormParameter()
                {
                    key = "@MADT",
                    value = mdt
                });
            }
            else
            {
                sql = "UpdateCT_DonThuoc";
                lst.Add(new CustormParameter()
                {
                    key = "@MADT",
                    value = madonthuoc
                });
            }
            lst.Add(new CustormParameter()
            {
                key = "@MATHUOC",
                value = cbbMaThuoc.SelectedValue.ToString() //lấy giá trị được chọn của combobox
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
                if (string.IsNullOrEmpty(madonthuoc))//nếu thêm mới
                {
                    MessageBox.Show("Thêm chi tiết đơn thuốc thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật chi tiết đơn thuốc thành công");
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
