using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BackTracking
{
    class _17_LetterCombinationsPhoneNumber
    {
        public static void Main(String[] args)
        {
            _17_LetterCombinationsPhoneNumber a = new _17_LetterCombinationsPhoneNumber();
            var result = a.LetterCombinations("2");
        }
        public IList<string> LetterCombinations(string digits)
        {
            
            char[] ch = digits.ToCharArray();
            Dictionary<int, string> lookup = new Dictionary<int, string>();
            lookup.Add(1, null);
            lookup.Add(2, "abc");
            lookup.Add(3, "def");
            lookup.Add(4, "ghi");
            lookup.Add(5, "jkl");
            lookup.Add(6, "mno");
            lookup.Add(7, "pqrs");
            lookup.Add(8, "tuv");
            lookup.Add(9, "wxyz");
            IList<string> result = new List<string>();
            if (digits == "") return result;
            string input = null;
            for (int i = 0; i < ch.Length; i++)
            {
                int x = Int32.Parse(ch[i].ToString());
                input += lookup[x];
            }

            string tempString = null;
            LetterCombinationHelper(result, input, tempString, 0);
            return result;
        }
        public void LetterCombinationHelper(IList<string> result, string input, string tempString, int start)
        {
            if (tempString != null && tempString.Length == 2)
            {
                result.Add(tempString);
                return;
            }
            for (int i = start; i < input.Length; i++)
            {
                if (tempString != null && tempString.Length == 0 && i >= input.Length / 2)
                {
                    break;
                }
                tempString += input[i].ToString();
                LetterCombinationHelper(result, input, tempString, 3);
                tempString = tempString.Remove(tempString.Length - 1);
            }
        }
    }
}
