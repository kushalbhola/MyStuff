using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Problem; https://www.hackerrank.com/challenges/mars-exploration/problem
/* Algorithm:
 * 1.  Find the length 
 * 2.  Build an array with expected occurences of S, O and S
 * 3.  Copare it with the actual
 */

namespace Practice.HackerRank.Algorithms.Strings
{
    public class MarsExploration
    {
        public static void Main(String[] args)
        {
            //string S = Console.ReadLine();
            string S = "SOSSPSSQSSOR";
            string sos = "SOS";
            int result = 0;
            for(int i = 0; i < S.Length; i++)
            {
                if (S[i] != sos[i % 3])
                    result++;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
