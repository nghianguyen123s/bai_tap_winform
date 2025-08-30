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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên
            NhanVien nv = new NhanVien(
                txtMaNV.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                double.Parse(txtHSL.Text),
                double.Parse(txtHSPC.Text)
            );

            // Hiển thị thông tin đầy đủ
            lblHienThi.Text = nv.HienThi();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên
            NhanVien nv = new NhanVien(
                txtMaNV.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                double.Parse(txtHSL.Text),
                double.Parse(txtHSPC.Text)
            );

            // Chỉ hiển thị tổng lương
            lblTinhLuong.Text = $"Tổng lương của {nv.HoTen} là: {nv.TongLuong():N0} VND";
        }

        private void lblTinhLuong_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
