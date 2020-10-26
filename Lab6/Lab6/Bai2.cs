using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Bai2
    {
        static int findMin(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
    }
}
