using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    internal class NhanVien
    {
        // Thuộc tính
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        // Hàm khởi tạo có tham số
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, double hsl, double hspc)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = hsl;
            HeSoPhuCap = hspc;
        }

        // Phương thức tính tổng lương
        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        // Phương thức hiển thị thông tin
        public string HienThi()
        {
            return $"Mã NV: {MaNV}\nHọ tên: {HoTen}\nNgày sinh: {NgaySinh.ToShortDateString()}\n" +
                   $"Hệ số lương: {HeSoLuong}\nHệ số phụ cấp: {HeSoPhuCap}\n" +
                   $"Tổng lương: {TongLuong():N0}";
        }
    }
}
