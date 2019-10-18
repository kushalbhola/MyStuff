using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode
{
    class _5_LongestPalindromicSubstring
    {
        public static void Main(String[] args)
        {
            string input = "abcba";

            //https://leetcode.com/problems/length-of-last-word/submissions/
            String s = "a ";
           
            string[] arr = s.Trim().Split(' ');
            int r =  arr[arr.Length - 1].Length;

            _5_LongestPalindromicSubstring a = new _5_LongestPalindromicSubstring();
            string result = a.LongestPalindrome(input);
        }
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 0 || n ==1)
                return s;
            
            string result = null;
            bool[,] DP = new bool[n,n];
            int maxLength = 1;
            int start = 0;
            
            for(int i = 0; i < n; i++)
            {
                DP[i, i] = true;
            }
            //2 letter string will be true iff S[i] == S[j]
            for(int i =0; i < n - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    DP[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
                    
                else
                    DP[i, i + 1] = false;
            }
            //3 letter string will be true iff S[i] == S[j] && DP[i+1, j-1]
            for(int k = 3; k <= n; k++)
            {
                for(int i=0;i<n-k+1;i++)
                {
                    int j = i + k - 1;
                    if(DP[i+1, j-1] && s[i] == s[j])
                    {
                        DP[i, j] = true;
                        if(k>maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }
            return s.Substring(start,maxLength);
        }
    }
}
