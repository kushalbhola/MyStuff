using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _1_TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }
            for (int j = 0; j <= nums.Length - 1; j++)
            {
                int complement = target - nums[j];
                if (dict.ContainsKey(complement) && dict[complement] != j)
                    return new int[] { dict[complement], j };
                //return new int[] {-1, -1};
            }
            return new int[] { -1, -1 };
        }
    }
}
