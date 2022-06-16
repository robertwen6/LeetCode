using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int CuttingRope(int n)
        {
            int[] dp = new int[59];
            dp[2] = 1;
            dp[3] = 2;
            for (int i = 4; i <= n; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    dp[i] = Math.Max(j * (i - j), dp[i]);
                    dp[i] = Math.Max(j * dp[i - j], dp[i]);
                }
            }
            return dp[n];
        }
    }
}
