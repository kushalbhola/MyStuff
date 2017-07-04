using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings.AlternatingCharacters
{
	class Solution
	{
		static int alternatingCharacters(string s)
		{
			char[] ch = s.ToCharArray();
			ArrayList newCharArray = new ArrayList();
			int count = 0;
			for (int i = 0; i < ch.Length-1; i++)
			{
				if(ch[i] == ch[i + 1])
				{
					newCharArray.Add(ch[i]);
					count++;
				}
			}
			return count;
		}

		static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < q; a0++)
			{
				string s = Console.ReadLine();
				int result = alternatingCharacters(s);
				Console.WriteLine(result);
			}
			Console.ReadLine();
		}
	}
}
