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
			//for (int a0 = 0; a0 < t; a0++)
			//{
				//int mo = Convert.ToInt32(Console.ReadLine());
				//int n = Convert.ToInt32(Console.ReadLine());
				//string[] a_temp = Console.ReadLine().Split(' ');
				//int[] a = Array.ConvertAll(a_temp, Int32.Parse);

				int money = 4;
				int[] menu = { 2, 2, 4, 3 };
				int[] sortedMenu = (int[])menu.Clone();
				Array.Sort(sortedMenu);
				for(int i = 0; i < sortedMenu.Length; i++)
				{
					int searchVal = money - menu[i];
					//look for search val in the  sorted array
					int result = Array.BinarySearch(sortedMenu, searchVal);
					//get the indices of the searched val, you need index of searchedVal, and menu[i]
					if(result > 0)
					{
						if(getIndex(menu, searchVal) != 0 )
						{
							Console.WriteLine((getIndex(menu, searchVal)+ 1 ) + " " + (i+1));
						}
					}
				}
			Console.ReadLine();

			//}
		}
		static int getIndex(int[] menu, int val)
		{
			for(int i = 0; i < menu.Length; i++)
			{
				if (menu[i] == val)
					return i;
			}
			return 0;
		}
	}
}