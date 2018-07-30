using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Warmups
{
    class Factorial
    {
        public static void Main(String[] args)
        {
            int x = 5;
            int result = fact(x);

        }
        private static int fact(int x)
        {
            int[] DP = new int[x];
            DP[0] = 1;
            for(int i = 1; i <= x; i++)
            {
                DP[i] = DP[i - 1] * i;
            }
            return DP[x - 1];
        }
    }
}
