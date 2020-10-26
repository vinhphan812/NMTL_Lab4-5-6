using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai8
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; sum + i < n; i++)
            {
                sum = sum + i; // sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
