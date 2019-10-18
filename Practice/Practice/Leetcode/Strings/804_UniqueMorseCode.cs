using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Strings
{
    class _804_UniqueMorseCode
    {
        public static void Main(String[] args)
        {
            string[] words = { "gin", "zen", "gig", "msg" };
            int result = UniqueMorseRepresentations(words);
        }
        public static int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> dict = BuildDictionary();
            HashSet<string> hash = new HashSet<string>();
            foreach(string w in words)
            {
                char[] charArray = w.ToCharArray();
                string intermediateResult = "";
                foreach(char c in charArray)
                {
                    intermediateResult += dict[c];
                }
                hash.Add(intermediateResult);
            }
            return hash.Count;
        }
        public static Dictionary<char, string> BuildDictionary()
        {
            Dictionary<char, string> hash = new Dictionary<char, string>();
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            for (int i = 0; i < 26; i++)
            {
                char c = Convert.ToChar(i+97);
                hash.Add(c, morse[i]);
            }
            return hash;
        }
    }
}
