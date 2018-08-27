using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.ProgrammingInterviewExposed.ArraysAndStrings
{
    class SpiralMatrix
    {
        public static void Main(String[] args)
        {
            //int[,] inputMatrix = new int[,] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11,12,13,14, 15 }, {16,17,18,19,20} };
            int[,] inputMatrix = new int[,] { { 1}, { 2 } };
            int[] result = SpiralCopy(inputMatrix);
        }
        public static int[] SpiralCopy(int[,] inputMatrix)
        {
            List<int> list = new List<int>();

            int rowTop = 0;
            int rowBottom = inputMatrix.GetLength(0)-1;

            int colLeft = 0;
            int colRight = inputMatrix.GetLength(1)-1;
            while (rowBottom > rowTop && colRight > colLeft)
            {
                for (int i = colLeft; i <= colRight; i++)
                {
                    list.Add(inputMatrix[rowTop, i]);
                }
                rowTop++;
                for (int r = rowTop; r <= rowBottom; r++)
                {
                    list.Add(inputMatrix[r,colRight]);
                }
                colRight--;
                for (int k = colRight; k >= colLeft; k--)
                {
                    list.Add(inputMatrix[rowBottom, k]);
                }
                rowBottom--;
                for (int j = rowBottom; j >= rowTop; j--)
                {
                    list.Add(inputMatrix[j, colLeft]);
                }
                colLeft++;
            }
            return list.ToArray();
        }
    }
}
