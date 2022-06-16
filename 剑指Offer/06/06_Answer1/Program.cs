using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Answer1
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
            while(head != null)
            {
                l.Add(head.val);
                head = head.next;
            }
            l.Reverse();
            return l.ToArray();
        }
    }
}
