using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai4
    {
        static void Main(string[] args)
        {
            //Viết chương trình	in ra các số nguyên	lẻ từ 1	đến	100	(các số cách nhau bởi khoảng trắng).
            //Ví dụ: 1 3 5 ………	95 97 99	
            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
