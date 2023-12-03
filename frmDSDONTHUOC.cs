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
    public partial class frmDSDONTHUOC : Form
    {
        public frmDSDONTHUOC()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSDONTHUOC_Load(object sender, EventArgs e)
        {
            LoadDSDONTHUOC();
        }
        private void LoadDSDONTHUOC()
        {
            string sql = "SelectAllDonThuoc";
            List<CustormParameter> lstPara = new List<CustormParameter>()
            {
                new CustormParameter()
                {
                    key = "@TUKHOA",
                    value = tukhoa
                }
            };
            dgvDonThuoc.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSDONTHUOC();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmDonThuoc(null).ShowDialog();
            LoadDSDONTHUOC();
        }

        private void dgvDonThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mdt = dgvDonThuoc.Rows[e.RowIndex].Cells["MADT"].Value.ToString();
                new frmDonThuoc(mdt).ShowDialog();
                LoadDSDONTHUOC();
            }
        }

        private void dgvDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDonThuoc.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa đơn thuốc: " + dgvDonThuoc.Rows[e.RowIndex].Cells["MADT"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var maDonThuoc = dgvDonThuoc.Rows[e.RowIndex].Cells["MADT"].Value.ToString();
                        var sql = "DeleteDonThuoc";
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
                        LoadDSDONTHUOC();
                    }

                }
            }
        }
    }
}
