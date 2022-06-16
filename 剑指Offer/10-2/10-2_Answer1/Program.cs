using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int NumWays(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            else if(n == 1)
            {
                return 1;
            }
            else if(n == 2)
            {
                return 2;
            }
            else
            {
                int num1 = 1;
                int num2 = 2;
                int result = 0;
                for (int i = 3; i <= n; i++)
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
