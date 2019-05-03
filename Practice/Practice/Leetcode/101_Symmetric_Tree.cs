using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode
{
    class _101_Symmetric_Tree
    {
        public static void Main(string[] args)
        {
            TreeNode t = new TreeNode(1);
            t.left = new TreeNode(2);
            t.right = new TreeNode(2);

            t.left.left = new TreeNode(3);
            t.left.right = new TreeNode(4);

            t.right.left = new TreeNode(4);
            t.right.right = new TreeNode(3);

            _101_Symmetric_Tree a = new _101_Symmetric_Tree();
            bool result = a.IsSymmetric(t);
        }

        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsSymmetric(root.left, root.right);
        }
        public bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }
            if (left.val != right.val)
                return false;
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
    }
}
