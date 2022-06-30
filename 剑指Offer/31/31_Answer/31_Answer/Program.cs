using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            if (pushed.Length != popped.Length)
            {
                return false;
            }
            else if (pushed.Length == 0 && popped.Length == 0)
            {
                return true;
            }

            Stack<int> s = new Stack<int>();
            int indexOfPushed = 0;
            int indexOfPopped = 0;

            while (indexOfPushed < pushed.Length)
            {
                s.Push(pushed[indexOfPushed]);
                while (s.Count > 0 && s.Peek() == popped[indexOfPopped])
                {
                    s.Pop();
                    indexOfPopped++;
                }
                indexOfPushed++;
            }
            if (s.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
