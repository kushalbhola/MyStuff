using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _264_UglyNumber_2
    {
        public static void Main(String[] args)
        {
            int result = NthUglyNumber(10);
        }
        public static int NthUglyNumber(int n)
        {
            int[] finalNums = new int[n];
            int i = 1;
            finalNums[0] = 1;
            int twoCount = 0;int threeCount = 0;int fiveCount = 0;
            int twoValue = 2; int threeValue = 3; int fiveValue = 5;
            while (i < n)
            {
                finalNums[i] = Math.Min(Math.Min(twoValue, threeValue), fiveValue);
                if(finalNums[i] == twoValue)
                {
                    twoCount++;
                    twoValue = finalNums[twoCount] * 2;
                }
                if (finalNums[i] == threeValue)
                {
                    threeCount++;
                    threeValue = finalNums[threeCount] * 3;
                }
                if (finalNums[i] == fiveValue)
                {
                    fiveCount++;
                    fiveValue = finalNums[fiveCount] * 5;
                }
                i++;
            }
            return finalNums[i-1];
        }
    }
}
