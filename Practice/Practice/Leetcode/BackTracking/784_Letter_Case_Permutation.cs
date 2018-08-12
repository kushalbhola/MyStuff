using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.BackTracking
{
    class _784_Letter_Case_Permutation
    {
        public static void Main(String[] args)
        {
            string s = "a1b2";
            _784_Letter_Case_Permutation a = new _784_Letter_Case_Permutation();
            IList<string> result = a.LetterCasePermutation(s);
        }
        public IList<string> LetterCasePermutation(string S)
        {
            List<String> ans = new List<string>();
            compute(ans, S.ToCharArray(), 0);
            return ans;
        }
        public void compute(List<String> ans, char[] chars, int index)
        {
            if (index == chars.Length)
                ans.Add(new String(chars));
            else
            {
                if (Char.IsLetter(chars[index]))
                {
                    chars[index] = Char.ToLower(chars[index]);
                    compute(ans, chars, index + 1);
                    chars[index] = Char.ToUpper(chars[index]);
                }
                compute(ans, chars, index + 1);
            }
        }
    }
}
