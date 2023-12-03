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
    public partial class frmLapHoaDon : Form
    {
        public frmLapHoaDon()
        {
            InitializeComponent();
        }
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSBNChuaCoHoaDon();
            //custorm lại tên cột
            dgvBNChuaCoHoaDon.Columns["MABN"].HeaderText = "Mã bệnh nhân";
            dgvBNChuaCoHoaDon.Columns["TENBN"].HeaderText = "Tên bệnh nhân";
            dgvBNChuaCoHoaDon.Columns["TINHTRANGSUCKHOE"].HeaderText = "Tình trạng sức khỏe";
        }
        private void LoadDSBNChuaCoHoaDon()
        {
            List<CustormParameter> lstPara = new List<CustormParameter>()
            {

            };
            dgvBNChuaCoHoaDon.DataSource = new Database().SelectData("BNChuaCoHoaDon", lstPara);
        }
    }
}
