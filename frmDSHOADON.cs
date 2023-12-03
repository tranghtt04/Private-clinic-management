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
    public partial class frmDSHOADON : Form
    {
        public frmDSHOADON()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSHOADON_Load(object sender, EventArgs e)
        {
            LoadDSHOADON();
        }
        private void LoadDSHOADON()
        {
            string sql = "SelectAllHoaDon";
            List<CustormParameter> lstPara = new List<CustormParameter>()
            {
                new CustormParameter()
                {
                    key = "@TUKHOA",
                    value = tukhoa
                }
            };
            dgvHoaDon.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSHOADON();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmHoaDon(null).ShowDialog();
            LoadDSHOADON();
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mhd = dgvHoaDon.Rows[e.RowIndex].Cells["MAHD"].Value.ToString();
                new frmHoaDon(mhd).ShowDialog();
                LoadDSHOADON();
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvHoaDon.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn: " + dgvHoaDon.Rows[e.RowIndex].Cells["MAHD"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var mahoadon = dgvHoaDon.Rows[e.RowIndex].Cells["MAHD"].Value.ToString();
                        var sql = "DeleteHoaDon";
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
                        LoadDSHOADON();
                    }

                }
            }
        }
    }
}
