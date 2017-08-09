using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.RecurssionDavisStaircase
{
	class Solution
	{
		static void Main(String[] args)
		{
			//int s = Convert.ToInt32(Console.ReadLine());
			//for (int a0 = 0; a0 < s; a0++)
			//{
			//	int n = Convert.ToInt32(Console.ReadLine());
			//}
			//Console.WriteLine(findStepsRecur(7));
			Console.WriteLine(findStepsMemo(3));
			Console.ReadLine();
			//int temp1 = s % 2;
			//int temp2 = s / 2;
		}
		static int findStepsRecur(int steps)
		{
			if (steps < 0)
				return 0;
			else if (steps == 0 ||steps == 1)
			{
				return 1;
			}
			else
				return findStepsRecur(steps - 1) + findStepsRecur(steps - 2) + findStepsRecur(steps - 3);
			
		}
		static int findStepsMemo(int steps)
		{
			return findStepsMemo(steps, new int[steps + 1]);
		}
		static int findStepsMemo(int steps, int[] memo)
		{
			if (steps < 0)
				return 0;
			else if (steps == 0 || steps == 1)
			{
				return 1;
			}
			else if (memo[steps]  == 0)
			{
				memo[steps] = findStepsMemo(steps - 1, memo) + findStepsMemo(steps - 2, memo) + findStepsMemo(steps - 3, memo);
			}
			return memo[steps];
		}

		static int findStepsDP(int steps)
		{
			if (steps < 0)
				return 0;
			else if (steps == 0 || steps == 1)
			{
				return 1;
			}
			int[] paths = new int[steps + 1];
			paths[0] = 1;
			paths[1] = 1;
			paths[2] = 2;
			for(int i = 3; i <= steps; i++)
			{
				paths[i] = paths[i - 1] + paths[i - 2] + paths[i - 3];
			}
			return paths[steps];
		}

		static int findStepsDP2(int steps)
		{
			if (steps < 0)
				return 0;
			else if (steps == 0 || steps == 1)
			{
				return 1;
			}
			int[] paths = { 1, 1, 2 };
			for (int i = 3; i <= steps; i++)
			{
				int count = paths[0] + paths[1] + paths[2];
				paths[0] = paths[1];
				paths[1] = paths[2];
				paths[2] = count;
			}
			return paths[2];
		}
	}
}
