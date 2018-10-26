using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _338_Counting_Bits
    {
        public static void Main(String[] args)
        {
            _338_Counting_Bits a = new _338_Counting_Bits();
            int num = 2;
            int[] result = a.CountBits(num);
        }
        public int[] CountBits(int num)
        {
            int[] bits = new int[num + 1];
            bits[0] = 0;
            for (int i = 0; i < num; i++)
            {
                bits[i] = bits[i / 2];
                if (i % 2 == 1)
                    bits[i]++;
            }
            return bits;
        }
    }
}
