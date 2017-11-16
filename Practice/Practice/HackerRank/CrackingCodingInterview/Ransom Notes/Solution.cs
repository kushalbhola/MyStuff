using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Problem: https://www.hackerrank.com/challenges/ctci-ransom-note/problem
 * Algorithm: 
 * 1. Create a hashtable of all the words in the magazine
 * 2. Check each string in magazine against hashtable
 * 3. Decrement the magazine hashtable whenever you find a match
 * 4. If hashtable count is zero it means there is a word in ransom notes which has already been used in the ransom
 * 5. Throw erroe if zero
 */
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
			string[] ransom = Console.ReadLine().Split(' '); ;

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