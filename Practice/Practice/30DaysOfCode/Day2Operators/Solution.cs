using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Objective
In this challenge, you'll work with arithmetic operators. Check out the Tutorial tab for learning materials and an instructional video!

Task
Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.

Note: Be sure to use precise values for your calculations, or you may end up with an incorrectly rounded result!

Input Format

There are  lines of numeric input:
The first line has a double,  (the cost of the meal before tax and tip).
The second line has an integer,  (the percentage of  being added as tip).
The third line has an integer,  (the percentage of  being added as tax).

Output Format

Print The total meal cost is totalCost dollars., where  is the rounded integer result of the entire bill ( with added tax and tip).

Sample Input

12.00
20
8
Sample Output

The total meal cost is 15 dollars.
Explanation

Given:
, ,

Calculations:




We round  to the nearest dollar (integer) and then print our result:

The total meal cost is 15 dollars.
 */

namespace Practice._30DaysOfCode.Day2Operators
{
	class Solution
	{
		public static void Main(String[] args)
		{
			double mealCost = Convert.ToDouble(Console.ReadLine());
			double tipPercent = Convert.ToInt32(Console.ReadLine());
			double taxPercent = Convert.ToInt32(Console.ReadLine());


			double meal = Math.Round((tipPercent / 100) * mealCost + (taxPercent / 100) * mealCost + mealCost);
			Console.WriteLine(meal);
			Console.ReadKey();

		}
	}
}
