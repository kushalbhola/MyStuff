using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _114_Flatten_Binary_Tree_to_Linked_List
    {
        public void Flatten(TreeNode root)
        {
            if (root == null) { return; }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            dfs(root, queue);
            TreeNode pre = queue.Dequeue();
            pre.left = null;
            pre.right = null;
            while (queue.Count() != 0)
            {
                TreeNode temp = queue.Dequeue();
                temp.right = pre;
                temp.left = null;
                pre = temp;
            }
        }

        public static void dfs(TreeNode root, Queue<TreeNode> queue)
        {
            if (root == null) { return; }
            if (root.right != null)
            {
                dfs(root.right, queue);
            }
            if (root.left != null)
            {
                dfs(root.left, queue);
            }
            queue.Enqueue(root);
        }
    }
}
