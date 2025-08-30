using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap02
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThuNhat.Text);
            int b = int.Parse(txtSoThuHai.Text);
            int kq = 0;

            if (rdCong.Checked)
            {
                PhepTinh.CongHaiSo(a, b, ref kq);
            }
            else if (rdTru.Checked)
            {
                PhepTinh.TruHaiSo(a, b, ref kq);
            }
            else if (rdNhan.Checked)
            {
                PhepTinh.NhanHaiSo(a, b, ref kq);
            }
            else
            {
                PhepTinh.ChiaHaiSo(a, b, ref kq);
            }
                //Hiển thị kết quả
                lblXemKetQua.Text = kq.ToString();
        }
    }
}
