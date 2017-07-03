using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerEarth
{
	class MicroMini
	{
		static void Main(String[] args)
		{
			string str = "abcd";
			char[] chr = str.ToCharArray();
			int numRevolutions = str.Length;
			for(int i = 0; i < numRevolutions; i++)
			{
				//just check to see if oldCHR is NotFiniteNumberException equal to newChr
				chr = revolve(chr);
			}
			
		}
		static char[] revolve(char[] chr)
		{
			char[] newChar = new char[chr.Length];
			for(int i = 0; i < chr.Length-1; i++)
			{
				newChar[i+1] = chr[i];
			}
			newChar[0] = chr[chr.Length - 1];
			return newChar;
		}
 	}
}
