using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _712_Minimum_ASCII_Delete_Sum_for_Two_Strings
    {
        public static void Main(String[] args)
        {
            string s1 = "sea";
            string s2 = "eat";
            _712_Minimum_ASCII_Delete_Sum_for_Two_Strings a = new _712_Minimum_ASCII_Delete_Sum_for_Two_Strings();
            int result = a.MinimumDeleteSum(s1, s2);
        }
        /*
         * let DP[i,j] be the sum of ascii from arr[i] and arr[j] to make them equal                                                                                                                                                                                                                                          
         * */
        public int MinimumDeleteSum(string s1, string s2)
        {
            int[,] DP = new int[s1.Length + 1, s2.Length + 1];

            DP[0, 0] = 0;
            for(int k = 1; k < DP.GetLength(0); k++)
            {
                DP[k, 0] = (int)s1[k-1] + DP[k-1,0];
            }
            for (int k = 1; k < DP.GetLength(1); k++)
            {
                DP[0,k] = (int)s2[k-1] + DP[0,k-1];
            }
            int i = 0;int j = 0;
            for(i=1;i<DP.GetLength(0);i++)
            {
                for(j = 1; j < DP.GetLength(1); j++)
                {
                    if(s1[i-1] == s2[j - 1])
                    {
                        DP[i, j] = DP[i - 1, j - 1];
                    }
                    else
                    {
                        DP[i, j] = Math.Min(DP[i - 1, j] + s1[i - 1], DP[i, j - 1] + s2[j - 1]);
                    }
                }
            }
            return DP[i-1, j-1];
        }
    }
}
