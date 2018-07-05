using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _9_Palindrome_Number
    {
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
    }
}
