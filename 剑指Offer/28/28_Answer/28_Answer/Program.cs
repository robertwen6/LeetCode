using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Answer
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    
    public class Solution
    {
        List<int> leftArray = new List<int>();
        List<int> rightArray = new List<int>();

        public bool IsSymmetric(TreeNode root)
        {
            MakeLeftArray(root);
            MakeRightArray(root);
            for(int i = 0; i < leftArray.Count; i++)
            {
                if(leftArray[i] != rightArray[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void MakeLeftArray(TreeNode root)
        {
            if (root == null)
            {
                leftArray.Add(-1);
            }
            else
            {
                leftArray.Add(root.val);
                MakeLeftArray(root.left);
                MakeLeftArray(root.right);
            }
            return;
        }

        public void MakeRightArray(TreeNode root)
        {
            if (root == null)
            {
                rightArray.Add(-1);
            }
            else
            {
                rightArray.Add(root.val);
                MakeRightArray(root.right);
                MakeRightArray(root.left);
            }
        }
    }
}
