using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else if(n == 1)
            {
                return x;
            }
            else if(n == -1)
            {
                return 1 / x;
            }
            else
            {
                double a = MyPow(x, n / 2);
                return a * a * MyPow(x, n - (n / 2) * 2);
            }
        }
    }
}
