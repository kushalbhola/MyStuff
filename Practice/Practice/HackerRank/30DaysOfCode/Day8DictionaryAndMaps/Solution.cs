using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice._30DaysOfCode.Day8DictionaryAndMaps
{
	public class Solution
	{
		public static void Main(String[] args)
		{
			int _T = Convert.ToInt32(Console.ReadLine());
			Dictionary<int, String> map = new Dictionary<int, string>();
            
			for (int i = 0; i < _T; i++)
			{
				Console.WriteLine("Enter the name");
				string completeString = Console.ReadLine();
				string[] name = completeString.Split(null);
				int number = Convert.ToInt32(name[1]);
				map.Add(number, name[0]);
			}
			Console.WriteLine("Dictionary build Complete");
			Console.WriteLine("Enter a name to search");
			string searchName = Console.ReadLine();

			Console.WriteLine(searchName + "=" + map.Where(x => x.Value == searchName).Select(i => i.Key));
			Console.ReadKey();
		}

	}
}
