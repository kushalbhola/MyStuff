using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _235_LowestCommonAncestorBinarySearchTree
    {
        public static void Main(String[] args)
        {
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);

            root.right = new TreeNode(8);
            root.right.right = new TreeNode(9);
            root.right.left = new TreeNode(7);

            _235_LowestCommonAncestorBinarySearchTree a = new _235_LowestCommonAncestorBinarySearchTree();
            
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            if (root.val < p.val && root.val < q.val)
            {
                // LCA in right subtree
                return LowestCommonAncestor(root.right, p, q);
            }
            if (root.val > p.val && root.val > q.val)
            {
                //LCA in left  subtree
                return LowestCommonAncestor(root.left, p, q);
            }
            if (root.val < Math.Max(p.val, q.val) && root.val > Math.Min(p.val, q.val))
            {
                //root will be the LCA
                return root;
            }
            if (p.val == root.val || q.val == root.val)
                return root;
            return null;
        }
    }
}
