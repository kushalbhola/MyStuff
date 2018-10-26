using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice.Leetcode
{
    class _125_ValidPalindrome
    {
        public static void Main(String[] args)
        {
            string s = "A man, a plan, a canal: Panama";
            _125_ValidPalindrome a = new _125_ValidPalindrome();
            bool result = a.IsPalindrome(s);
        }
        public bool IsPalindrome(string s)
        {
            s = s.ToLower().Replace(" ", string.Empty);
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s,"");
            int start = 0;
            int end = s.Length - 1;
            while(end> start)
            {
                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else return false;
            }
            return true;
        }
    }
}
