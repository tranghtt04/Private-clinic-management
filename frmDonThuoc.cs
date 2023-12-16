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
    public partial class frmDonThuoc : Form
    {
        public frmDonThuoc(string mdt)
        {
            this.mdt = mdt;
            InitializeComponent();
        }
        private string mdt;
        private Database db;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmDonThuoc_Load(object sender, EventArgs e)
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
            //load dữ liệu cho 2 combobox bác sĩ và bệnh nhân
            cbbBacSi.DataSource = db.SelectData("SelectAllBacSi", lst);
            cbbBacSi.DisplayMember = "TENBS"; //thuộc tính hiển thị của combobox
            cbbBacSi.ValueMember = "MABS"; //giá trị (key) của combobox
            //cbbBacSi.SelectedIndex = -1; //set combobox không chọn giá trị nào

            cbbBenhNhan.DataSource = db.SelectData("SelectAllBenhNhan", lst);
            cbbBenhNhan.DisplayMember = "TENBN"; //thuộc tính hiển thị của combobox
            cbbBenhNhan.ValueMember = "MABN"; //giá trị (key) của combobox
            //cbbBenhNhan.SelectedIndex = -1;//set combobox không chọn giá trị nào
            if (string.IsNullOrEmpty(mdt))
            {
                this.Text = "Thêm mới đơn thuốc";
            }
            else
            {
                this.Text = "Cập nhật thông tin đơn thuốc";
                var r = db.Select("selectDonThuoc '" + mdt + "'");
                txtMaDT.Text = r["MADT"].ToString();
                cbbBacSi.Text = r["MABS"].ToString();
                cbbBenhNhan.Text = r["MABN"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            //ràng buộc điều kiện 
            //phải chọn bác sĩ và bệnh nhân mới thực 
            if (cbbBacSi.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ");
                return;
            }
            if (cbbBenhNhan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }//kết thúc ràng buộc

            string madt = txtMaDT.Text;
            List<CustormParameter> lst = new List<CustormParameter>();
            if (string.IsNullOrEmpty(mdt))
            {
                sql = "ThemMoiDonThuoc";
                lst.Add(new CustormParameter()
                {
                    key = "@madt",
                    value = madt
                });
            }
            else
            {
                sql = "UpdateDonThuoc";
                lst.Add(new CustormParameter()
                {
                    key = "@MADT",
                    value = mdt
                });
            }

            lst.Add(new CustormParameter()
            {
                key = "@MABS",
                value = cbbBacSi.SelectedValue.ToString() //lấy giá trị được chọn của combobox
            });
            lst.Add(new CustormParameter()
            {
                key = "@MABN",
                value = cbbBenhNhan.SelectedValue.ToString()
            });

            var rs = db.ExCute(sql, lst);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)//nếu thực thi thành công
            {
                if (string.IsNullOrEmpty(madt))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới thông tin đơn thuốc thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin đơn thuốc thành công");
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
