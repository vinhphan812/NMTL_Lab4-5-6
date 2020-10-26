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
            int sum = 0, i = 1;
            while (sum + i < 200000)
            {
                sum = sum + i;
                i++;
            }
        }
    }
}
