
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
			//Sort(a);

			bool isSorted = false;
			int numSwaps = 0;
			int arrayLength = a.Length - 1;
			while (!isSorted)
			{
				isSorted = true;
				for (int i = 0; i < arrayLength; i++)
				{
					if (a[i] > a[i + 1])
					{
						//swap
						int temp = a[i];
						a[i] = a[i + 1];
						a[i + 1] = temp;
						numSwaps = numSwaps + 1;
						isSorted = false;
					}
				}
				arrayLength = arrayLength - 1;
			}
			Console.WriteLine("Array is sorted in " + numSwaps + " swaps.");
			Console.WriteLine("First Element: " + a[0]);
			Console.WriteLine("Last Element: " + a[a.Length-1]);
			Console.ReadLine();
		}

		//public static void Sort(int[] a)
		//{
		//	bool isSorted = false;
		//	int numSwaps = 0;
		//	int arrayLength = a.Length - 1;
		//	while (!isSorted)
		//	{
		//		isSorted = true;
		//		for(int i = 0; i < arrayLength; i++)
		//		{
		//			if (a[i] > a[i + 1])
		//			{
		//				//swap
		//				int temp = a[i];
		//				a[i] = a[i + 1];
		//				a[i + 1] = temp;
		//				numSwaps = numSwaps + 1;
		//				isSorted = false;
 	//				}
		//		}
		//		arrayLength = arrayLength - 1;
		//	}
		//}
	}
}