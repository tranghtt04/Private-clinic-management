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
            new frmLapDonThuoc().ShowDialog();
            LoadDonThuocDaLap();
        }
    }
}
