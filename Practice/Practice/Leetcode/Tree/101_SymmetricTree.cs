using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Tree
{
    class _101_SymmetricTree
    {
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);

            root.left.right = new TreeNode(4);
            root.left.left = new TreeNode(3);

            root.right.right = new TreeNode(3);
            root.right.left = new TreeNode(4);
            _101_SymmetricTree a = new _101_SymmetricTree();
            bool result = a.IsSymmetric(root);

        }
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsSymmetric(root.left, root.right);
        }
        public bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if(left ==null || right == null)
            {
                return left == right;
            }
            if (left.val != right.val)
                return false;
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
