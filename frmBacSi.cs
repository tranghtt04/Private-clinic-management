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
    public partial class frmBacSi : Form
    {
        public frmBacSi(string mbs)
        {
            this.mbs = mbs;
            InitializeComponent();
        }
        private string mbs;
        private void frmBacSi_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mbs))
            {
                this.Text = "Thêm mới bác sĩ";
            }else
            { 
                this.Text = "Cập nhật thông tin bác sĩ";
                var r = new Database().Select("selectBS '" + mbs + "'");
                txtMaBS.Text = r["MABS"].ToString();
                txtTenBS.Text = r["TENBS"].ToString();
                txtChuyenNganh.Text = r["CHUYENNGANH"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string mabs = txtMaBS.Text;
            string tenbs = txtTenBS.Text;
            string chuyennganh = txtChuyenNganh.Text;
            List<CustormParameter> lstPara = new List<CustormParameter>();
            if (string.IsNullOrEmpty(mbs))//nếu thêm mới bác sĩ
            {
                sql = "ThemMoiBS";//gọi tới proc thêm mới bác sĩ
                lstPara.Add(new CustormParameter()
                {
                    key = "@mabs",
                    value = mabs
                });
            }
            else//nếu cập nhật bác sĩ
            {
                sql = "UpdateBS";//gọi tới proc update bác sĩ
                lstPara.Add(new CustormParameter()
                {
                    key = "@MABS",
                    value = mbs
                });
            }
            lstPara.Add(new CustormParameter()
            {
                key = "@TENBS",
                value = tenbs
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@CHUYENNGANH",
                value = chuyennganh
            });


            var rs = new Database().ExCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(mbs))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới bác sĩ thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin bác sĩ thành công");
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
