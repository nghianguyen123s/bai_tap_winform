using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap03
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtSoN.Text);
            long ketqua = 0;

            if (rdTinhTong.Checked)
            {
                ketqua = 0;
                for (int i = 1; i <= N; i++)
                    ketqua += i;
            }
            else if (rdTinhGiaiThua.Checked)
            {
                ketqua = 1;
                for (int i = 1; i <= N; i++)
                    ketqua *= i;
            }

            lblXemKetQua.Text = "Kết quả là: " + ketqua;
        }
    }
}
