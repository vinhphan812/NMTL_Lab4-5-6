using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Bai6
    {
        static void uocSo(int n)
        {
            int index = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    index++;
            Console.WriteLine(index);
        }
    }
}
