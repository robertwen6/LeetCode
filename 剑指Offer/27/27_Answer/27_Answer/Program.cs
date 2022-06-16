using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Answer
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
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null) return null;
            TreeNode newTree = new TreeNode(0);
            newTree.val = root.val;
            newTree.left = MirrorTree(root.right);
            newTree.right = MirrorTree(root.left);
            return newTree;
        }
    }
}
