using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    
    class _1_TwoSums
    {
        public static void Main(String[] args)
        {
            _1_TwoSums a = new _1_TwoSums();
            int[] nums = { 2, 7, 11, 15 };
            int[] result = a.TwoSum(nums, 9);
        }
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
                    return new int[] {  j, dict[complement] };
                //return new int[] {-1, -1};
            }
            return new int[] { -1, -1 };
        }
        //public int[] TwoSum2(int[] nums, int target)
        //{
        //    System.Array.Sort(nums);
        //    int start = 0;
        //    int end = nums.Length - 1;
        //    if (nums.Length == 0) return null;
        //    if
        //}
    }
}
