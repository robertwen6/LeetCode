using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Answer3
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
            HashSet<int> hs = new HashSet<int>();
            foreach (var num in nums)
            {
                if(hs.Add(num) == false)
                {
                    return num;
                }
            }
            return -1;
        }

        //public int FindRepeatNumber(int[] nums)
        //{
        //    Hashtable ht = new Hashtable();
        //    foreach (var num in nums)
        //    {
        //        if (ht.ContainsKey(num) == true)
        //        {
        //            return num;
        //        }
        //        else
        //        {
        //            ht.Add(num, nums[num]);
        //        }
        //    }
        //    return -1;
        //}
    }
}
