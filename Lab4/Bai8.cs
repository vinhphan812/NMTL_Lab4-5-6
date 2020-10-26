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
            //viết chương trình yêu cầu người dùng nhập số nguyên dương n. In ra tổng lớn nhất
            //của các số nguyên dương liên tiếp bắt đầu từ 1, sao cho tổng nhỏ hơn n.
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
