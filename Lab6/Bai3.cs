using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Bai3
    {
        static void TinhTong(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            Console.WriteLine(sum);
        }
    }
}
