using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Strings
{
    class _917
    {
        public static void Main(String[] args)
        {
            _917 a = new _917();
            string input = "z<*zj";
            string output = a.ReverseOnlyLetters(input);
        }
        public string ReverseOnlyLetters(string S)
        {
            char[] ch = S.ToCharArray();
            int start = 0;
            int end = S.Length - 1;
            while (end > start)
            {
                int asciiValStart = ch[start];
                int asciiValEnd = ch[end];
                if (!((asciiValStart >= 65 && asciiValStart <= 90)
                 || (asciiValStart >= 97 && asciiValStart <= 122)))
                {
                    start++;
                }
                else if (!((asciiValEnd >= 65 && asciiValEnd <= 90)
                 || (asciiValEnd >= 97 && asciiValEnd <= 122)))
                {
                    end--;
                }
                else
                {
                    char temp = ch[start];
                    ch[start] = ch[end];
                    ch[end] = temp;
                    start++;
                    end--;
                }
            }
            return ch.ToString();
        }
    }
}
