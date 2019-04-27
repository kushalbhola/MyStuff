using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _26_RemoveDuplicatesFromSortedArray
    {
        public static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            _26_RemoveDuplicatesFromSortedArray a = new _26_RemoveDuplicatesFromSortedArray();
            int result = a.RemoveDuplicates(nums);
        }
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;

            //    if (nums.Length == 0) return 0;
            //    if (nums.Length == 1) return 1;
            //    int slow = 0;
            //    int fast = slow + 1;
            //    while(fast < nums.Length)
            //    {
            //        while (nums[slow] == nums[fast])
            //            fast++;
            //            //readjust array
            //    }
            //}
            //public int[] Readjust(int[] nums, int slow, int fast)
            //{
            //    while()
        }
    }
}
