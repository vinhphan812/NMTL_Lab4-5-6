using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    class Bai4
    {
        static int TongChuSo(int a)
        {
            int sum = 0;
            while(a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
    }
}
