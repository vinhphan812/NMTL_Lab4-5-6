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
            //Input: Số nguyên	n (1 ≤ n ≤ 1.000) là số chai bia anh Bo	mua	ban	đầu.
            //Output: Số nguyên	m là tổng số chai nước ngọt	mà	anh	Bo có thể uống.
            //Ví dụ: n	= 10 --> m = 13; n = 24 --> m =	33.
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
