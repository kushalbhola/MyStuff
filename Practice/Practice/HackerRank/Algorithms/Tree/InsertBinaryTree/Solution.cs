using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Tree.InsertBinaryTree
{
    public class Solution
    {
        public static void Main(String[] args)
        {

        }
        static Node Insert(Node root, int value)
        {

            if (root == null)
                return null;
            else if (value > root.data)
            {
                Insert(root.right, value);
                root.right = new Node();
                root.right.data = value;
            }
            else if (value < root.data)
            {
                Insert(root.left, value);
                root.left = new Node();
                root.left.data = value;
            }
            return root;
        }
    }
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

}
