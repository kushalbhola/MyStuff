	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

/*
 Problem: https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem
 Algorithm: 
    1. Enqueue everytime in the Stack1
    2. While deque, transfer everything on th stack2 and then Pop the top ost element from Stack2
 */

namespace Practice.CrackingCodingInterview.ATaleOfTwoStacks
	{
		class Solution
		{
			class MyQueue<T>
			{
				Stack<T> s1 = new Stack<T>();
				Stack<T> s2 = new Stack<T>();

				public T peek()
				{
					//check for null
					if (s2.Count == 0)
					{
						while (s1.Count > 0)
						{
							s2.Push(s1.Pop());
						}
					}
					return s2.Peek();
				}
				public void enqueue(T t)
				{
					s1.Push(t);
				}
				public T dequeue()
				{
					//check for null
					if (s2.Count == 0)
					{
						while (s1.Count > 0)
						{
							s2.Push(s1.Pop());
						}
					}
					return s2.Pop();
				}
			}


			static void Main(String[] args)
			{
				MyQueue<int> q = new MyQueue<int>();
				int n = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < n; i++)
				{
					string[] sr = Console.ReadLine().Split();
					int[] opr = Array.ConvertAll(sr, int.Parse);
					if (opr[0] == 1)
					{
						//enqueue
						q.enqueue(opr[1]);
					}
					if (opr[0] == 2)
					{
						//dequeue
						q.dequeue();
					}
					if (opr[0] == 3)
					{
						//peek
						Console.WriteLine(q.peek());
					}
				}

				Console.ReadLine();
			}
		}
	}
