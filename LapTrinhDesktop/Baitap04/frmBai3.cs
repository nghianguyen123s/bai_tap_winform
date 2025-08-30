using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Baitap04.ChaoHoiVaTimSo;

namespace Baitap04
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void btnChaoHoi_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            bool gioitinh = rdNam.Checked; // nếu chọn Nam thì True, còn lại False
            if (gioitinh = true)
                lblChaoHoi.Text="Chào Ông " + hoten;
            else
                lblChaoHoi.Text="Chào Bà " + hoten;
           
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            UCLN ucln = new UCLN();
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = ucln.USCLN(m, n);
            lblKetQua.Text="Ước số chung lớn nhất: " + kq;
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
