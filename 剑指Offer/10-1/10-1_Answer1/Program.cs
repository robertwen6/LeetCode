using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int Fib(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                int num1 = 0;
                int num2 = 1;
                int result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result = (num1 + num2) % 1000000007;
                    num1 = num2;
                    num2 = result;
                }
                return result;
            }
        }
    }
}
