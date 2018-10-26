using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class SmallestPositiveInteger
    {
        public static void Main(String[] args)
        {
            int[] A = { 1,2,3 };
            SmallestPositiveInteger ob = new SmallestPositiveInteger();
            int result = ob.solution(A);
        }
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            //build a hash table
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (dict.ContainsKey(A[i]))
                    dict[A[i]] += 1;
                else
                    dict[A[i]] = 1;
            }
            int j = 0;
            for (j = 1; j <= A.Length; j++)
            {
                if (!dict.ContainsKey(j))
                    return j;
            }
            return j;
    }
    }
}
