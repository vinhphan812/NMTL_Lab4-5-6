using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai3
    {
        static void Main(string[] args)
        {
            //Viết chương trình	in ra các số nguyên	chẵn từ 1 đến 100 (các số cách nhau bởi khoảng trắng).
            //Ví dụ: 2 4 6 ……… 96 98 100
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
