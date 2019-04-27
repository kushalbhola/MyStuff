using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Pramp
{
    class IslandCount
    {
        public static void Main(string[] args)
        {
            int[,] binaryMatrix = { { 0,1,0,1,0},
                                    { 0,0,1,1,1},
                                    { 1,0,0,1,0},
                                    { 0,1,1,0,0},
                                    { 1,0,1,0,1},
                                   };
            int result = countislands(binaryMatrix);
        }
        public static int countislands(int[,] binaryMatrix)
        {
            var queue = new Queue<Node>();
            for (int i=0;i<binaryMatrix.GetLength(0);i++)
            {
                for(int j=0;j<binaryMatrix.GetLength(1);j++)
                {
                    AddChildren(binaryMatrix, queue, i, j);
                    while(queue.Count != 0)
                    {
                        Node head = queue.Dequeue();
                    }
                }
            }
            int start = 0;
            int end = 0;

            return 0;
        }
        public static void AddChildren(int[,] binaryMatrix, Queue<Node> queue,int start, int end)
        {
            if(start+1<binaryMatrix.GetLength(0) && end < binaryMatrix.GetLength(1) && start + 1 >= 0 && end >= 0)
            {
                queue.Enqueue(new Node(start + 1, end));
            }
            if (start < binaryMatrix.GetLength(0) && end+1 < binaryMatrix.GetLength(1) && start>= 0&& end + 1>=0)
            {
                queue.Enqueue(new Node(start, end + 1));
            }
            if (start-1 < binaryMatrix.GetLength(0) && end < binaryMatrix.GetLength(1) && start - 1>=0 && end >= 0)
            {
                queue.Enqueue(new Node(start-1, end));
            }
            if (start < binaryMatrix.GetLength(0) && end - 1 < binaryMatrix.GetLength(1) && start >= 0 && end - 1 >= 0)
            {
                queue.Enqueue(new Node(start, end - 1));
            }
        }
    }
    class Node
    {
        int x;
        int y;
        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
