using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Answer
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
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if (A == null || B == null) return false;
            return IsAHasB(A, B) || IsSubStructure(A.left, B) || IsSubStructure(A.right, B);
        }
        public bool IsAHasB(TreeNode A, TreeNode B)
        {
            if (B == null) return true;
            if (A == null) return false;
            if (A.val != B.val) return false;
            return IsAHasB(A.left, B.left) && IsAHasB(A.right, B.right);
        }
    }
}
