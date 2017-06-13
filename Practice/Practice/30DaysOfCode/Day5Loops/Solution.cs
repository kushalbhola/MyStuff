using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice._30DaysOfCode.Day5Loops
{
	class Solution
	{
		public static void Main(String[] args)
		{
			//Scanner in = new Scanner(System.in);
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(n + " x " + i + " = " + i * n);
			}
			Console.ReadLine();
		}
	}
}
