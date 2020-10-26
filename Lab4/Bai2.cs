using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai2
    {
        static void Main(string[] args)
        {
            //Viết chương trình	yêu	cầu	người dùng nhập	số nguyên n. In	ra các số nguyên dương	
            //lớp hơn 0 và nhỏ hơn n
            //Ví dụ: n = 5 --> In ra màn hình 1 2 3 4
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
