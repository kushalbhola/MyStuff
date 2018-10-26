using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public static void Main(String[] args)
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array a = new _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array();
            int[] result = a.SearchRange(nums, target);
        }
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1, -1 };
            int leftIdx = find(nums, target, true);
            if (leftIdx == nums.Length || nums[leftIdx] != target)
            {
                return result;
            }

            result[0] = leftIdx;
            result[1] = find(nums, target, false)-1;
            return result;
        }
        private int find(int[] nums, int target, bool left)
        {
            int start = 0;
            int end = nums.Length;
            while (end > start)
            {
                int mid = (start + end) / 2;
                if (nums[mid] > target || (nums[mid] == target && left))
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}
