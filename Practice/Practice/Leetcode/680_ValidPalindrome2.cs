using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _680_ValidPalindrome2
    {
        public static void Main(String[] args)
        {
            string s = "bddb";
            _680_ValidPalindrome2 a = new _680_ValidPalindrome2();
            bool result = a.ValidPalindrome(s);
        }
        public bool ValidPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            if (start >= end) return true;
            if (s[start] != s[end])
            {
                if (isPalindrome(s, start + 1, end) || isPalindrome(s, start, end - 1))
                    return true;
                return false;
            }
            return false;
        }

        public bool isPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] == s[end])
                {
                    start++; end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        //public bool validPalindrome(string s)
        //{
        //    int start = 0, end = s.Length - 1;

        //    while (start < end && s[start] == s[end])
        //    {
        //        start++;
        //        end--;
        //    }

        //    if (start >= end) return true;

        //    if (isPalin(s, start + 1, end) || isPalin(s, start, end - 1)) return true;
        //    return false;
        //}

        //private bool isPalin(string s, int start, int end)
        //{
        //    while (start < end)
        //    {
        //        if (s[start] == s[end])
        //        {
        //            start++; end--;
        //        }
        //        else return false;
        //    }
        //    return true;
        //}
    }
}
