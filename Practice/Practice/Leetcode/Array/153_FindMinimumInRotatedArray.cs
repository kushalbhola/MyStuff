using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _153_FindMinimumInRotatedArray
    {
        public static void Main(String[] args)
        {
            _153_FindMinimumInRotatedArray a = new _153_FindMinimumInRotatedArray();
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int result = a.FindMin(nums);
        }
        public int FindMin(int[] nums)
        {
            //if (nums.Length == 0) return 0;
            //if (nums.Length == 1) return nums[0];
            //if (nums.Length == 2) return nums[0] > nums[1] ? nums[1] : nums[0];
            //int currMin = Int32.MaxValue;
            //for(int i = 1; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] < currMin)
            //        currMin = nums[i];
            //}
            //return currMin;
            bool isRotated = false;

            if (nums[nums.Length - 1] < nums[0])
                isRotated = true;
            if (isRotated)
            {
                int start = 0;
                int end = nums.Length - 1;
                int mid = 0;
                while (end >= start)
                {
                    mid = (start + end) / 2;
                    if(nums[mid] > nums[start])
                    {
                        start = mid + 1;
                    }
                    else if(nums[mid] < nums[start])
                    {
                        end = mid - 1;
                    }
                }
                return nums[mid];
            }
            else
                return nums[0];
        }
    }
}
