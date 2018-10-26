using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _404_Sum_of_Left_Leaves
    {
        public static void Main(String[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            _404_Sum_of_Left_Leaves a = new _404_Sum_of_Left_Leaves();
            int result = a.SumOfLeftLeaves(root);
        }
        public int SumOfLeftLeaves(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            List<int> l = new List<int>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode temp = q.Dequeue();
                if (temp.left != null)
                {
                    if (temp.left.left == null)
                        l.Add(temp.left.val);
                    else
                        q.Enqueue(temp.left);
                }
                if (temp.right != null)
                    q.Enqueue(temp.right);
            }
            return l.Sum(x => x);
        }
    }
}
