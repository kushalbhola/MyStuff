using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _35_Flipping_Image
    {
        public static void Main(String[] args)
        {
            int[,] codes = new int[,]
            {
                { 1,1,0},
                { 1,0,1},
                { 0,0,0}
            };
            int[,] result = FlipAndInvertImage(codes);
        }
        public static int[,] FlipAndInvertImage(int[,] A)
        {
            for (int row = 0; row < A.GetLength(0); row++)
            {
                //flipping
                int start = 0;
                int end = A.GetLength(1)-1;
                while (end > start)
                {
                    int temp = A[row,start];
                    A[row,start] = A[row,end];
                    A[row,end] = temp;
                    start++;
                    end--;
                }
                //invert
                for (int i = 0; i < A.GetLength(1); i++)
                {
                    if (A[row,i] == 0)
                        A[row,i] = 1;
                    else
                        A[row,i] = 0;
                }
            }
            return A;
        }
    }
}
