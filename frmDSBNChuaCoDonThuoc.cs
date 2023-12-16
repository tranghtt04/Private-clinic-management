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
    public partial class frmDSBNChuaCoDonThuoc : Form
    {
        public frmDSBNChuaCoDonThuoc()
        {
            InitializeComponent();
        }
        
        private void LoadDSBNChuaCoDonThuoc()
        {
            List<CustormParameter> lstPara = new List<CustormParameter>()
            {

            };
            dgvBNChuaCoDonThuoc.DataSource = new Database().SelectData("BNChuaCoDonThuoc",lstPara);
        }

        private void dgvBNChuaCoDonThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new frmDSDONTHUOC().ShowDialog();
                LoadDSBNChuaCoDonThuoc();
            }
        }

        private void frmDSBNChuaCoDonThuoc_Load(object sender, EventArgs e)
        {
            LoadDSBNChuaCoDonThuoc();
            //custorm lại tên cột
            dgvBNChuaCoDonThuoc.Columns["MABN"].HeaderText = "Mã bệnh nhân";
            dgvBNChuaCoDonThuoc.Columns["TENBN"].HeaderText = "Tên bệnh nhân";
            dgvBNChuaCoDonThuoc.Columns["TINHTRANGSUCKHOE"].HeaderText = "Tình trạng sức khỏe";
        }
    }
}
