using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _62_Unique_Paths
    {
        public static void Main(String[] args)
        {
            _62_Unique_Paths a = new _62_Unique_Paths();
            int result = a.UniquePaths(7, 3);
        }
        public int UniquePaths(int m, int n)
        {
            int[,] DP = new int[m, n];
            int rowLength = DP.GetLength(0);
            int colLength = DP.GetLength(1);
            DP[0, 0] = 0;

            //Initialization
            for (int col = 0; col < colLength; col++)
                DP[0, col] = 1;
            for (int row = 0; row < rowLength; row++)
                DP[row, 0] = 1;

            for (int i = 1; i < rowLength; i++)
            {
                for (int j = 1; j < colLength; j++)
                {
                    DP[i, j] = DP[i - 1, j] + DP[i, j - 1];
                }
            }
            return DP[rowLength - 1, colLength - 1];
        }
    }
}