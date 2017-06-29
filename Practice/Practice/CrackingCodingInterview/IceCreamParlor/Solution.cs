using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.IceCreamParlor
{
	class Solution
	{
		static void Main(String[] args)
		{
			//int t = Convert.ToInt32(Console.ReadLine());
			int t = 2;
			for (int a0 = 0; a0 < t; a0++)
			{
				//int money = Convert.ToInt32(Console.ReadLine());
				//int n = Convert.ToInt32(Console.ReadLine());
				//string[] a_temp = Console.ReadLine().Split(' ');
				//int[] a = Array.ConvertAll(a_temp, Int32.Parse);
				int money = 4;
				int[] a = { 1, 4, 5, 3, 2 };
				Array.Sort(a);
				for (int i = 0; i < a.Length; i++)
				{
					Console.WriteLine(a[i]);
					//int var = a[i];
					//look for the money - var in the array 
					int val = check(a, 0, a.Length - 1, money-a[i]);
					if(val != -1)
					{
						Console.WriteLine(a[i] + " " + a[val]);
					}
					
				}
				Console.ReadLine();
			}
			
		}

		static int check(int[] a, int first, int last, int searchVal)
		{
			if (first <= last)
			{
				int mid = (int)first + last / 2;
				if (a[mid] == searchVal)
					return mid;
				else if (a[mid] > searchVal)
					return check(a, first, mid, searchVal);
				else								// (a[mid] < searchVal)
					return check(a, mid + 1, last, searchVal);
			}
			else
				return -1;

			//double  midPoint = 0;
			//if (a.Length % 2 != 0)
			//	midPoint = a[(a.Length - 1) / 2];
			//else
			//	midPoint = ((double)a[(a.Length - 1) / 2] + (double)a[((a.Length - 1) / 2) + 1 ]) / 2;
			//if (val < midPoint)
			//{
			//	//left
			//	check()
			//}
			//else
			//{
			//	//right
			//}
		}
	}
}
