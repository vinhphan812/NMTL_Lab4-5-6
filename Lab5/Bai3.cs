using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai3
    {
        static void Main(string[] args)
        {
            int n = 0, giaiThua = 1;
            do
            {
                Console.Write("Nhap n (1 < n < 13): ");

                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 && n >= 13);
            for (int i = 2; i <= n; i++)
                giaiThua *= i;
            Console.WriteLine("Giai Thua: " + giaiThua);
        }
    }
}
