using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings
{
	class StringConstruction
	{
		static int stringConstruction(string s)
		{
			// Complete this function
			return 1;
		}

		public static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < q; a0++)
			{
				string s = Console.ReadLine();
				int result = stringConstruction(s);
				Console.WriteLine(result);
			}
		}
	}
}
