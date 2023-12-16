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
    public partial class frmDSHoaDonDaLap : Form
    {
        public frmDSHoaDonDaLap()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSHoaDonDaLap_Load(object sender, EventArgs e)
        {
            LoadHoaDonDaLap();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadHoaDonDaLap();
        }
        private void LoadHoaDonDaLap()
        {
            List<CustormParameter> lst = new List<CustormParameter>() 
            {
                new CustormParameter()
                {
                    key = "@TUKHOA",
                    value = tukhoa
                }
            };
            dgvDSHoaDonDaLap.DataSource = new Database().SelectData("HoaDonDaLap", lst);
        }

        private void btnLapHDMoi_Click(object sender, EventArgs e)
        {
            new frmDSBNChuaCoHoaDon().ShowDialog();
            LoadHoaDonDaLap();
        }

        private void dgvDSHoaDonDaLap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mahoadon = dgvDSHoaDonDaLap.Rows[e.RowIndex].Cells["MAHD"].Value.ToString();
                new frmLapHoaDon(mahoadon).ShowDialog();
                LoadHoaDonDaLap();
            }
        }

        private void btnThemMoiCT_HoaDon_Click(object sender, EventArgs e)
        {
            new frmLapHoaDon(null).ShowDialog();
            LoadHoaDonDaLap();
        }

        private void dgvDSHoaDonDaLap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSHoaDonDaLap.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn: " + dgvDSHoaDonDaLap.Rows[e.RowIndex].Cells["MAHD"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var mahoadon = dgvDSHoaDonDaLap.Rows[e.RowIndex].Cells["MAHD"].Value.ToString();
                        var sql = "DeleteCT_HoaDon";
                        var lstPara = new List<CustormParameter>()
                    {
                        new CustormParameter
                        {
                            key = "@MAHD",
                            value = mahoadon
                        }
                    };

                        new Database().ExCute(sql, lstPara);
                        MessageBox.Show("Xóa hóa đơn thành công!");
                        LoadHoaDonDaLap();
                    }

                }
            }
        }
    }
}
