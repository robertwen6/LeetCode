using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Answer
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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode node = head;
            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    node.next = l1;
                    node = node.next;
                    l1 = l1.next;
                }
                else
                {
                    node.next = l2;
                    node = node.next;
                    l2 = l2.next;
                }
            }
            if(l1 == null)
            {
                node.next = l2;
            }
            else
            {
                node.next = l1;
            }
            return head.next;
        }
    }
}
