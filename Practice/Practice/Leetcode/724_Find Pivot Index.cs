using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _724_Find_Pivot_Index
    {
        public static void Main(String[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            _724_Find_Pivot_Index a = new _724_Find_Pivot_Index();
        }
        public int PivotIndex(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = (start + end) / 2;
            int leftSum = sum(nums, start, end);
            int rightSum = sum(nums, start, end);
            while (end > start)
            {
                if (leftSum == rightSum)
                    return mid;
                else if(leftSum > rightSum)
                {
                    leftSum = sum(nums, start, start + mid / 2);
                }
          
            }
            return 0;
        }
        public int sum(int[] nums, int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
                sum += nums[i];
            return sum;
        }
    }
}
