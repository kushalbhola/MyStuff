using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//kushal bhola
//Problem: https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
namespace Practice.CrackingCodingInterview.Making_Anagrams
{
	class Solution
	{
        static void Main(String[] args)
        {
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            string a = "bugexikjevtubidpulaelsbcqlupwetzyzdvjphn";
            string b = "lajoipfecfinxjspxmevqxuqyalhrsxcvgsdxxkacspbchrbvvwnvsdtsrdk";
            Console.WriteLine(find(a, b));
            Console.ReadLine();
        }

        static int find(string first, string second)
        {
            int[] letterCount = new int[26];
            foreach (var a in first.ToCharArray())
            {
                letterCount[a - 'a']++;
            }
            foreach (var b in second.ToCharArray())
            {
                letterCount[b - 'a']--;
            }
            return letterCount.Sum(c => Math.Abs(c));
        }
    }
}
