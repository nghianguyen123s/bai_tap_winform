using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class FormBaiTap2 : System.Windows.Forms.Form
    {
        public FormBaiTap2()
        {
            InitializeComponent();
        }

        private void lbDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void FormBaiTap2_Load(object sender, EventArgs e)
        {

        }

        private void btnChonhang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (var hang in listBox2.Items)
            {
                switch (hang)
                { 
                    case "Chuột":
                        soTien += 100000;
                        break;
                        case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "USB KingMax":
                        soTien += 200000;
                        break;
                    case "Máy in":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
               lbTien.Text = soTien + " VND";
            }
        }

        private void lbTongtien_Click(object sender, EventArgs e)
        {

        }
    }
}
