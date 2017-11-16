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
            /*
             * Arr= 12345
             * Rotation 1: 23451
             * Rotation 2: 34512, 
             * 45123
             * 51234
             * 12345
             * 23451
             * So algorithm is , to rotate an array, take the continuous array sequence from 0 to 2, and then take the continuos sequence from that point till the end
             * Important: What if the d > 5, the rotation should be cyclic, so just pass d/a.Length
             * */
			int[] a = { 1,2,3,4,5};
			int d = 6;
			string newArray = rotate(d/a.Length, a);
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
