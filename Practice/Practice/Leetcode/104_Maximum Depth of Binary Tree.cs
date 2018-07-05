using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _104_Maximum_Depth_of_Binary_Tree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null && root.right != null)
                return 1 + MaxDepth(root.right);
            else if (root.left != null && root.right == null)
                return 1 + MaxDepth(root.left);
            else
                return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
