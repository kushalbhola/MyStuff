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
            int[] nums = { 1, 3};
            int target = 1;
            int result = SearchInsert(nums, target);
            result = SearchInsert2(nums, target);
            int t = 15 / 2;
            result = SearchInsert3(nums, target);
        }
        public static int SearchInsert(int[] nums, int target)
        {
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

        //Attempt 2

        public static int SearchInsert2(int[] nums, int target)
        {

            if (nums.Length == 0)
                return 1;
            else if (nums.Length == 1)
            {
                if (nums[0] == target)
                    return 0;
                else if (nums[0] > target)
                    return 0;
                else if (nums[0] < target)
                    return 1;
            }
            else
            {
                int j = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[j] == target)
                        return j;
                    else if (nums[i] > target && nums[j] < target)
                    {
                        return i;
                    }
                    else if(nums[j] > target && nums[i] > target)
                    {
                        return j;
                    }
                    j++;
                }
            }
            if (nums[nums.Length - 1] == target)
                return nums.Length - 1;
            else
                return nums.Length ;
        }
        
        //Attempt 2
        public static int SearchInsert3 (int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length;
            while (end >= start)
            {
                int mid = start + (end-start)/2;
                if (nums[mid] == target)
                    return mid;
                if (target > nums[mid])
                    start = mid + 1;
                if (target < nums[mid])
                    end = mid - 1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
