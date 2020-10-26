using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai6
    {
        static void Main(string[] args)
        {
            //Viết chương trình in ra các số nguyên chẳn từ 1 đến 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
}
}
