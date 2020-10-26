using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai4
    {
        static void Main(string[] args)
        {
            float sum = 0;
            for (float i = 1; i <= 100; i++)
                sum += 1 / i;
            Console.WriteLine(sum);
        }
    }
}
