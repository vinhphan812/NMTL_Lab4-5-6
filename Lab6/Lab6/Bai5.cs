using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Bai5
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = a;
        }
    }
}
