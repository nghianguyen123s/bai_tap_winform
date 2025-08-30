using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap04
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }

        // Hàm tạo không tham số
        public SanPham()
        {

        }

        // lấy năm hết hạn sử dụng (3 năm sau ngày sản xuất)
        public DateTime NamHetHan()
        {
            return NgaySanXuat.AddYears(3);
        }

        // Hiển thị thông tin
        public string HienThi()
        {
            return $"Mã Sản Phẩm: {MaSanPham}" +
                $"\nTên Sản Phẩm: {TenSanPham}" +
                $"\nLoại Sản Phẩm: {LoaiSanPham}" +
                $"\nNgày Sản Xuất: {NgaySanXuat.ToShortDateString()}" +
                $"\nHạn sử dụng: {NamHetHan().ToShortDateString()}";
        }
    }
}
