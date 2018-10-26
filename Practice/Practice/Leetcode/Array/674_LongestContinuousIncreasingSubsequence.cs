﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _674_LongestContinuousIncreasingSubsequence
    {
        public static void Main(String[] args)
        {
            int[] nums = { 1, 3, 5, 4, 7 };
            int result = lengthOfLIS(nums);
        }
        public static int lengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            dp[0] = 1;
            int maxans = 1;
            for (int i = 1; i < dp.Length; i++)
            {
                int maxval = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        maxval = Math.Max(maxval, dp[j]);
                    }
                }
                dp[i] = maxval + 1;
                maxans = Math.Max(maxans, dp[i]);
            }
            return maxans;
        }
    }
}
