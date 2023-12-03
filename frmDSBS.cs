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
    public partial class frmDSBS : Form
    {
        public frmDSBS()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            loadDSBS();
        }
        private string tukhoa = "";
        private void loadDSBS()
        {
            string sql = "SelectAllBacSi";
            List<CustormParameter> lstPara = new List<CustormParameter>();
            lstPara.Add(new CustormParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvBacSi.DataSource = new Database().SelectData(sql,lstPara);
        }

        private void frmDSBS_Load(object sender, EventArgs e)
        {
            loadDSBS();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmBacSi(null).ShowDialog();
            loadDSBS();
        }
        

        private void dgvBacSi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mbs = dgvBacSi.Rows[e.RowIndex].Cells["MABS"].Value.ToString();
                new frmBacSi(mbs).ShowDialog();
                loadDSBS();
            }
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgvBacSi.Columns["btnXoa"].Index)
                {
                    if (
                        MessageBox.Show("Bạn chắc chắn muốn xóa bác sĩ: " + dgvBacSi.Rows[e.RowIndex].Cells["TENBS"].Value.ToString()+" ?",
                        "Xác nhận xóa!!!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        var maBS = dgvBacSi.Rows[e.RowIndex].Cells["MABS"].Value.ToString();
                        var sql = "DeleteBS";
                        var lstPara = new List<CustormParameter>()
                    {
                        new CustormParameter
                        {
                            key = "@MABS",
                            value = maBS
                        }
                    };

                        new Database().ExCute(sql, lstPara);
                        MessageBox.Show("Xóa bác sĩ thành công!");
                        loadDSBS();
                    }
                    
                }
            }
        }
    }
}
