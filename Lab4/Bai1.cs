using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai1
    {
        static void Main(string[] args)
        {
            // Viết chương trình in ra các số nguyên từ 1 đến 100 (các số cách nhau	bởi	khoảng trắng).
            //Ví dụ: 1 2 3...98	99 100
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
