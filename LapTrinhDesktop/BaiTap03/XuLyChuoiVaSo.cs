using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap03
{
    internal class XuLyChuoiVaSo
    {
        public static class XuLy
        {
            // Hàm tách chuỗi: hoten -> s1 (họ), s2 (tên)
            public static void TachChuoi(string hoten, out string s1, out string s2)
            {
                hoten = hoten.Trim(); // bỏ khoảng trắng thừa
                int vt = hoten.LastIndexOf(' '); // tìm vị trí khoảng trắng cuối cùng

                if (vt > 0)
                {
                    s1 = hoten.Substring(0, vt);       // phần họ
                    s2 = hoten.Substring(vt + 1);      // phần tên
                }
                else
                {
                    s1 = hoten;   // nếu không có khoảng trắng thì coi cả chuỗi là họ
                    s2 = "";
                }
            }

            // Hàm kiểm tra n1, n2 có liên tiếp không
            public static bool ThuTu(int n1, int n2)
            {
                return (n2 == n1 + 1);
            }
        }
    }
}
