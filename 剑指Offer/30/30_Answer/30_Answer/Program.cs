using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MinStack
    {
        /** initialize your data structure here. */
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int x)
        {
            s1.Push(x);

            if (s2.Count == 0)
            {
                s2.Push(x);
            }
            else if (x <= s2.Peek())
            {
                s2.Push(x);
            }

            return;
        }

        public void Pop()
        {
            if (s1.Count == 0)
            {
                return;
            }
            if (s1.Pop() == s2.Peek())
            {
                int p = s2.Pop();
            }
            return;
        }

        public int Top()
        {
            if (s1.Count == 0)
            {
                return -1;
            }
            return s1.Peek();
        }

        public int Min()
        {
            if (s1.Count == 0)
            {
                return -1;
            }
            return s2.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.Min();
     */
}
