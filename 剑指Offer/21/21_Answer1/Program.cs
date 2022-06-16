using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] Exchange(int[] nums)
        {
            int indexHead = 0;
            int indexTail = nums.Length - 1;

            while(indexHead < indexTail)
            {
                if((nums[indexHead] & 1) == 1)
                {
                    indexHead++;
                    continue;
                }
                if((nums[indexTail] & 1) == 0)
                {
                    indexTail--;
                    continue;
                }
                int temp = 0;
                temp = nums[indexHead];
                nums[indexHead] = nums[indexTail];
                nums[indexTail] = temp;
            }
            return nums;
        }
    }
}
