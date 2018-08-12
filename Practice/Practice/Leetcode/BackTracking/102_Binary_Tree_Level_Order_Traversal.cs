using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject
{
    class _102_Binary_Tree_Level_Order_Traversal
    {
        public static void Main(String[] args)
        {
            TreeNode treenode = new TreeNode(3);
            treenode.left = new TreeNode(9);
            treenode.left.left = new TreeNode(101);
            treenode.left.right = new TreeNode(102);

            treenode.right = new TreeNode(20);
            treenode.right.right = new TreeNode(7);
            treenode.right.left = new TreeNode(15);

            //TreeNode treenode = new TreeNode(1);
            //treenode.left = new TreeNode(2);
            //treenode.left.left = new TreeNode(4);

            //treenode.right = new TreeNode(3);
            //treenode.right.right = new TreeNode(5);

            var root = levelOrder(treenode);
            //var root = ZigZag(treenode);
        }
        public static List<List<int>> levelOrder(TreeNode root)
        {
            List<List<int>> ans = new List<List<int>>();
            compute(ans, root, 0);
            return ans;
        }

        public static void compute(List<List<int>> ans, TreeNode curr, int level)
        {
            if (curr == null) return;

            if (ans.Count() == level)
                ans.Add(new List<int>());

            ans[level].Add(curr.val);

            compute(ans, curr.left, level + 1);
            compute(ans, curr.right, level + 1);
        }
        //public static IList<IList<int>> LevelOrder(TreeNode root)
        //{
        //    var result = new List<IList<int>>();
        //    Queue<TreeNode> q = new Queue<TreeNode>();
        //    q.Enqueue(root);
        //    while (q.Count > 1)
        //    {
        //        int size = q.Count();
        //        List<int> temp = new List<int>();
        //        for (int i = 0; i < size; i++)
        //        {
        //            TreeNode curr = q.Dequeue();
        //            temp.Add(curr.val);
        //            if (curr.left != null) q.Enqueue(curr.left);
        //            if (curr.right != null) q.Enqueue(curr.right);
        //        }
        //        result.Add(temp);
        //    }
        //    return result;
        //}

        public static IList<IList<int>> ZigZag(TreeNode root)
        {
            var result = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int depth = 1;
            while (q.Count >= 1)
            {
                int size = q.Count();
                List<int> temp = new List<int>();
                int avg = temp.OrderByDescending(o => o).First();

                for (int i = 0; i < size; i++)
                {
                    TreeNode curr = q.Dequeue();
                    temp.Add(curr.val);
                    if (depth % 2 == 0)
                    {
                        if (curr.left != null) q.Enqueue(curr.left);
                        if (curr.right != null) q.Enqueue(curr.right);
                    }
                    else
                    {
                        if (curr.right != null) q.Enqueue(curr.right);
                        if (curr.left != null) q.Enqueue(curr.left);
                    }
                }
                depth++;
                result.Add(temp);
            }
            return result;
        }

        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            var temp = root;

            while (temp != null)
            {
                result.Add(temp.val);
                if (temp.right != null)
                    temp = temp.right;
                temp = null;
            }
            return result;
        }
    }


    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
