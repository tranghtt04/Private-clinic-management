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
            new frmLapHoaDon().ShowDialog();
            LoadHoaDonDaLap();
        }
    }
}
