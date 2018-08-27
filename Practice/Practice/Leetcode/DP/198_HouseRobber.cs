using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _198_HouseRobber
    {
        public static void Main(String[] args)
        {
            _198_HouseRobber a = new _198_HouseRobber();
            int[] nums = { 2, 1, 1, 2 };
            int result = a.Rob(nums);
        }
        public int Rob(int[] nums)
        {
            int[] DP = new int[nums.Length];
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];
            else
            {
                DP[0] = nums[0]; DP[1] = Math.Max(nums[0], nums[1]);
                for (int i = 2; i < DP.Length; i++)
                {
                    DP[i] = Math.Max(DP[i - 1], DP[i - 2] + nums[i]);
                }
            }

            return DP[DP.Length - 1];
        }
    }
}