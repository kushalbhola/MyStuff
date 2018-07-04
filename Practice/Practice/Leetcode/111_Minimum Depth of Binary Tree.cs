using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _111_Minimum_Depth_of_Binary_Tree
    {
        public int MinDepth(TreeNode root)
        {
            //int minHeight = 0;
            if (root == null)
                return 0;
            else if (root.left == null && root.right != null)
                return 1 + MinDepth(root.right);
            else if (root.left != null && root.right == null)
                return 1 + MinDepth(root.left);
            else
                return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}
