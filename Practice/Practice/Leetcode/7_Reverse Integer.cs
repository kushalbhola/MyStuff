using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _7_Reverse_Integer
    {
        public static void Main(String[] args)
        {
            int x = 123;
            int result = reverse(x);
        }
        private static int reverse(int x)
        {
            if (x < 10 && x > -10) return x;
            List<int> final = new List<int>();
            while (x >= 10 || x <= -10)
            {

                int a = x % 10; // units degit
                final.Add(a);
                x = x / 10;
            }
            final.Add(x);
            int result = convertArrayToInt(final.ToArray());
            return result;
            //int result = 0;
            //while (x != 0)
            //{
            //    int tail = x % 10;
            //    int newResult = result * 10 + tail;
            //    if ((newResult - tail) / 10 != result)
            //    { return 0; }
            //    result = newResult;
            //    x = x / 10;
            //}
            //return result;

        }
        private static int convertArrayToInt(int[] f)
        {
            int len = f.Length;
            int factor = (int)(Math.Pow(10, len -1 ));
            int final = 0;
            for (int i = 0; i < f.Length; i++)
            {
                int temp = f[i];
                final = final + temp * factor;
                factor = factor / 10;
            }
            return final;
        }

    }
}
