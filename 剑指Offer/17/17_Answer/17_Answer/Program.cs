using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] PrintNumbers(int n)
        {
            int maxNum = GetMaxNum(n);
            int[] result = new int[maxNum];
            for(int i = 1; i <= maxNum; i++)
            {
                result[i - 1] = i;
            }
            return result;
        }

        public int GetMaxNum(int n)
        {
            int maxNum = 0;
            while(n > 0)
            {
                maxNum = maxNum * 10 + 9;
                n--;
            }
            return maxNum;
        }
    }
}
