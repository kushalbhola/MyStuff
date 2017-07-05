using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings
{
	class TwoStrings
	{
		static string twoStrings(string s1, string s2)
		{
			// Complete this function
			Dictionary<char, int> s1Dict = new Dictionary<char, int>();
			Dictionary<char, int> s2Dict = new Dictionary<char, int>();

			s1Dict = convertArrayToDict(s1.ToCharArray());
			s2Dict = convertArrayToDict(s2.ToCharArray());

			if (s1Dict.Count() > s2Dict.Count())
			{
				foreach (var x in s1Dict)
				{
					if (s2Dict.ContainsKey(x.Key))
					{
						return "YES";
					}
				}
			}
			else
			{
				foreach (var x in s2Dict)
				{
					if (s1Dict.ContainsKey(x.Key))
					{
						return "YES";
					}
				}
			}
			return "NO";
		}
		static Dictionary<char, int> convertArrayToDict(char[] ch)
		{
			Dictionary<char, int> dict = new Dictionary<char, int>();
			foreach (var x in ch)
			{
				if (dict.ContainsKey(x))
				{
					dict[x] = dict[x] + 1;
				}
				else
					dict.Add(x, 1);
			}
			return dict;
		}

		public static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < q; a0++)
			{
				//string s1 = Console.ReadLine();
				//string s2 = Console.ReadLine();
				string s1 = "hello";
				string s2 = "world";
				string result = twoStrings(s1, s2);
				Console.WriteLine(result);
				Console.ReadLine();
			}
		}
	}
}
