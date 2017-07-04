using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * 
 to make it more performant:
 1. String: abdabc
 2. Pattern: abc
 3. hash(abc) = X
 4. Compare each 3 character pattern in string and compare it with the hashed X. 
		4.1 If there is no match than move one character forward and keep going.
		4.2 If there is a match than double check by actually comparing the 2 pattern strings.

 5. Rolling Hash: Rolling has is a technique of calculating subsequent hashes of the patterns while moving in the string by using the 
	hash of the last calculated value 

	// ASCII a = 97, b = 98, r = 114. 
hash("abr") = (97 × 1012) + (98 × 1011) + (114 × 1010) = 999,509 


	//             base   old hash    old 'a'         new 'a'
hash("bra") = [1011 × (999,509 - (97 × 1012))] + (97 × 1010) = 1,011,309

	 */
namespace Practice.HackerEarth
{
	class MicroMini
	{
		static void Main(String[] args)
		{
			int T = Convert.ToInt32(Console.ReadLine());
			ArrayList results = new ArrayList();
			for(int j = 0; j < T; j++)
			{
				string str = Console.ReadLine();
				char[] chr = str.ToCharArray();
				int numRevolutions = str.Length;
				int nulRotations = 0;
				Dictionary<int, string> dict = new Dictionary<int, string>();
				for (int i = 0; i < numRevolutions; i++)
				{
					//just check to see if oldCHR is NotFiniteNumberException equal to newChr
					string temp = new string(chr);
					if(!dict.ContainsValue(temp))
						dict.Add(i, temp);
					char[] newChar = new char[chr.Length];
					newChar = revolve(chr);
					if (!checkCharComparity(dict, newChar))
					{
						nulRotations++;
						chr = newChar;
					}
				}
				if (nulRotations == 0)
				{
					//results.Add(1);
					results.Add(dict.Count);
					//Console.WriteLine(1);
				}
				else
				{
					//results.Add(nulRotations+1);
					results.Add(dict.Count);
					//Console.WriteLine(nulRotations);
				}
			}
			foreach (var x in results)
			{
				Console.WriteLine(x);
			}
			Console.ReadLine();
		}
		static char[] revolve(char[] chr)
		{
			char[] newChar = new char[chr.Length];
			for (int i = 0; i < chr.Length - 1; i++)
			{
				newChar[i + 1] = chr[i];
			}
			newChar[0] = chr[chr.Length - 1];
			return newChar;
		}


		static bool checkCharComparity(Dictionary<int, string> dict, char[] newChar)
		{
			if (dict.ContainsValue(new string(newChar)))
				return true;
			else
				return false;
		}
	}
}


