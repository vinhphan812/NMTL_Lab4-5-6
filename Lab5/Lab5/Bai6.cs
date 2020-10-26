using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai6
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    Console.Write(i);
        }
    }
}
