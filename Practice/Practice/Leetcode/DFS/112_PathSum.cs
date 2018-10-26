using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DFS
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
        class _112_PathSum
    {
        public static void Main(String[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);

            root.right = new TreeNode(8);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.left = new TreeNode(1);

            _112_PathSum a = new _112_PathSum();
            bool result = a.HasPathSum(root, 22);
        }
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            //if(root.left == null && root.right == null) return false;
            //TreeNode temp = root;
            int sumSoFar = 0;
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            //        s.Push(root.left);
            while (s.Count != 0)
            {
                TreeNode child = s.Pop();
                sumSoFar = sumSoFar + child.val;
                //check if this a leaf
                //if it is leaf then compare the counter with the sum, if match return true else make the counter = 0
                if (child.left == null && child.right == null)
                {
                    if (sumSoFar == sum)
                        return true;
                    else
                        sumSoFar = sumSoFar - child.val;
                }
                else
                {
                    if (child.right != null)
                        s.Push(child.right);
                    if (child.left != null)
                        s.Push(child.left);
                }
            }
            return false;
        }
    }
}
