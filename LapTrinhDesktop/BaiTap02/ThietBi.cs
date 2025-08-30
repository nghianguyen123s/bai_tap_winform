using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class ThietBi
    {
        //Khai báo thuộc tính
        public string MaThietBi { get; set; }
        
        public string TenThietBi { get; set; }

        public string NuocSanXuat {  get; set; }
        
        public double DonGia {  get; set; }

        public int SoLuong {  get; set; }

        //Khởi tạo hàm có tham số
        public ThietBi(string ma, string ten, string nuoc, double gia, int sl)
        {
            MaThietBi = ma;
            TenThietBi = ten;
            NuocSanXuat = nuoc;
            DonGia = gia;
            SoLuong = sl;
        }

         // Phương thức tính thành tiền
        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        // Phương thức hiển thị thông tin
        public string HienThi()
        {
            return $"Mã: {MaThietBi}, Tên: {TenThietBi}, Nước SX: {NuocSanXuat}, " +
                   $"Đơn giá: {DonGia}, Số lượng: {SoLuong}," +
                   $"Thành tiền: {ThanhTien()}";
        }
    }
}
   

