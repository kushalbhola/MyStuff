using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _389_Find_the_Difference
    {
        public static void Main(String[] args)
        {
            string s = "a";
            string t = "aa";
            _389_Find_the_Difference a = new _389_Find_the_Difference();
            char result = a.FindTheDifference(s, t);
        }
        public char FindTheDifference(string s, string t)
        {
            char[] ch1 = s.ToCharArray();
            char[] ch2 = t.ToCharArray();

            //convery s to hashMap
            Dictionary<char, int> hash = new Dictionary<char, int>();
            if (ch2.Length > ch1.Length)
            {
                for (int i = 0; i < ch2.Length; i++)
                {
                    if (hash.ContainsKey(ch2[i]))
                        hash[ch2[i]] += 1;
                    else
                        hash[ch2[i]] = 1;
                }
            }
            else
            {
                for (int i = 0; i < ch1.Length; i++)
                {
                    if (hash.ContainsKey(ch1[i]))
                        hash[ch1[i]] += 1;
                    else
                        hash[ch1[i]] = 1;
                }
            }

            for (int j = 0; j < ch1.Length; j++)
            {
                if (hash.ContainsKey(ch1[j]) && hash[ch1[j]] > 1)
                {
                    hash[ch1[j]]--;
                }
                else if(hash.ContainsKey(ch1[j]) && hash[ch1[j]] == 1)
                {
                    hash.Remove(ch1[j]);
                }
                    
            }
            return hash.Select(x=>x.Key).First();
        }
    }
}
