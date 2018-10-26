using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{

 

    class _653_Two_Sum_IV___Input_is_a_BST
    {
        public static void Main(String[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);

            root.right = new TreeNode(6);
            root.right.right = new TreeNode(7);
            int k = 28;
            _653_Two_Sum_IV___Input_is_a_BST A = new _653_Two_Sum_IV___Input_is_a_BST();
            bool result = A.FindTarget(root, k);
        }
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> hash = new HashSet<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);
            while (q.Count >= 1)
            {
                TreeNode temp = q.Dequeue();
                if (hash.Contains(k - temp.val))
                    return true;
                else
                    hash.Add(temp.val);
                //if (!hash.ContainsKey(temp.val))
                //    hash[temp.val] = k - temp.val;
                if (temp.left != null)
                    q.Enqueue(temp.left);
                if (temp.right != null)
                    q.Enqueue(temp.right);
            }
            return false;
        }
    }
}
