
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.BubbleSort
{
	class Solution
	{
		static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] a_temp = Console.ReadLine().Split(' ');
			int[] a = Array.ConvertAll(a_temp, Int32.Parse);
			Sort(a);
		}

		public static void Sort(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = i; j < a.Length; j++)
				{
					if (a[j] > a[j + 1])
					{
						//swap ascending
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
				}
			}
		}
	}
}