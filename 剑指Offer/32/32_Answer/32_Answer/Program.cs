using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public int[] LevelOrder(TreeNode root)
        {
            List<int> l = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();
                if (node == null)
                {
                    continue;
                }
                else
                {
                    l.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            return l.ToArray();
        }
    }
}
