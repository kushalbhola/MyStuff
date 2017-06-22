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
			///*strin*/g a = Console.ReadLine();
			///*strin*/g b = Console.ReadLine();
			string a = "cde";
			string b = "abc";

			char[] _a = a.ToCharArray();
			char[] _b = b.ToCharArray();
			//put a char into a dictionary with key being the char and value being the frequency of the char
			Dictionary<char, int> newDict = createDictionary(_a);
			Dictionary<char, int> newDict2 = createDictionary(_b);

			Console.WriteLine(check(newDict, newDict2));
			Console.ReadLine();

		}
		public static Dictionary<char, int>  createDictionary(char[] a)
		{
			var newDict = new Dictionary<char, int>();
			for (int i = 0; i < a.Length; i++)
			{
				if (newDict.ContainsKey(a[i]))
				{
					newDict[a[i]]  = newDict[a[i]] +  1 ;
				}
				else
				{
					newDict.Add(a[i], 1);
				}
			}
			return newDict;
		}

		public static int check(Dictionary<char, int> newDict, Dictionary<char, int> newDict2)
		{
			int diff = 0;
			int diff2 = 0;
			if(newDict.Count < newDict2.Count)
			{
				var temp = newDict;
				newDict = newDict2;
				newDict2 = temp;
			}
			foreach (var i in newDict)
			{
				if (newDict2.ContainsKey(i.Key))
				{
					diff = newDict2[i.Key] - i.Value;
					newDict2.Remove(i.Key);
				}
				else
					diff += i.Value;
			}
			foreach(var x in newDict2)
			{
				diff2 = newDict2[x.Key];
			}
			return diff+diff2;
		}
	}
}
