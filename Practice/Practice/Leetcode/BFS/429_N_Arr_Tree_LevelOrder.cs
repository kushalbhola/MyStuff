using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BFS
{
    class _429_N_Arr_Tree_LevelOrder
    {
        public static void Main(string[] args)
        {
            _429_N_Arr_Tree_LevelOrder a = new _429_N_Arr_Tree_LevelOrder();
        }
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    int size = queue.Count;
                    IList<int> tempList = new List<int>();
                    for (int i = 0; i < size; i++)
                    {
                        Node temp = queue.Dequeue();
                        tempList.Add(temp.val);
                        foreach (var child in temp.children)
                        {
                            queue.Enqueue(child);
                        }
                    }
                    list.Add(tempList);
                }
            }
            return list;
        }
    }
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
