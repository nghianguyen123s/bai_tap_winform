using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaiTap03.XuLyChuoiVaSo;

namespace BaiTap03
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTachChuoi_Click(object sender, EventArgs e)
        {
            string ho, ten;
            XuLy.TachChuoi(txtHoTen.Text, out ho, out ten);

            lblHo.Text = "Họ: " + ho;
            lblTen.Text = "Tên: " + ten;
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            int n1, n2;
            if (int.TryParse(txtSoN1.Text, out n1) && int.TryParse(txtSoN2.Text, out n2))
            {
                // Gọi hàm bool ThuTu
                bool ketQua = XuLy.ThuTu(n1, n2);

                if (ketQua)
                    lblKiemTra.Text = $"{n1} và {n2} là 2 số liên tiếp.";
                else
                    lblKiemTra.Text = $"{n1} và {n2} KHÔNG phải là số liên tiếp.";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }
    }
}
