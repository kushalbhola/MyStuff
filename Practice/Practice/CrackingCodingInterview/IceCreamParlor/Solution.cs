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
				int[] sortedMenu = (int[])a.Clone();
				Array.Sort(sortedMenu);
				for (int i = 0; i < sortedMenu.Length; i++)
				{
					int searchVal = money - sortedMenu[i];
					bool flag = check(sortedMenu, 0, sortedMenu.Length - 1, searchVal, i);
					if(flag) 
					{
						int val1 = indexof(a, a[i]);
						int val2 = indexof(a, searchVal);
						if (val2 != -1)
						{
							Console.WriteLine(val1  + " " + val2);
						}
					}
					
				}
				Console.ReadLine();
			}
		}
		static int indexof(int[] a, int val)
		{
			for(int i = 0; i < a.Length; i++)
			{
				if (a[i] == val) return i+1;
			}
			return -1;
		}
		static bool check(int[] a, int first, int last, int searchVal, int initial)
		{
			if (first <= last)
			{
				int mid = (int)first + last / 2;
				if (a[mid] == searchVal && mid != initial)
					return true;
				else if (a[mid] > searchVal)
					return check(a, first, mid, searchVal, initial);
				else                                // (a[mid] < searchVal)
					return check(a, mid + 1, last, searchVal, initial);
			}
			else
				return false;
		}
	}
}
