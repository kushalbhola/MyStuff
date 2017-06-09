using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Objective
//In this challenge, we're getting started with conditional statements. Check out the Tutorial tab for learning materials and an instructional video!

//Task
//Given an integer, , perform the following conditional actions:

//If  is odd, print Weird
//If  is even and in the inclusive range of  to , print Not Weird
//If  is even and in the inclusive range of  to , print Weird
//If  is even and greater than, print Not Weird
//Complete the stub code provided in your editor to print whether or not  is weird.

//Input Format

//A single line containing a positive integer, .

//Constraints

//Output Format

//Print Weird if the number is weird; otherwise, print Not Weird.

//Sample Input 0

//3
//Sample Output 0

//Weird
//Sample Input 1

//24
//Sample Output 1

//Not Weird
//Explanation

//Sample Case 0:
// is odd and odd numbers are weird, so we print Weird.

//Sample Case 1:
// and  is even, so it isn't weird. Thus, we print Not Weird.
/// </summary>

namespace Practice._30DaysOfCode.Day3IntroConditionalStatements
{
	class Solution
	{
		public static void Main(String[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			String ans = "";

			// if 'n' is NOT evenly divisible by 2 (i.e.: n is odd)
			if (n >= 1 && n <= 100)
			{
				if (n % 2 == 1)
				{
					ans = "Weird";
				}
				else if (n % 2 == 0 && (n >= 2 && n <= 5))
				{
					ans = "Not Weird";
				}
				else if (n % 2 == 0 && (n >= 6 && n <= 20))
				{
					ans = "Weird";
				}
				else if (n % 2 == 0 && (n > 20))
				{
					ans = "Not Weird";
				}
			}
			Console.WriteLine(ans);
			Console.ReadKey();
		}
	}
}
