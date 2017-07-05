using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings
{
	class MakingAnagrams
	{
		static int makingAnagrams(string s1, string s2)
		{
			// Complete this function
			Dictionary<char, int> s1Dict = new Dictionary<char, int>();
			Dictionary<char, int> s2Dict = new Dictionary<char, int>();
			int results = 0;

			s1Dict = convertArrayToDict(s1.ToCharArray());
			s2Dict = convertArrayToDict(s2.ToCharArray());

			foreach (var x in s1Dict)
			{
				if (s2Dict.ContainsKey(x.Key))
				{
					if (x.Value != s2Dict[x.Key])
					{
						results = results + Math.Abs(x.Value - s2Dict[x.Key]);
					}
				}
				else results = results + x.Value;
			}
			foreach (var x in s2Dict)
			{
				if (s1Dict.ContainsKey(x.Key))
				{
					if (x.Value != s1Dict[x.Key])
					{
						//results = results + Math.Abs(x.Value - s1Dict[x.Key]);
					}
				}
				else results = results + x.Value;
			}


			return results;
		}
		static Dictionary<char, int> convertArrayToDict( char[] ch)
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
			//string s1 = Console.ReadLine();
			//string s2 = Console.ReadLine();
			//int result = makingAnagrams(s1, s2);
			string s1 = "abc";
			string s2 = "cde";
			int result = makingAnagrams(s1, s2);
			Console.WriteLine(result);
			Console.ReadLine();
		}
		
	}
}
