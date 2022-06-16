using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Answer2
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
        List<int> l = new List<int>();
        public int[] ReversePrint(ListNode head)
        {
            DFS(head);
            return l.ToArray();
        }

        public void DFS(ListNode node)
        {
            if(node == null)
            {
                return;
            }
            else
            {
                DFS(node.next);
                l.Add(node.val);
                return;
            }
        }
    }
}
