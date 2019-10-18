using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.SlidingWindow
{
    class _1004_MaxConsecutiveOnes
    {
        public static void Main(String[] args)
        {
            int[] input = { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            int k = 2;
            _1004_MaxConsecutiveOnes a = new _1004_MaxConsecutiveOnes();
            int result = a.LongestOnes(input, k);
        }
        public int LongestOnes(int[] A, int K)
        {
            int start = 0;
            int end = 0;
            int maxLength = -10000;
            while(end < A.Length)
            {
                if(A[end] == 0)
                {
                    K--;
                }
                while(K<0 && start <=end)
                {
    
                    start++;
                }
                    end++;
                    maxLength = Math.Max(maxLength, end - start);
            }
            return maxLength;
        }
    }
}
