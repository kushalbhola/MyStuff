using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BFS
{
    class _513_FindBottomLeftTreeValue
    {
        public static void Main(String[] args)
        {
            _513_FindBottomLeftTreeValue a = new _513_FindBottomLeftTreeValue();
            TreeNode t = new TreeNode(1);
            t.left = new TreeNode(2);
            t.right = new TreeNode(3);

            t.left.left = new TreeNode(4);

            t.right.left = new TreeNode(5);
            t.right.right = new TreeNode(6);

            t.right.left.left = new TreeNode(7);

            TreeNode t2 = new TreeNode(0);
            t2.right = new TreeNode(-1);

            int result = a.FindBottomLeftValue(t2);
        }
        public int FindBottomLeftValue(TreeNode root)
        {
            /*
             * Algo:
             * 1. Do a BFS  search on all the node
             * 2. at each level if t.left == null > add to dictionary with level
             * 3. Maintain level for each time adding to Queue. 
             * 4. Do not add a value in the dictionary if another value of the same level exists
             * 5. at the end in the dictionary look for a value with highest level
             * 
             * */
            Dictionary<int,TreeNode > hash = new Dictionary<int, TreeNode>();
            Queue<TreeNode> Queue = new Queue<TreeNode>();
            int level = 1;
            if (root == null) return 0;
            Queue.Enqueue(root);
            while(Queue.Count != 0)
            {
                int size = Queue.Count;
                for(int i = 0; i < size; i++)
                {
                    TreeNode temp = Queue.Dequeue();
                    if(temp.left == null && (!hash.ContainsKey(level)))
                    {
                        hash.Add(level, temp);
                        if (temp.right != null)
                            Queue.Enqueue(temp.right);
                    }
                    else
                    {
                        if(temp.left != null )
                            Queue.Enqueue(temp.left);
                        if (temp.right != null)
                            Queue.Enqueue(temp.right);
                    }
                }
                level++;
            }
            return hash.OrderByDescending(a => a.Key).Select(a => a.Value.val).FirstOrDefault();
        }
    }
}
