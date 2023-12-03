using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK
{
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan(string mbn)
        {
            this.mbn = mbn; //truyền lại mã bệnh nhân khi form chạy
            InitializeComponent();
        }
        private string mbn;
        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mbn)) //nếu mã bn không có => thêm mới bệnh nhân
            {
                this.Text = "Thêm mới bệnh nhân";
            }
            else
            {
                this.Text = "Cập nhật thông tin bệnh nhân";
                //lấy thông tin chi tiết của 1 bệnh nhân dựa vào mbn
                //mbn là mã bệnh nhân đã được truyền từ form dsbn
                var r = new Database().Select("selectBN '"+mbn+"'");
                //MessageBox.Show(r[0].ToString()); //load thành công
                //set các giá trị vào component của form

                txtMaBN.Text = r["MABN"].ToString();
                txtTenBN.Text = r["TENBN"].ToString();
                txtGioiTinh.Text = r["GIOITINH"].ToString();
                mtbNgaySinh.Text = r["NGAYSINH"].ToString();
                txtDiaChi.Text = r["DIACHI"].ToString();
                txtSdt.Text = r["SODIENTHOAI"].ToString();
                txtTinhTrangSucKhoe.Text = r["TINHTRANGSUCKHOE"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //button này sẽ xử lý 1 trong 2 tình huống
            //TH1: nếu mabn ko có giá trị -> thêm mới bệnh nhân
            //TH2: nếu mabn có giá trị -> cập nhật bênh nhân
            //Ý tưởng: cho dù thêm mới hay cập nhật đều cần tất cả các giá trị
            //=> các gtri này dùng cho cả 2 TH
            //riêng cập nhật bệnh nhân thì cần quan tâm tới mã bệnh nhân

            string sql = "";
            string mabn = txtMaBN.Text;
            string tenbn = txtTenBN.Text;
            string gioitinh = txtGioiTinh.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/MM/yyyy",CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgaySinh.Select();//trỏ chuột về mtbNgaySinh
                return;//ko thực hiên các câu lệnh phía dưới
            }
            string diachi = txtDiaChi.Text;
            string sdt = txtSdt.Text;
            string tinhtrangsuckhoe = txtTinhTrangSucKhoe.Text;
            //vì ngày sinh ở mtb chúng ta set theo dạng dd/mm/yyyy
            //nên cần phải chuyển lại dạng yyyy-mm-dd
            
            //khai báo một ds tham số = class CustomParameter 
            List<CustormParameter> lstPara = new List<CustormParameter>();
            if(string.IsNullOrEmpty(mbn))//nếu thêm mới bệnh nhân
            {
                sql = "ThemMoiBN";//gọi tới proc thêm mới bệnh nhân
                lstPara.Add(new CustormParameter()
                {
                    key = "@mabn",
                    value = mabn
                });
            }
            else//nếu cập nhật bệnh nhân
            {
                sql = "UpdateBN";//gọi tới proc update bệnh nhân
                lstPara.Add(new CustormParameter()
                {
                    key = "@MABN",
                    value = mbn
                });
            }
            lstPara.Add(new CustormParameter()
            {
                key = "@TENBN",
                value = tenbn
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@GIOITINH",
                value = gioitinh
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@NGAYSINH",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@DIACHI",
                value = diachi
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@SODIENTHOAI",
                value = sdt
            });
            lstPara.Add(new CustormParameter()
            {
                key = "@TINHTRANGSUCKHOE",
                value = tinhtrangsuckhoe
            });


            var rs = new Database().ExCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if(rs == 1)//nếu thực thi thành công
            {
                if(string.IsNullOrEmpty(mbn))//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới bệnh nhân thành công");
                }else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin bệnh nhân thành công");
                }
                this.Dispose();//đóng form sau khi thêm mới/ cập nhật thành công
            }else//nếu không thành công
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
