using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _53_Maximum_Subarray
    {
        public static void Main(String[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            _53_Maximum_Subarray a = new _53_Maximum_Subarray();
            int result = a.MaxSubArray(nums);
        }
        public int MaxSubArray(int[] nums)
        {
            int[] DP = new int[nums.Length];
            DP[0] = nums[0];
            int max = DP[0];
            for (int i = 1; i < nums.Length; i++)
            {
                DP[i] = nums[i] + (DP[i - 1] > 0 ? DP[i - 1] : 0);
                max = Math.Max(DP[i], max);
            }
            return max;
        }
    }
}