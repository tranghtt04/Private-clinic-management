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
    public partial class frmDVKham : Form
    {
        public frmDVKham(string mdv)
        {
            this.mdv = mdv;
            InitializeComponent();
        }

        private string mdv;
        private void frmDVKham_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mdv))
            {
                this.Text = "Thêm mới dịch vụ khám";
            }
            else
            {
                this.Text = "Cập nhật thông tin dịch vụ khám";
                var r = new Database().Select("selectDVKham '" + mdv + "'");
                txtMaDV.Text = r["MADV"].ToString();
                txtTenDV.Text = r["TENDV"].ToString();
                txtGiaDV.Text = r["GIADV"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                var gdv = float.Parse(txtGiaDV.Text);
                if (gdv <= 0)
                {
                    MessageBox.Show("Giá dịch vụ khám phải > 0");
                    txtGiaDV.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Giá dịch vụ khám phải là kiểu số");
                txtGiaDV.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtTenDV.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống");
                txtTenDV.Select();
                return;
            }
            string sql = "";
            string madv = txtMaDV.Text;
            string tendv = txtTenDV.Text;
            string giadv = txtGiaDV.Text;
            List<CustormParameter> lstPara = new List<CustormParameter>();
            if (string.IsNullOrEmpty(madv))//nếu thêm mới thuốc
            {
                sql = "ThemMoiDVKham";//gọi tới proc thêm mới thuốc
                lstPara.Add(new CustormParameter()
                {
                    key = "@madv",
                    value = madv
                });
            }
            else//nếu cập nhật thuoc
            {
                sql = "UpdateDVKham";//gọi tới proc update thuoc
                lstPara.Add(new CustormParameter()
                {
                    key = "@MADV",
                    value = madv
                });
            }
            lstPara.Add(new CustormParameter()
            {
                key = "@TENDV",
                value = tendv
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@GIADV",
                value = giadv
            });


            var rs = new Database().ExCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(madv))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới dịch vụ khám thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin dịch vụ khám thành công");
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
