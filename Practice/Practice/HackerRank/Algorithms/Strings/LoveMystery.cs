using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Problem URL: https://www.hackerrank.com/challenges/the-love-letter-mystery
 */
namespace Practice.HackerRank.Algorithms.Strings
{
	class LoveMystery
	{
		static int theLoveLetterMystery(string s)
		{
			// Complete this function
			int tail = s.Length - 1;
			int head = 0;
			char[] ch = s.ToCharArray();
			int results = 0;

			while(tail > head)
			{
				while (ch[head] != ch[tail])
				{
					if (ch[head] > ch[tail])
					{
						ch[head] = (char)(ch[head] - 1);
						results++;
					}
					else if (ch[head] < ch[tail])
					{
						ch[tail] = (char)(ch[tail] - 1);
						results++;
					}
				}
				tail--;
				head++;
			}
			return results;
		}

		public static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < q; a0++)
			{
				string s = Console.ReadLine();
				int result = theLoveLetterMystery(s);
				//int result = theLoveLetterMystery("abc");
				Console.WriteLine(result);
			}
			Console.ReadLine();
		}
	}
}
