using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Answer1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if(preorder.Length == 0)
            {
                return null;
            }

            TreeNode node = new TreeNode(preorder[0]);

            int index = Array.IndexOf(inorder, preorder[0]);

            //创建左节点
            int[] newPreorderOfLeft = new int[index];
            int[] newInorderOfLeft = new int[index];
            if (newPreorderOfLeft.Length == 0)
            {
                node.left = null;
            }
            else
            {
                Array.Copy(preorder, 1, newPreorderOfLeft, 0, index);
                Array.Copy(inorder, 0, newInorderOfLeft, 0, index);
                node.left = BuildTree(newPreorderOfLeft, newInorderOfLeft);
            }
            //创建右节点
            int[] newPreorderOfRight = new int[inorder.Length - index - 1];
            int[] newInorderOfRight = new int[inorder.Length - index - 1];
            if (newPreorderOfRight.Length == 0)
            {
                node.right = null;
            }
            else
            {
                Array.Copy(preorder, index + 1, newPreorderOfRight, 0, inorder.Length - index - 1);
                Array.Copy(inorder, index + 1, newInorderOfRight, 0, inorder.Length - index - 1);
                node.right = BuildTree(newPreorderOfRight, newInorderOfRight);
            }

            return node;
        }
    }
}
