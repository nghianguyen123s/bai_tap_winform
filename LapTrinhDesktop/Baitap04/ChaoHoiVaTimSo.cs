using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap04
{
    internal class ChaoHoiVaTimSo
    {
  

        public class UCLN
{
          public int USCLN(int m, int n)
    {
        while (n != 0)
        {
            int temp = n;
            n = m % n;
            m = temp;
        }
        return m;
    }
}
    }
}
