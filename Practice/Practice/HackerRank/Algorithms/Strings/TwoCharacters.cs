using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Problem: https://www.hackerrank.com/challenges/two-characters/problem
/*
 * Loop through the string
 * first put each character in hashmap
 * then if the char[i] == char[i+1] then delete that HashMap(i)
 * print out all the values of hashmap
 */
namespace Practice.HackerRank.Algorithms.Strings
{
    public class TwoCharacters
    {
        public static void Main(String[] arg)
        {
            string input = "beabeefeab";
            char[] inputChar = input.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            //build the hashMap
            foreach (var x in inputChar)
            {
                if (dict.ContainsKey(x))
                {
                    dict[x] = dict[x] + 1;
                }
                else
                    dict.Add(x, 1);
            }

            //Loop throught the array
            if (inputChar.Length > 0)
            {
                for (int i = 1; i < inputChar.Length; i++)
                {
                    if(inputChar[i] == inputChar[i - 1])
                    {
                        dict.Remove(inputChar[i]);
                    }
                }
            }
        }

    }
}
