using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Answer1
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
        public ListNode DeleteNode(ListNode head, int val)
        {
            ListNode node = new ListNode(0);
            node = head;
            ListNode nextNode = new ListNode(0);
            nextNode = node.next;
            
            if(head.val == val)
            {
                return head.next;
            }
            else
            {
                while (nextNode != null)
                {
                    if(nextNode.val != val)
                    {
                        node = nextNode;
                        nextNode = nextNode.next;
                        continue;
                    }
                    else
                    {
                        node.next = nextNode.next;
                        break;
                    }
                }
                return head;
            }

        }
    }
}
