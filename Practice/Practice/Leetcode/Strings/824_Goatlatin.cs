using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Strings
{
    class _824_Goatlatin
    {
        public static void Main(String[] args)
        {
            string input = "I speak Goat Latin";
            _824_Goatlatin a = new _824_Goatlatin();
            string result = a.ToGoatLatin(input);
        }
        public string ToGoatLatin(string S)
        {
            if (S == null)
                return null;
            string[] str = S.Split(' ');
            string final = "";
            for (int i = 0; i < str.Length; i++)
            {
                final += convert(str[i], i + 1) + " ";
            }
            char c = 'a';
            int y = c;

            return final.Trim();
        }
        public string convert(string S, int len)
        {
            //int len = S.Length;
            if (
               S[0].ToString().ToLower() == "a"
             || S[0].ToString().ToLower() == "e"
             || S[0].ToString().ToLower() == "i"
             || S[0].ToString().ToLower() == "o"
             || S[0].ToString().ToLower() == "u"
              )
            {
                S = S + "ma";
            }
            else if (
            S[0].ToString().ToLower() != "a"
            && S[0].ToString().ToLower() != "e"
            && S[0].ToString().ToLower() != "i"
            && S[0].ToString().ToLower() != "o"
            && S[0].ToString().ToLower() != "u"
                )
            {
                string newString = S.Substring(1, S.Length - 1);
                S = newString + S[0].ToString() + "ma";
            }
            for (int i = 1; i <= len; i++)
            {
                S = S + "a";
            }
            return S;
        }
    }
}
