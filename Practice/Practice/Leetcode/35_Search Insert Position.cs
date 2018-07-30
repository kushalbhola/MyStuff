using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _35_Search_Insert_Position
    {
        public static void Main(String[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 0;
            int result = SearchInsert(nums, target);
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int[] DP = new int[target];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] < target && i + 1 < nums.Length  && target < nums[i + 1])
                {
                    return i + 1;
                }
            }
            return nums.Length;
        }
    }
}
