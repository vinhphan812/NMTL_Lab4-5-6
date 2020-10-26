using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bai7
    {
        static void Main(string[] args)
        {
            // Viết chương trình in ra tổng các số nguyên dương liên tiếp bắt đầu từ 1, sao cho tổng này nhỏ hơn 200.000
            int sum = 0, i = 1;
            while (sum + i < 200000)
            {
                sum = sum + i;
                i++;
            }
        }
    }
}
