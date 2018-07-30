using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _263_UglyNumber
    {
        public static void Main(String[] args)
        {
            int num = 14;
            bool result = IsUgly(num);
        }
        public static bool IsUgly(int num)
        {
            if (num <= 0)
            {
                return false;
            }
            int[] divisors = { 2, 3, 5 };
            for (int i = 0; i < divisors.Length; i++)
            {
                while (num % divisors[i] == 0)
                    num = num / divisors[i];
            }
            return num == 1;
        }

    }
}
