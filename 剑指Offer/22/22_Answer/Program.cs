using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Answer
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
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            ListNode node1 = new ListNode(0);
            node1 = head;
            ListNode node2 = new ListNode(0);
            node2 = head;
            for (int i = 1; i < k; i++)
            {
                node2 = node2.next;
                if(node2 == null)
                {
                    return null;
                }
            }
            while(node2.next != null)
            {
                node1 = node1.next;
                node2 = node2.next;
            }
            return node1;
        }
    }
}
