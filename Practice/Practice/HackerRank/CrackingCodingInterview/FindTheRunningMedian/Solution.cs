using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.FindTheRunningMedian
{
	class Solution
	{
		static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[n];
			for (int a_i = 0; a_i < n; a_i++)
			{
				a[a_i] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Running Median: " + findMedian(a));
			}
		}
		public static int findMedian(int[] a)
		{
			int med = 0;
			if (a.Length % 2 == 0)
			{
				med = (a[a.Length / 2] + a[(a.Length / 2) + 1]) / 2;
			}
			else
			{
				var x = a.Length / 2;
				med = a[a.Length / 2];
			}
			return med;
		}
	}
}
