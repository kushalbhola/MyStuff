using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice._30DaysOfCode.Day7rrays
{
	class Solution
	{
		public static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			for (int i = 0; i < n; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int j = n - 1; j >= 0; j--)
			{
				Console.WriteLine(arr[j] + " ");
			}
		}
	}
}
