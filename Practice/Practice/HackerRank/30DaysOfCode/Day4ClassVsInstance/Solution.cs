using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice._30DaysOfCode.Day4ClassVsInstance
{
	class Solution
	{

		static void Main(String[] args)
		{
			int T = int.Parse(Console.In.ReadLine());
			for (int i = 0; i < T; i++)
			{
				int age = int.Parse(Console.In.ReadLine());
				Person p = new Person(age);
				p.amIOld();
				for (int j = 0; j < 3; j++)
				{
					p.yearPasses();
				}
				p.amIOld();
				Console.WriteLine();
			}
		}
	}

}

