using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class CQueue
    {
        Stack<int> head = new Stack<int>();
        Stack<int> tail = new Stack<int>();
        public CQueue()
        {
        }

        public void AppendTail(int value)
        {
            tail.Push(value);
        }

        public int DeleteHead()
        {
            if (head.Count() > 0)
            {
                return head.Pop();
            }
            else if(tail.Count() > 0)
            {
                while(tail.Count() > 0)
                {
                    head.Push(tail.Pop());
                }
                return head.Pop(); ;
            }
            else
            {
                return -1;
            }
        }
    }
}
