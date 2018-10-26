using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _872_Leaf_Similar_Trees
    {
        public static void Main(String[] args)
        {
            _872_Leaf_Similar_Trees a = new _872_Leaf_Similar_Trees();
            TreeNode root1 = new TreeNode(2);
            root1.left = new TreeNode(1);
            root1.right = new TreeNode(3);

            TreeNode root2 = new TreeNode(3);
            root2.left = new TreeNode(1);
            root2.right = new TreeNode(2);

            bool result = a.LeafSimilar(root1, root2);
        }
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            Dictionary<int, int> dict1 = FindLeaves(root1);
            Dictionary<int, int> dict2 = FindLeaves(root2);
            if (dict1.Count != dict2.Count)
                return false;
            else
            {
                foreach (int d in dict1.Keys)
                {
                    if (!dict2.ContainsKey(d))
                        return false;
                    if (dict2.ContainsKey(d) && dict2[d] != dict1[d])
                        return false;
                }
            }
            return true;
        }
        public Dictionary<int, int> FindLeaves(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            while (s.Count > 0)
            {
                TreeNode temp = s.Pop();
                if (temp.left == null && temp.right == null)
                {
                    if (dict.ContainsKey(temp.val))
                        dict[temp.val]++;
                    else
                        dict[temp.val] = 1;
                }

                else
                {
                    if (temp.left != null)
                        s.Push(temp.left);
                    if (temp.right != null)
                        s.Push(temp.right);
                }
            }
            return dict;
        }
    }
}
