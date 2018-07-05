using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    
   class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }

    class _104_Balanced_Binary_Tree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);
            if (Math.Abs(leftHeight - rightHeight) > 1)
                return false;
            else
            {
                return IsBalanced(root.left) && IsBalanced(root.right);
            }
        }
        private int getHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            else
                return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        }

        private int checkHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftTreeHeight = checkHeight(root.left);
            int rightTreeHeight = checkHeight(root.right);
            if (leftTreeHeight == -1)
                return -1;
            else if (rightTreeHeight == -1)
                return -1;
            if (Math.Abs(leftTreeHeight - rightTreeHeight) > 1)
                return -1;
            else
                return 1 + Math.Max(leftTreeHeight, rightTreeHeight);

        }
    }
}
