using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Problem: https://www.hackerrank.com/contests/dstest-1/challenges/character-game
/* The above problem is same as the Programming interview Exposed Page: 91
 * The hackerank solution is expected in java, so didnt feel like converting it to java :(
 */
namespace Practice.ProgrammingInterviewExposed.ArraysAndStrings
{
    class FirstNonrepeatedCharacter
    {
        public static void Main(String[] args)
        {
            string input = "Karpagam";
            char[] ch = input.ToCharArray();
            bool flag = false;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(var c in ch)
            {
                if (dict.ContainsKey(c))
                    dict[c] = dict[c] + 1;
                else
                    dict.Add(c, 1);
            }
            foreach(var x in dict)
            {
                if (x.Value == 1)
                {
                    Console.WriteLine(x.Key);
                    flag = true;
                    break;
                }
                    
            }
            if (!flag)
                Console.WriteLine("-1");
            Console.ReadLine();
        }
    }
}
