using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 URL: https://www.hackerrank.com/challenges/palindrome-index
 My solution is very similar to the one on geeksForgeeks. Here
 http://www.geeksforgeeks.org/remove-character-string-make-palindrome/
 But for some reason Hackerrank didnt liked mine :(
	 */
namespace Practice.HackerRank.Algorithms.Strings
{
	class PalindromeIndex
	{
		static int palindromeIndex(string s)
		{
			// Complete this function
			if (checkPaildrome(s))
				return -1;
			else
			{
				int head = 0; int tail = s.Length - 1;
				char[] ch = s.ToCharArray();
				while(tail> head)
				{
					if(ch[head] != ch[tail])
					{
						char[] newChar = new char[ch.Length - 1];
						for (int i = 0; i < tail; i++)
						{
							newChar[i] = ch[i]; //transfer everything till tail to new array
						}
						for (int i = tail; i < ch.Length - 1; i++)
						{
							newChar[i] = ch[i + 1];
						}

						char[] newChar2 = new char[ch.Length - 1];
						int tail2 = head;
						for (int i = 0; i < tail2; i++)
						{
							newChar2[i] = ch[i]; //transfer everything till tail to new array
						}
						for (int i = tail2; i < ch.Length - 1; i++)
						{
							newChar2[i] = ch[i + 1];
						}
						if (checkPaildrome(new string(newChar)))
						{
							return tail;
						}
						else if(checkPaildrome(new string(newChar2)))
						{
							return tail2;
						}
						head++;
						tail--;
					}
				}
			}
			return -1;
		}

		static bool checkPaildrome(string s)
		{
			char[] ch = s.ToCharArray();
			Array.Reverse(ch);
			string newStr = new string(ch);
			if (s.Equals(newStr))
				return true;
			else
				return false;
		}
		public static void Main(String[] args)
		{
			int q = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < q; a0++)
			//for (int a0 = 0; a0 < 1; a0++)
			{
				string s = Console.ReadLine();
				int result = palindromeIndex(s);
				//int result = palindromeIndex("aaab");
				Console.WriteLine(result);
			}
			Console.ReadLine();
		}
	}
}

