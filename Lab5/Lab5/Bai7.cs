using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Bai7
    {
        static void Main(string[] args)
        {
            int sum = 0, n;
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    sum += i;
            if (sum == n)
                Console.WriteLine(n + "La So Hoan Hao");
            else
                Console.WriteLine(n + "Khong La So Hoan Hao");
        }
    }
}
