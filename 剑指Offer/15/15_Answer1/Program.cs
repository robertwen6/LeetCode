using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int counter = 0;
            while(n > 0)
            {
                if(n % 2 == 1)
                {
                    counter++;
                }
                n /= 2;
            }
            return counter;
        }
    }
}
