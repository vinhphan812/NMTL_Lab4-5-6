using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Bai7
    {
        static void maxDigit(int n)
        {
            int max = 0;
            while(n > 0)
            {
                if (n % 10 > max)
                    max = n % 10;
                n /= 10;
            }
            Console.WriteLine(max);
        }
    }
}
