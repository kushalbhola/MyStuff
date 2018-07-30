using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.BFS
{
	class Graph
	{
		Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
		public Graph(int size)
		{
			//fill the graph
			for(int i = 1; i <= size; i++)
				graph.Add(i, new List<int>());
		}
		public void addEdge(int first, int second)
		{
			int tempSize = graph.Count;
			if (graph.ContainsKey(first))
			{
				if(graph[first].Count == 0)
				{
					graph[first] = new List<int>();
					graph[first].Add(second);
				}
				else
					graph[first].Add(second);
			}
			//if (graph.ContainsKey(second))
			//{
			//	if(graph[second].Count == 0)
			//	{
			//		graph[second] = new List<int>();
			//		graph[second].Add(first);
			//	}
			//}
		}
		public Dictionary<int, int> shortestReach(int startID)
		{
			List<int> queue = new List<int>();
			queue.Add(startID);
			//int[] distances = new int[graph.Count];

			//for (int j = 0; j < distances.Length; j++)
			//{
			//	distances[j] = -1;
			//}
			Dictionary<int, int> distances = new Dictionary<int, int>();
			for(int i = 1; i <= graph.Count; i++)
			{
				distances.Add(i, -1);
			}
			distances[startID] = 0;
			while (queue.Count > 0)
			{
				int node = queue.First();
				queue.Remove(node);
				foreach(int neighbor in graph[node])
				{
					if(distances[neighbor] == -1) //PUT -1 HERE 
					{
						distances[neighbor] = distances[node] + 6;
						queue.Add(neighbor);
					}
				}
			}
			return distances;
		}
	}
	class Solution
	{
		public static void Main(String[] args)
		{
			int queries = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < queries; i++)
			{
				//Create a graph
				string[] temp2 = Console.ReadLine().Split(' ');
			//	int n = Convert.ToInt32(Console.ReadLine());
				Graph graph = new Graph(Convert.ToInt32(temp2[0]));
				//int m = Convert.ToInt32(Console.ReadLine());
				int m = Convert.ToInt32(temp2[1]);
				for (int j = 0; j < m; j++)
				{
					string[] temp = Console.ReadLine().Split(' ');
					int u = Convert.ToInt32(temp[0]);
					int v = Convert.ToInt32(temp[1]);

					// add each edge to the graph
					graph.addEdge(u, v);
				}

				int startID = Convert.ToInt32(Console.ReadLine());
				Dictionary<int, int> distances = graph.shortestReach(startID);

				for (int k = 1; k <= distances.Count; k++)
				{
					if (k != startID)
					{
						Console.Write(distances[k]  + " ");
					}
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
		}
	}

