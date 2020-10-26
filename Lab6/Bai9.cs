using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab6
{
    class Bai9
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void CapSoCong(ref int a, ref int b, ref int c)
        {
            if (a > b)
                swap(ref a, ref b);
            if (a > c)
                swap(ref a, ref c);
            if (b > c)
                swap(ref b, ref c);
            if (a - b == b - c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            Console.Write(a + " " + b + " " + c);
        }
    }
}
