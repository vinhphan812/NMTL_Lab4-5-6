using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai10
    {
        static void Main(string[] args)
        {
            int n = 0, sum;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 && n >= 1000);

            for (int i = 1; 10 * i <= n; i++)
            {
                n += 3;
            }
            Console.WriteLine(n);
        }
    }
}
