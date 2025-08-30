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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void ccbMaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thứ tự các mặt hàng được chọn
            var stt=ccbMaThietBi.SelectedIndex;
            switch (stt)
            {
                // Tên các thiết bị
                case 0:
                    txtTenThietBi.Text = "Chuột";
                    break;
                case 1:
                    txtTenThietBi.Text = "Máy in";
                    break;
                case 2:
                    txtTenThietBi.Text = "Bàn phím";
                    break;
            }
            switch (stt)
            {
                // Tên nước sản xuất
                case 0:
                    txtNuocSanXuat.Text = "Việt Nam";
                    break;
                case 1:
                    txtNuocSanXuat.Text = "Việt Nam";
                    break;
                case 2:
                    txtNuocSanXuat.Text = "Việt Nam";
                    break;
            }
            switch (stt)
            {
                // Giá tiền từng thiết bị
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string ma = ccbMaThietBi.Text;
            string ten = txtTenThietBi.Text;
            string nuoc = txtNuocSanXuat.Text;
            double gia = double.Parse(txtDonGia.Text);
            int sl = int.Parse(txtSoLuong.Text);

            // Tạo đối tượng thiết bị
            ThietBi tb = new ThietBi(ma, ten, nuoc, gia, sl);

            // Hiển thị thông tin
            lblHienThi.Text = tb.HienThi();
        }

        private void lblHienThi_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }
    }
}
