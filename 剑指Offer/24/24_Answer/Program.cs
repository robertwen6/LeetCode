using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Answer
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
        public ListNode ReverseList(ListNode head)
        {
            ListNode node1 = null;
            ListNode node2 = head;
            ListNode temp = new ListNode(0);

            while(node2 != null)
            {
                temp = node2.next;
                node2.next = node1;
                node1 = node2;
                node2 = temp;
            }
            return node2;
        }
    }
}
