using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai9
    {
        static void Main(string[] args)
        {
            //Viết chương trình	yêu	cầu	người dùng nhập	vào	một	số nguyên, sao cho số này phải
            int n = 0;
            do
            {
                Console.Write("Nhap So: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 100 || n > 500 && n % 2 == 0);
        }
    }
}
