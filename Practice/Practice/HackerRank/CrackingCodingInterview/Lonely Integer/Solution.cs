using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.Lonely_Integer
{
	class Solution
	{
		static void Main(String[] args)
		{
			//int n = Convert.ToInt32(Console.ReadLine());
			//string[] a_temp = Console.ReadLine().Split(' ');
			//int[] a = Array.ConvertAll(a_temp, Int32.Parse);
			int[] a = { 0, 0, 1, 2, 1 };
			Dictionary<int, int> hashMap = new Dictionary<int, int>();
			for (int i = 0; i < a.Length; i++)
			{
				if (hashMap.ContainsKey(a[i]))
				{
					hashMap[a[i]] = hashMap[a[i]] + 1;
				}
				else
					hashMap.Add(a[i], 1);
			}
			foreach(var hash in hashMap)
			{
				if(hash.Value %2 != 0)
				{
					Console.WriteLine(hash.Key);
				}
			}
			Console.ReadKey();
		}
	}
}
