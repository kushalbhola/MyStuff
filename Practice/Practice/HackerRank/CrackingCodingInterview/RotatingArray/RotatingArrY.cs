using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview
{
	class RotatingArray
	{
		public static void Main(String[] args)
		{
			//string[] tokens_n = Console.ReadLine().Split(' ');
			//int n = Convert.ToInt32(tokens_n[0]);
			//int k = Convert.ToInt32(tokens_n[1]);
			//string[] a_temp = Console.ReadLine().Split(' ');
			//int[] a = Array.ConvertAll(a_temp, Int32.Parse);

			int[] a = { 1,2,3,4,5};
			int d = 4;
			string newArray = rotate(d, a);
			Console.Write(newArray);
			Console.ReadLine();
		}
		static string rotate(int rot, int[] arr)
		{
			string left = string.Join(
				" ", arr.Take(rot).ToArray()
			);
			string right = string.Join(
				" ", arr.Skip(rot).ToArray()
			);
			return right + ' ' + left;
		}
		static void rotate2(int rot, int[] arr)
		{
			int[] first = arr.Take(rot).ToArray();
			int[] second = arr.Skip(rot).ToArray();

		}
	}
}
