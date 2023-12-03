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
    public partial class frmDSTHUOC : Form
    {
        public frmDSTHUOC()
        {
            InitializeComponent();
        }

        private void dgvThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mt = dgvThuoc.Rows[e.RowIndex].Cells["MATHUOC"].Value.ToString();
                new frmThuoc(mt).ShowDialog();
                LoadDSTHUOC();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmThuoc(null).ShowDialog();
            LoadDSTHUOC();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSTHUOC();
        }
        private string tukhoa = "";
        private void LoadDSTHUOC()
        {
            string sql = "SelectAllThuoc";
            List<CustormParameter> lstPara = new List<CustormParameter>();
            lstPara.Add(new CustormParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvThuoc.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void frmDSTHUOC_Load(object sender, EventArgs e)
        {
            LoadDSTHUOC();
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvThuoc.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa thuốc: " + dgvThuoc.Rows[e.RowIndex].Cells["TENTHUOC"].Value.ToString() + " ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var maThuoc = dgvThuoc.Rows[e.RowIndex].Cells["MATHUOC"].Value.ToString();
                        var sql = "DeleteThuoc";
                        var lstPara = new List<CustormParameter>()
                    {
                        new CustormParameter
                        {
                            key = "@MATHUOC",
                            value = maThuoc
                        }
                    };

                        new Database().ExCute(sql, lstPara);
                        MessageBox.Show("Xóa thuốc thành công!");
                        LoadDSTHUOC();
                    }

                }
            }
        }
    }
}
