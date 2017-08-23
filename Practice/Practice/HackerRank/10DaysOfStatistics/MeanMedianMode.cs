using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank._10DaysOfStatistics
{
	class MeanMedianMode
	{
		static void Main(String[] args)
		{
			int N = Convert.ToInt32(Console.ReadLine());
			//int[] X = new int[N];
			string[] a_temp = Console.ReadLine().Split(' ');
			int[] X = Array.ConvertAll(a_temp, Int32.Parse);
			//for (int i = 0; i < X.Length; i++)
			//{
			//	X[i] = Convert.ToInt32(Console.ReadLine());
			//}
			//int[] X = { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };


			Console.WriteLine(findMean(X));
			Console.WriteLine(findMedian(X));
			Console.WriteLine(findMode(X));
			Console.ReadKey();


		}
		static double findMean(int[] X)
		{
			double mean = 0.0;
			double sum = 0.0;
			for (int i = 0; i < X.Length; i++)
			{
				sum = sum + X[i];
			}
			mean =  sum / X.Length;
			return mean;
		}
		static double findMedian(int[] X)
		{
			double median = 0.0;
			int[] sortedArray = (int[])X.Clone();
			int Len = sortedArray.Length;
			Array.Sort(sortedArray);
			if (sortedArray.Length % 2 != 0)
				median = sortedArray[sortedArray.Length / 2];
			else
			{
				median = (double)(sortedArray[(Len / 2) - 1] + sortedArray[(Len / 2)]) / 2;
			}
			return median;
		}
		static int findMode(int[] X)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			foreach(var i in X)
			{
				if (dict.ContainsKey(i))
				{
					dict[i] = dict[i] + 1;
				}
				else
				{
					dict.Add(i, 1);
				}
			}
			return dict.OrderBy(k => k.Value).ThenBy(o => o.Key).ToDictionary(pair => pair.Key, x => x.Value).First().Key;
		}
	}
}
