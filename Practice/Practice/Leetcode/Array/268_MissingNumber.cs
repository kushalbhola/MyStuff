using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _268_MissingNumber
    {
        public static void Main(string[] args)
        {
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            _268_MissingNumber a = new _268_MissingNumber();
            int result = a.MissingNumber(nums);
        }
        public int MissingNumber(int[] nums)
        {
            System.Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] == 2)
                    return nums[i] - 1;
            }
            return -1;
        }
    }
}
