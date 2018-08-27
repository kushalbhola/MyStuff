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
            int[] nums = {-1,-1,-1,-1,-1,0 };
            _724_Find_Pivot_Index a = new _724_Find_Pivot_Index();
            int result = a.PivotIndex(nums);
        }

        public int PivotIndex(int[] nums)
        {
            if (nums.Length == 0) return -1;
            if (nums.Length == 1) return nums[0];
            int start = 0;
            int end = nums.Length - 1;
            int leftSum = nums[start];
            int rightSum = nums[end];
            while (end > start)
            {
                if (leftSum == rightSum && (end - start == 2))
                {
                    return start + 1;
                }
                else if (leftSum > rightSum)
                {
                    end--;
                    rightSum = rightSum + nums[end];
                }
                else if(leftSum < rightSum)
                {
                    start++;
                    leftSum = leftSum + nums[start];
                }
                else if(leftSum == rightSum)
                {
                    start++;
                    end--;
                    rightSum = rightSum + nums[end];
                    leftSum = leftSum + nums[start];
                }
            }
            return -1;
        }
        //public int PivotIndex(int[] nums)
        //{
        //    int start = 0;
        //    int end = nums.Length - 1;
        //    int mid = (start + end) / 2;
        //    int leftSum = sum(nums, start, end);
        //    int rightSum = sum(nums, start, end);
        //    while (end > start)
        //    {
        //        if (leftSum == rightSum)
        //            return mid;
        //        else if(leftSum > rightSum)
        //        {
        //            leftSum = sum(nums, start, start + mid / 2);
        //        }

        //    }
        //    return 0;
        //}
        //public int sum(int[] nums, int start, int end)
        //{
        //    int sum = 0;
        //    for (int i = start; i < end; i++)
        //        sum += nums[i];
        //    return sum;
        //}
    }
}
