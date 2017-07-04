using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.CheckBST
{
	class Node
	{
		public int data;
		public Node left;
		public Node right;

		public Node(int item)
		{
			data = item;
			left = null;
			right = null;
		}
	}
	public class Solution
	{
		//Root of the Binary Tree
		Node root;

		/* can give min and max value according to your code or
		can write a function to find min and max value of tree. */

		/* returns true if given search tree is binary
		 search tree (efficient version) */
		bool isBST()
		{
			return isBSTUtil(root, Int32.MinValue,
								   Int32.MaxValue);
		}

		/* Returns true if the given tree is a BST and its
		  values are >= min and <= max. */
		bool isBSTUtil(Node node, int min, int max)
		{
			/* an empty tree is BST */
			if (node == null)
				return true;

			/* false if this node violates the min/max constraints */
			if (node.data < min || node.data > max)
				return false;

			/* otherwise check the subtrees recursively
			tightening the min/max constraints */
			// Allow only distinct values
			return (isBSTUtil(node.left, min, node.data - 1) &&
					isBSTUtil(node.right, node.data + 1, max));
		}

		/* Driver program to test above functions */
		public static void Main(String[] args)
		{
			Solution tree = new Solution();
			tree.root = new Node(4);
			tree.root.left = new Node(2);
			tree.root.right = new Node(5);
			tree.root.left.left = new Node(1);
			//tree.root.left.right = new Node(3);

			if (tree.isBST())
				Console.WriteLine("IS BST");
			else
				Console.WriteLine("Not a BST");
		}
	}
}
