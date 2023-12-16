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
    public partial class frmDSDonThuocDaLap : Form
    {
        public frmDSDonThuocDaLap()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSDonThuocDaLap_Load(object sender, EventArgs e)
        {
            LoadDonThuocDaLap();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDonThuocDaLap();
        }
        private void LoadDonThuocDaLap()
        {
            List<CustormParameter> lst = new List<CustormParameter>()
            {
                new CustormParameter()
                {
                    key = "@TUKHOA",
                    value = tukhoa
                }
            };
            dgvDSDonThuocDaLap.DataSource = new Database().SelectData("DonThuocDaLap", lst);
        }
        private void btnLapDTMoi_Click(object sender, EventArgs e)
        {
            new frmDSBNChuaCoDonThuoc().ShowDialog();
            LoadDonThuocDaLap();
        }

        private void dgvDSDonThuocDaLap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var madonthuoc = dgvDSDonThuocDaLap.Rows[e.RowIndex].Cells["MADT"].Value.ToString();
                new frmLapDonThuoc(madonthuoc).ShowDialog();
                LoadDonThuocDaLap();
            }
        }

        private void btnThemMoiCT_DonThuoc_Click(object sender, EventArgs e)
        {
            new frmLapDonThuoc(null).ShowDialog();
            LoadDonThuocDaLap();
        }

        private void dgvDSDonThuocDaLap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDSDonThuocDaLap.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa đơn thuốc: " + dgvDSDonThuocDaLap.Rows[e.RowIndex].Cells["MADT"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var maDonThuoc = dgvDSDonThuocDaLap.Rows[e.RowIndex].Cells["MADT"].Value.ToString();
                        var sql = "DeleteCT_DonThuoc";
                        var lstPara = new List<CustormParameter>()
                    {
                        new CustormParameter
                        {
                            key = "@MADT",
                            value = maDonThuoc
                        }
                    };

                        new Database().ExCute(sql, lstPara);
                        MessageBox.Show("Xóa thuốc thành công!");
                        LoadDonThuocDaLap();
                    }

                }
            }
        }
    }
}
