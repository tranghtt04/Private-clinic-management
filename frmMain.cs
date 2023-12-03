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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelCome f = new frmWelCome();
            AddForm(f);
        }
        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWelCome f = new frmWelCome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void benhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSBN f = new frmDSBN();
            AddForm(f);
        }

        private void bacSiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSBS f = new frmDSBS();
            AddForm(f);
        }

        private void thuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSTHUOC f = new frmDSTHUOC();
            AddForm(f);
        }

        private void dichVuKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDVKHAM f = new frmDSDVKHAM();
            AddForm(f);
        }

        private void donThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSDONTHUOC f = new frmDSDONTHUOC();
            AddForm(f);
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSHOADON f = new frmDSHOADON();
            AddForm(f);
        }

        private void lapHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSHoaDonDaLap();
            AddForm(f);
        }

        private void lapDonThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDSDonThuocDaLap();
            AddForm(f);
        }
    }
}
