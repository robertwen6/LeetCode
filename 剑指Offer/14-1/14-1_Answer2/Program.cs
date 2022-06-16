using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_Answer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.CuttingRope(120));
        }
    }

    public class Solution
    {
        public int CuttingRope(int n)
        {
            long result = 1;
            if(n == 2)
            {
                return 1;
            }
            else if(n == 3)
            {
                return 2;
            }
            else if (n == 4)
            {
                return 4;
            }
            else
            {
                while (n > 4)
                {
                    
                    result = result * 3 % 1000000007;
                    n -= 3;
                }
                result = result * n % 1000000007;
                return (int)result;
            }
        }
    }
}
