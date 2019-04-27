using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _64_Minimum_Path_Sum
    {
        public static void Main(String[] args)
        {
            _64_Minimum_Path_Sum a = new _64_Minimum_Path_Sum();
            int[,] grid = new  int[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } };
            int result = a.MinPathSum(grid);
        }

        public int MinPathSum(int[,] grid)
        {
            //array to store the min sum path for i and j
            int[,] DP = new int[grid.GetLength(0), grid.GetLength(1)];

            //initialization
            DP[0, 0] = grid[0, 0];
            for (int k = 1; k < grid.GetLength(0); k++)
                DP[k, 0] = grid[k, 0] + DP[k - 1, 0];

            for (int k = 1; k < grid.GetLength(1); k++)
                DP[0, k] = grid[0, k] + DP[0, k - 1];

            for (int i = 1; i < grid.GetLength(0); i++)
            {
                for (int j = 1; j < grid.GetLength(1); j++)
                {
                    DP[i, j] = grid[i, j] + Math.Min(DP[i, j - 1], DP[i - 1, j]);
                }
            }
            return DP[DP.GetLength(0) - 1, DP.GetLength(1) - 1];
        }
        //Attempt 2: 

        public int MinPathSum2(int[,] grid)
        {

            return 0;
        }
    }
}
