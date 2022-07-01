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
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> l = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            Stack<TreeNode> s = new Stack<TreeNode>();

            int numLayer = 0;

            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> lLayer = new List<int>();
                int lCount = q.Count;

                for (int i = 0; i < lCount; i++)
                {
                    TreeNode node = q.Dequeue();
                    if (node == null)
                    {
                        continue;
                    }
                    else
                    {
                        lLayer.Add(node.val);
                        if (numLayer % 2 == 0)
                        {
                            s.Push(node.left);
                            s.Push(node.right);
                        }
                        else
                        {
                            s.Push(node.right);
                            s.Push(node.left);
                        }
                    }
                }

                int sCount = s.Count;
                for (int i = 0; i < sCount; i++)
                {
                    q.Enqueue(s.Pop());
                }

                numLayer++;

                if (lLayer.Count > 0)
                {
                    l.Add(lLayer);
                }
            }
            return l;
        }
    }
}
