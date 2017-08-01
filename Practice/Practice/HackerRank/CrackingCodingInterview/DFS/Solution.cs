using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.DFS
{
	class Solution
	{
		static void Main(String[] args)
		{
			int n = 4;
			int m = 4;
			int[,] grid = new int[,]
			{
			{1, 1, 0, 0 },
			{0, 1, 1, 0 },
			{0, 0, 1, 0 },
			{1, 0, 0, 0 },
			};

			Console.WriteLine(getBiggestregion(grid));
			//Console.WriteLine(grid.GetUpperBound(1));
			Console.ReadLine();
		}

		static int getBiggestregion(int[,] matrix)
		{
			int maxRegion = 0;
			for (int row = 0; row < matrix.GetUpperBound(0); row++)
			{
				for (int column = 0; column < matrix.GetUpperBound(1); column++)
				{
					int size = getRegionSize(matrix, row, column);
					maxRegion = Math.Max(size, maxRegion);
				}
			}
			return maxRegion;
		}

		static int getRegionSize(int[,] matrix, int row, int column)
		{
			if (row< 0 || column<0 || row > matrix.GetUpperBound(0) || column > matrix.GetUpperBound(1))
				return 0;
			if (matrix[row, column] == 0)
				return 0;
			matrix[row,column] = 0;
			int size = 1;
			for(int r = row - 1; r <= row + 1; r++)
			{
				for(int c = column - 1; c <= column + 1; c++)
				{
					if(r!=row || c != column)
					{
						size += getRegionSize(matrix, r, c);
					}
				}
			}
			return size;
		}
	}
}
