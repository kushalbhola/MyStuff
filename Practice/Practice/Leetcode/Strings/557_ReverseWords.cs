using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Strings
{
    class _557_ReverseWords
    {
        public static void Main(String[] args)
        {
            _557_ReverseWords a = new _557_ReverseWords();
            string input = "Let's take LeetCode contest";
            string output = ReverseWords(input);
        }
        public static string ReverseWords(string s)
        {
            string[] stringArray = s.Split(' ');
            //List<string> final = new List<string>();
            string final = "";
            foreach (string x in stringArray)
            {
                string tempString = Reverse(x);
                final = final + tempString + " ";
            }

            return final.Trim();
        }
        public static string Reverse(string s)
        {
            char[] ch = s.ToCharArray();
            int start = 0;
            int end = ch.Length - 1;

            while (end > start)
            {
                char test = ch[start];
                ch[start] = ch[end];
                ch[end] = test;
                start++; end--;
            }
            return new string(ch);
        }
    }
}
