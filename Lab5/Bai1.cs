using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai1
    {
        static void Main(string[] args) {
            Console.Write("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int max, min, sum = 0;
            if(x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
