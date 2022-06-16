using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Answer2
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
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (d.ContainsKey(num))
                {
                    return num;
                }
                else
                {
                    d.Add(num, nums[num]);
                }
            }
            return -1;
        }
    }
}
