using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings
{
	class SuperReducedString
	{
		public static void Main(String[] args)
		{
			StringBuilder str = new StringBuilder("aaabccddd");
			for (int i = 1; i < str.Length; i++)
			{
				if (str[i] == str[i - 1])
				{
					str.Remove(i - 1, i + 1);
					i = 0;
				}
			}
			if (str.Length == 0)
				Console.WriteLine("Empty String");
			else
				Console.WriteLine(str);
			Console.ReadKey();
		}
		
	}
}
