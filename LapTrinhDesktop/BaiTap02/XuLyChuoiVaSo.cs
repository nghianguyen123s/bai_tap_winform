using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class XuLyChuoiVaSo
    {
        // Hàm nối chuỗi họ + tên
        public void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }

        // Hàm tính giai thừa của số nguyên dương n
        public long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }
    }
}
