using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.Ransom_Notes
{
	class Solution
	{
		static void Main(String[] args)
		{
			string[] tokens_m = Console.ReadLine().Split(' ');
			int m = Convert.ToInt32(tokens_m[0]);
			int n = Convert.ToInt32(tokens_m[1]);

			string[] magazine = Console.ReadLine().Split(' ');
			string[] ransom = Console.ReadLine().Split(' ');

			Hashtable ht = new Hashtable();
			foreach (var i in magazine)
			{
				if (!ht.ContainsKey(i))
				{
					ht.Add(i, 1);
				}
				else
					ht[i] = Convert.ToInt32(ht[i]) + 1;
			}
			if (!check(ht, ransom))
			{
				Console.WriteLine("No");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Yes");
				Console.ReadLine();
			}
		}
		static bool check(Hashtable ht, string[] ransom)
		{
			foreach (var r in ransom)
			{
				if (ht.ContainsKey(r))
				{
					ht[r] = Convert.ToInt32(ht[r]) - 1;
					if (Convert.ToInt32(ht[r]) < 0)
						return false;
				}
				else
					return false;
			}
			return true;
		}
	}
}