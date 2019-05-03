using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _9_Palindrome_Number
    {
        public static void Main(String[] args)
        {
            _9_Palindrome_Number a = new _9_Palindrome_Number();
            bool result = a.IsPalindrome2(-10);
            bool result2 = a.IsPalindrome(121);
        }
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reverse = 0;
            while (x > reverse)
            {
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }
            if (x == reverse || x == reverse / 10)
                return true;
            return false;

        }
        public bool IsPalindrome2(int x)
        {
            char[] ch = x.ToString().ToCharArray();
            int start = 0;
            int end = ch.Length-1;
            bool flag = false;

            while(end > start)
            {
                start++;
                end--;
                if (ch[start] == ch[end] && start >= end)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
