using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int FindRepeatNumber(int[] nums)
        {
            for (int i = 0; i < nums.Count(); i++)
            {
                while (nums[i] != i)
                {
                    if (nums[nums[i]] == nums[i])
                    {
                        return nums[i];
                    }
                    else
                    {
                        int temp = nums[nums[i]];
                        nums[nums[i]] = nums[i];
                        nums[i] = temp;
                    }
                }
            }
            return -1;
        }
    }
}
