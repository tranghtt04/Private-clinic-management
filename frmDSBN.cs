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
    public partial class frmDSBN : Form
    {
        public frmDSBN()
        {
            InitializeComponent();
        }

        private void frmDSBN_Load(object sender, EventArgs e)
        {
            LoadDSBN();//gọi tới hàm Load bệnh nhân khi form được load
        }

        private void LoadDSBN()
        {
            //load toàn bộ danh sách bệnh nhân khi form được load

            //khai báo list customparameter 
            string tukhoa = txtTuKhoa.Text;
            List<CustormParameter> lstPara = new List<CustormParameter>();
            lstPara.Add(new CustormParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvBenhNhan.DataSource = new Database().SelectData("SelectAllBenhNhan", lstPara);
            //đặt tên cột
            dgvBenhNhan.Columns["MABN"].HeaderText = "Mã bệnh nhân";
            dgvBenhNhan.Columns["TENBN"].HeaderText = "Tên bệnh nhân";
            dgvBenhNhan.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgvBenhNhan.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgvBenhNhan.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvBenhNhan.Columns["SODIENTHOAI"].HeaderText = "Số điện thoại";
            dgvBenhNhan.Columns["TINHTRANGSUCKHOE"].HeaderText = "Tình trạng sức khỏe";
        }
        private void dgvBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ý tưởng: khi double click vào bệnh nhân trên data grid view
            //sẽ hiện ra form cập nhật thông tin bệnh nhân
            //để cập nhật được bệnh nhân cần lấy được mã bệnh nhân
            if(e.RowIndex >= 0)
            {
                var mbn = dgvBenhNhan.Rows[e.RowIndex].Cells["MABN"].Value.ToString();
                //Cần truyền mã bệnh nhân này vào form bệnh nhân
                new frmBenhNhan(mbn).ShowDialog();

                //sau khi frmBenhNhan được đóng lại
                //cần load lại danh sách bệnh nhân
                LoadDSBN();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmBenhNhan(null).ShowDialog(); //nếu thêm mới bệnh nhân --> mã bệnh nhân = null
            LoadDSBN(); //load lại DS bệnh nhân khi thêm thành công
                        //<-> frmBenhNhan được đóng
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSBN(); //load lại khi nhập tìm kiếm
        }
        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvBenhNhan.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa bệnh nhân: " + dgvBenhNhan.Rows[e.RowIndex].Cells["TENBN"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var maBS = dgvBenhNhan.Rows[e.RowIndex].Cells["MABN"].Value.ToString();
                        var sql = "DeleteBN";
                        var lstPara = new List<CustormParameter>()
                    {
                        new CustormParameter
                        {
                            key = "@MABN",
                            value = maBS
                        }
                    };

                        new Database().ExCute(sql, lstPara);
                        MessageBox.Show("Xóa bệnh nhân thành công!");
                        LoadDSBN();
                    }

                }
            }
        }
    }
}
