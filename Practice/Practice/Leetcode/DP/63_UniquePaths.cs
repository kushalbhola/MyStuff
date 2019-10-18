using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.DP
{
    class _63_UniquePaths
    {
        public static void Main(String[] args)
        {
            int[,] grid =
            {
                {0,0,0 },
                {0,1,0 },
                {0,0,0 },
                {0,0,0 }
            };
            int[][] obstacleGrid = new int[3][];
            obstacleGrid[0] = new int[] { 0, 0, 0 };
            obstacleGrid[1] = new int[] { 0, 1, 0 };
            obstacleGrid[2] = new int[] { 0, 0, 0 };
            _63_UniquePaths a = new _63_UniquePaths();

            int[][] grid2 = new int[2][];
            grid2[0] = new int[] { 0 };
            grid2[1] = new int[] { 0 };

            int[][] grid3 = new int[1][];
            grid3[0] = new int[] { 1, 0 };

            int[][] grid4 = new int[3][];
            grid4[0] = new int[] { 0, 0 };
            grid4[1] = new int[] { 1,1 };
            grid4[2] = new int[] { 0, 0 };


            int result = a.UniquePathsWithObstacles(grid4);
        }
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int[][] DP = new int[obstacleGrid.GetLength(0)][];

            //create array DP
            int colLenth = 0;
            for(int i = 0; i < obstacleGrid.GetLength(0); i++)
            {
                DP[i] = new int[obstacleGrid[i].Length];
                colLenth = i;
            }
            //initialize
            obstacleGrid[0][0] = obstacleGrid[0][0] == 0 ? 1 : 0;
            //fill top row
            for (int i=1;i<obstacleGrid[0].Length;i++)
            {
                if (obstacleGrid[0][i] == 0 && obstacleGrid[0][i-1] != 1)
                    DP[0][i] = 1;
                else
                    DP[0][i] = 0;
            }
            for(int j = 1; j < obstacleGrid.GetLength(0); j++)
            {
                var test = obstacleGrid[j][0];
                if (obstacleGrid[j][0] == 0 && obstacleGrid[j-1][0] != 1)
                    DP[j][0] = 1;
                else
                    DP[j][0] = 0;
            }

            for(int i = 1; i < obstacleGrid.GetLength(0); i++)
            {
                for(int j = 1; j < obstacleGrid[i].Length; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                        DP[i][j] = 0;
                    else
                        DP[i][j] = DP[i - 1][j] + DP[i][j - 1];
                }
            }
            
            var rowLen = DP.GetLength(0);
            var colLen = DP[DP.GetLength(0)-1].Length;
            //return obstacleGrid[rowLen - 1][colLen - 1] == 1 ? 0 : DP[rowLen - 1][colLen - 1];
            return DP[rowLen - 1][colLen - 1]; 
        }
    }


}
