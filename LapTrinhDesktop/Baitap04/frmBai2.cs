using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap04
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            double diemLT = double.Parse(txtLyThuyet.Text);
            double diemTH = double.Parse(txtThucHanh.Text);

            string ketQua = "";
            if (diemLT < 5 || diemTH < 5)
                ketQua = "Yếu";
            else
            {
                double dtb = (diemLT + diemTH) / 2;
                if (dtb < 7)
                    ketQua = "Trung bình";
                else if (dtb < 8)
                    ketQua = "Khá";
                else if(dtb < 9)
                    ketQua = "Giỏi";
                else
                {
                    ketQua = "Xuất sắc";
                }
            }

            lblKetQua.Text = "Kết quả xếp loại: " + ketQua;
        }
    }
}
