using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.Making_Anagrams
{
	class Solution
	{
		static void Main(String[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();

			char[] _a = a.ToCharArray();
			char[] _b = a.ToCharArray();

			Dictionary<char, char> A = _a.ToDictionary(v => v, v => v);
		}
	}
}
