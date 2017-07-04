
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.BalancedBrackets
{
	class Solution
	{
		static void Main(String[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine());
			string[] results = new string[t];
			for (int a0 = 0; a0 < t; a0++)
			{
				string expression = Console.ReadLine();
				Stack s = new Stack();
				char[] arr = expression.ToCharArray();
				foreach (var c in arr)
				{
					if (c == '(') s.Push(c);
					else if (c == '{') s.Push(c);
					else if (c == '[') s.Push(c);

					else if (c == ')' && s.Count > 0)
					{
						if ((char)s.Peek() == '(') s.Pop();
					}
					else if (c == '}' && s.Count > 0)
					{
						if ((char)s.Peek() == '{') s.Pop();
					}
					else if (c == ']' && s.Count > 0)
					{
						if ((char)s.Peek() == '[') s.Pop();
					}
					else
					{
						results[a0] = "NO";
						break;
					}

				}
				if (s.Count > 0)
				{
					if (results[a0] == null) results[a0] = "NO";
				}
				else
				{
					if (results[a0] == null) results[a0] = "YES";
				}
			}
			foreach (var i in results)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();
		}
	}
}
