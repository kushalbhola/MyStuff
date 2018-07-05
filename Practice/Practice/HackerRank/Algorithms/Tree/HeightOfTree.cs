using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Tree
{
	public class HeightOfTree
	{
		public static void Main(String[] args)
		{
			int[] arr = { 1, 2, 5, 3, 6, 4 };
			Node root = ConstructTree(arr);
            Console.WriteLine("height1: " + GetHeight2(root));
            Console.WriteLine("height2: " + GetHeight2(root));

            Console.WriteLine("PreOrder: ");    
			PreOrder(root); Console.WriteLine();
			Console.WriteLine("InOrder: ");     //left, root, rightx
            InOrder(root); Console.WriteLine();
			Console.WriteLine("PostOrder");
			PostOrder(root); Console.WriteLine();
			Console.WriteLine("Top View");
			topView(root);  Console.WriteLine();
			Console.WriteLine("Level View");
			levelOrder(root);
			Console.ReadKey();
		}
		public static Node Insert(Node root, int data)
		{
			if(root == null)
				return new Node(data);
			else
			{
				Node curr;
				if (data < root.data)
				{
					curr = Insert(root.left, data);
					root.left = curr;
				}
				else
				{
					curr = Insert(root.right, data);
					root.right = curr;
				}
				return root;
			}
		}

        static Node Balance(Node root, int val)
        {
            //insert the value first
            root = Insert(root, val);

            //start the process of balancing

            // if the Height[RightSubtree]  - Height[LeftSubtree] > 1 or -1
            while (Math.Abs(GetHeight(root.left) - GetHeight(root.left)) > 1)
            {
                if (GetHeight(root.left) > GetHeight(root.right))
                {
                    //left is bigger than right
                    Node newRoot = root.left;
                    root.left = newRoot.right;
                    newRoot.right = root;
                }
                else
                {
                    //right is bigger than left
                    Node newRoot = root.right;
                    root.right = newRoot.left;
                    newRoot.left = root;
                }
            }
            return root;
        }
        public static Node ConstructTree(int[] arr)
		{
			Node root = null;
			foreach (int a in arr)
			{
				root = Insert(root, a);
			}
			return root;
		}
		public static int GetHeight(Node root)
		{
			if (root == null)
				return -1;
			else
			{
				//int leftHeight = GetHeight(root.left);
				//int rightHeight = GetHeight(root.right);

				//if (leftHeight > rightHeight)
				//	return (leftHeight + 1);
				//else
				//	return (rightHeight + 1);
				return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
			}
		}
		public static int GetHeight2(Node root)
		{
			if (root == null)
				return -1;
			else
			{
				int leftHeight = GetHeight2(root.left);
				int rightHeight = GetHeight2(root.right);

				if (leftHeight > rightHeight)
					return (leftHeight + 1);
				else
					return (rightHeight + 1);
			}
		}
		public static void PreOrder(Node root)
		{
			//root >> left >> right
			if (root == null)
				return;
			Console.Write(root.data + " ");
			PreOrder(root.left);
			PreOrder(root.right);
		}
		public static void InOrder(Node root)
		{
			//left >> root >> right
			if (root == null)
				return;

			InOrder(root.left);
			Console.Write(root.data + " ");
			InOrder(root.right);
		}
		public static void PostOrder(Node root)
		{
			//Left >>  Right >> Root
			if (root == null)
				return;
			PostOrder(root.left);
			PostOrder(root.right);
			Console.Write(root.data + " ");
		}
		public static void topView(Node root)
		{
			//print root's all left children and root's all right children
			if(root.left != null)
				topViewLeft(root.left);
			Console.Write(root.data + " ");
			if(root.right != null)
				topViewRight(root.right);
		}
		public static void topViewRight(Node root)
		{
			Console.Write(root.data + " ");
			if (root.right != null)
				topViewRight(root.right);
		}
		public static void topViewLeft(Node root)
		{
			if (root.left != null)
				topViewLeft(root.left);
			Console.Write(root.data + " ");
		}
		public static void levelOrder(Node root)
		{
			Queue<Node> queue = new Queue<Node>();
			if (root != null)
				queue.Enqueue(root);
			while(queue.Count != 0)
			{
				Node d = queue.Dequeue();
				Console.Write(d.data + " ");
				if (d.left != null)
					queue.Enqueue(d.left);
				if (d.right != null)
					queue.Enqueue(d.right);
			}
		}
	}
	public class Node
	{
		public Node left;
		public Node right;
		public int data;
		public Node(int data)
		{
			this.data = data;
			left = null;
			right = null;
		}
	}
}
