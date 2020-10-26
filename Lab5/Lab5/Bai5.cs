using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai5
    {
        static void Main(string[] args)
        {
            float sum = 0, j = 1;
            for (float i = 1; i <= 39; i += 2)
            {
                Console.WriteLine((i) + "/" + (j));
                sum += i / j;
                j *= 2;
            }
            Console.WriteLine(sum);
        }
    }
}
