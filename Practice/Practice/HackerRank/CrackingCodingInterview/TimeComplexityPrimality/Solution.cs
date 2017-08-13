using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.TimeComplexityPrimality
{
	class Solution
	{
		static void Main(String[] args)
		{
			int p = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < p; a0++)
			{
				int n = Convert.ToInt32(Console.ReadLine());

				if (CheckPrime2(n))
					Console.WriteLine("Not prime");
				else
					Console.WriteLine("Prime");
			}
			Console.ReadKey();
		}
		static bool CheckPrime(int n)
		{
			if (n == 2)
				return true;
			else if (n % 2 == 0 && n != 2)
				return false;
			else
			{
				for (int i = 3; i <= n; i = i + 2)
				{
					if (n % i == 0 && i!=n)
						return false;
				}
			}
			return true;
		}
		static bool CheckPrime2(int n)
		{
			int j = (int)Math.Sqrt(n);
			if (n == 1)
				return false;
			else
			{
				for(int i = 2; i <= j; ++i)
				{
					if(n%i == 0)
					{
						return true;
					}
				}
				return false;
			}
		}
	}
}
