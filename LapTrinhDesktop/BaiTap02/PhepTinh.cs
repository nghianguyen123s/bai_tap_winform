using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    internal class PhepTinh
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }
        public static void TruHaiSo(int a, int b, ref int s)
        {
            s = a - b;
        }
        public static void NhanHaiSo(int a, int b, ref int s)
        {
            s = a * b;
        }
        public static void ChiaHaiSo(int a, int b, ref int s)
        {
            s = a / b;
        }
    }
}
