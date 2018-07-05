using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _3_Longest_Substring_Without_Repeating_Characters
    {
        static void Main(String[] args)
        {
            string input = "abca";
            int result = LengthOfLongestSubstring(input);
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int ans = 0;
            int n = s.Length;
            int i = 0; int j = 0;
            HashSet<char> hash = new HashSet<char>();
            while(i<n && j < n)
            {
                if (!hash.Contains(s[j]))
                {
                    hash.Add(s[j++]);
                }
                else
                {
                    hash.Remove(s[i++]);
                }
                ans = Math.Max(ans, j - i);
            }
            return ans;

        }
    }
}
