using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int MinArray(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int mid = left + (right - left) / 2;

            while (left < right)
            {
                if(numbers[mid] < numbers[right])
                {
                    right = mid;
                }
                else if(numbers[mid] == numbers[right])
                {
                    right -= 1;
                }
                else
                {
                    left = mid + 1;
                }

                mid = left + (right - left) / 2;
            }

            return numbers[left];
        }
    }
}
