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
    public partial class frmDSDVKHAM : Form
    {
        public frmDSDVKHAM()
        {
            InitializeComponent();
        }

        private void dgvDVKham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mdv = dgvDVKham.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                new frmDVKham(mdv).ShowDialog();
                LoadDSDVKHAM();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmDVKham(null).ShowDialog();
            LoadDSDVKHAM();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSDVKHAM();
        }
        private string tukhoa = "";
        private void LoadDSDVKHAM()
        {
            string sql = "SelectAllDVKham";
            List<CustormParameter> lstPara = new List<CustormParameter>();
            lstPara.Add(new CustormParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvDVKham.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSDVKHAM_Load(object sender, EventArgs e)
        {
            LoadDSDVKHAM();
        }

        private void dgvDVKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvDVKham.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa dịch vụ khám: " + dgvDVKham.Rows[e.RowIndex].Cells["TENDV"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var madvkham = dgvDVKham.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                        var sql = "DeleteDVKham";
                        var lstPara = new List<CustormParameter>()
                    {
                        new CustormParameter
                        {
                            key = "@MADV",
                            value = madvkham
                        }
                    };

                        new Database().ExCute(sql, lstPara);
                        MessageBox.Show("Xóa dịch vụ khám thành công!");
                        LoadDSDVKHAM();
                    }

                }
            }
        }
    }
}
