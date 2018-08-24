using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _357_Count_Numbers_With_Unique_Digits
    {
        public static void Main(String[] args)
        {
            int x = 111;
            char[] ch = x.ToString().ToCharArray();
            Dictionary<char, int> hash = new Dictionary<char, int>();
            foreach (char c in ch)
            {
                if (hash.ContainsKey(c))
                    hash[c] += 1;
                else
                    hash[c] = 1;
            }
        }
    }
}
