using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Answer3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public int[] ReversePrint(ListNode head)
        {
            List<int> l = new List<int>();
            Stack<int> stk = new Stack<int>();
            while(head != null)
            {
                stk.Push(head.val);
                head = head.next;
            }

            while(stk.Count > 0)
            {
                l.Add(stk.Pop());
            }
            return l.ToArray();
        }
    }
}
