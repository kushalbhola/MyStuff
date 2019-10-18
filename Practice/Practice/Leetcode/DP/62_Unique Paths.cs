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
            //int result = a.UniquePaths(7, 3);
            int[,] grid =
            {
                {0,0,0 },
                {0,1,0 },
                {0,0,0 }
            };

            int[,] grid2 = {
                                { 0,0},
                                { 1,1},
                                {0,0 }
                           };
            int result = a.UniquePathsWithObstacles(grid2);
            result = a.UniquePaths2(3, 2);

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
        //https://leetcode.com/problems/unique-paths-ii/description/
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int rowLength = obstacleGrid.GetLength(0);
            int colLength = obstacleGrid.GetLength(1);

            int[,] DP = new int[rowLength, colLength];
            for (int col = 0; col < colLength; col++)
            {
                if (obstacleGrid[0, col] != 1)
                    DP[0, col] = 1;
                else
                    DP[0, col] = 0;
            }

            for (int row = 0; row < rowLength; row++)
            {
                if (obstacleGrid[row, 0] != 1)
                    DP[row, 0] = 1;
                else
                    DP[row, 0] = 0;

            }
            for (int i = 1; i < rowLength; i++)
            {
                for (int j = 1; j < colLength; j++)
                {
                    if (obstacleGrid[i, j] != 1)
                        DP[i, j] = Math.Min(DP[i - 1, j], DP[i, j - 1]);
                    else
                        DP[i, j] = Int32.MaxValue;
                }
            }
            return DP[rowLength - 1, colLength - 1];
        }

        public int UniquePaths2(int m, int n)
        {
            int[,] DP = new int[m, n];
            DP[0, 0] = 1;

            for (int row = 0; row < m; row++)
                DP[row, 0] = 1;
            for (int col = 0; col < n; col++)
                DP[0, col] = 1;
            for(int i = 1; i < m; i++)
            {
                for(int j=1;j<n;j++)
                {
                    DP[i, j] = DP[i - 1, j] + DP[i, j - 1];
                }
            }
            return DP[m - 1, n - 1];
        }
    }
}