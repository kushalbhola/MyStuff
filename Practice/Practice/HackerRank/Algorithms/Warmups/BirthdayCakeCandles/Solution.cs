using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Warmups.BirthdayCakeCandles
{
	class Solution
	{

		static int birthdayCakeCandles(int n, int[] ar)
		{
			// Complete this function
			int max = Int32.MinValue;
			int result = 0;
			for (int i = 0; i < ar.Length; i++)
			{
				if (ar[i] >= max)
				{
					//also add this to an array so you have count
					max = ar[i];
					result++;
				}
			}
			return result;
		}

		static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] ar_temp = Console.ReadLine().Split(' ');

			int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
			int result = birthdayCakeCandles(n, ar);
			Console.WriteLine(result);
		}
	}
}
