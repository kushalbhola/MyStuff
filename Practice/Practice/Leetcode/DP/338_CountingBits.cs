using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _338_CountingBits
    {
        public static void Main(String[] args)
        {
            _338_CountingBits a = new _338_CountingBits();
            int[] result = a.CountBits(5);
        }
        public int[] CountBits(int num)
        {
            int[] result = new int[num + 1];
            result[0] = 0;
            for (int i = 1; i <= num; i++)
            {
                int tmp = (i & (i - 1));
                result[i] = result[tmp] + 1;
            }
            return result;
        }
    }
}