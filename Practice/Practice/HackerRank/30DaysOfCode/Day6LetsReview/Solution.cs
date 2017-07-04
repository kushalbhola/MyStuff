using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice._30DaysOfCode.Day6LetsReview
{
	class Solution
	{
		public static void Main(String[] args)
		{
			int _N = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < _N; i++)
			{
				String text = Console.ReadLine();
				String oddPart = "";
				String evenPart = "";
				char[] ch = text.ToCharArray();
				for (int j = 0; j < ch.Length; j++)
				{
					if (j % 2 == 0)
					{
						evenPart = evenPart + ch[j];
					}
					else
					{
						oddPart = oddPart + ch[j];
					}
				}
				Console.WriteLine(evenPart + " " + oddPart);
				text = null;
			}
			Console.ReadKey();
		}
	}
}
