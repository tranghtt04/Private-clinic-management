using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK
{
    public partial class frmThuoc : Form
    {
        public frmThuoc(string mt)
        {
            this.mt = mt;
            InitializeComponent();
        }
        private string mt;
        private void frmThuoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mt))
            {
                this.Text = "Thêm mới thuốc";
            }
            else
            {
                this.Text = "Cập nhật thông tin thuốc";
                var r = new Database().Select("selectThuoc '" + mt + "'");
                txtMaThuoc.Text = r["MATHUOC"].ToString();
                txtTenThuoc.Text = r["TENTHUOC"].ToString();
                txtGiaThuoc.Text = r["GIATHUOC"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                var giat = float.Parse(txtGiaThuoc.Text);
                if (giat <= 0) 
                {
                    MessageBox.Show("Giá thuốc phải > 0");
                    txtGiaThuoc.Select();
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Giá thuốc phải là kiểu số");
                txtGiaThuoc.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtTenThuoc.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống");
                txtTenThuoc.Select();
                return;
            }
            string sql = "";
            string mathuoc = txtMaThuoc.Text;
            string tenthuoc = txtTenThuoc.Text;
            string giathuoc = txtGiaThuoc.Text;
            List<CustormParameter> lstPara = new List<CustormParameter>();
            if (string.IsNullOrEmpty(mathuoc))//nếu thêm mới thuốc
            {
                sql = "ThemMoiThuoc";//gọi tới proc thêm mới thuốc
                lstPara.Add(new CustormParameter()
                {
                    key = "@mathuoc",
                    value = mathuoc
                });
            }
            else//nếu cập nhật thuoc
            {
                sql = "UpdateThuoc";//gọi tới proc update thuoc
                lstPara.Add(new CustormParameter()
                {
                    key = "@MATHUOC",
                    value = mathuoc
                });
            }
            lstPara.Add(new CustormParameter()
            {
                key = "@TENTHUOC",
                value = tenthuoc
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@GIATHUOC",
                value = giathuoc
            });


            var rs = new Database().ExCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(mt))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới thuốc thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin thuốc thành công");
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
    }
}
