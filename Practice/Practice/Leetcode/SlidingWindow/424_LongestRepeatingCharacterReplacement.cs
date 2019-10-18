using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/longest-repeating-character-replacement/
namespace Practice.Leetcode.SlidingWindow
{
    class _424_LongestRepeatingCharacterReplacement
    {
        public static void Main(String[] args)
        {
            _424_LongestRepeatingCharacterReplacement a = new _424_LongestRepeatingCharacterReplacement();
            string s = "AABABBA";
            int k = 1;
            int result = a.CharacterReplacement(s, k);
        }
        public int CharacterReplacement(string s, int k)
        {
            /*
            Algo:
             The whole idea is that if we have a string of length N out of which M characters are same,
            we can replace (N - M) characters to get a continueous string of N characters. 
            If M <= K. N is the local maximum for this window.
            If this length is greater than K. Slide the window.
            */

            int size = s.Length;
            int ret = 0;
            int[] count = new int[26];
            int start = 0;
            int end = 0;
            int globalMaxFreq = 0;
            for(; end < size; end++)
            {
                count[s[end] - 'A']++;
                globalMaxFreq = Math.Max(globalMaxFreq, count[s[end] - 'A']);
                if((end-start+1) - globalMaxFreq > k)
                {
                    ret = Math.Max(ret, (end - start));
                    count[s[end] - 'A']--;
                    start++;
                }
            }
            return Math.Max(ret, end-start);
        }
    }
}
