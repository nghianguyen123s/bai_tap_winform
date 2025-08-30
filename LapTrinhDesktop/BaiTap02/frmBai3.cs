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
    public partial class frmBai3 : Form
    {
        XuLyChuoiVaSo xl = new XuLyChuoiVaSo();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnNoiChuoi_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;   
            string ten = txtTen.Text; 
            string kq = "";         

            xl.NoiChuoi(ho, ten, ref kq); 
            lblNoiChuoi.Text = "Họ và Tên: " + kq; 
        }

        // Sự kiện khi bấm nút "Tính Giai Thừa"
        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtGiaiThua.Text, out n) && n >= 0) // kiểm tra nhập số >= 0
            {
                long kq = xl.GiaiThua(n); // Gọi hàm giai thừa
                lblGiaiThua.Text = n + "! = " + kq;
            }
            else
            {
                MessageBox.Show("Nhập sai! Vui lòng nhập lại!");
            }
        }
    }

}
