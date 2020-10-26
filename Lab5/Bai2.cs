using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i * i + " ");
            }
            Console.WriteLine();
        }
    }
}
