using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _33_Search_in_Rotated_Sorted_Array
    {
        public static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            _33_Search_in_Rotated_Sorted_Array a = new _33_Search_in_Rotated_Sorted_Array();
            int result = a.Search(nums, 0);
            result = a.Search2(nums, 0);
        }
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int point = 0;
            while (end > start && point == 0)
            {
                int mid = (start + end) / 2;
                if (nums[mid] < nums[mid - 1] && nums[mid] < nums[mid + 1])
                    point = mid;
                if (nums[mid] < nums[0])
                {
                    end = mid - 1;
                    start = 0;
                }

                else
                {
                    start = mid + 1;
                    end = nums.Length - 1;
                }
                    
            }
            int attempt1 = SearchHelper(nums, 0, point - 1, target);
            int attempt2 = SearchHelper(nums, point, nums.Length-1, target);
            return attempt1 != -1 ? attempt1 : attempt2;

        }
        public int SearchHelper(int[] nums, int start, int end, int target)
        {
            while (end >= start)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    start = mid + 1;
                if (nums[mid] > target)
                    end = mid - 1;
            }
            return -1;
        }

        //Attempt 2:
        //Find inflextion point
        public int Search2(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int point = -1;
            while(end > start && point == -1)
            {
                int mid = (start + end) / 2;
                //7,1,2,3,4,5,6
                // 4, 5, 6, 7, 0, 1, 2 
                if (nums[mid] < nums[mid-1] && nums[mid] < nums[mid+1])
                {
                    point = mid;
                }
                if(nums[mid] < nums[0])
                {
                    start = 0;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                    end = nums.Length - 1;
                }
            }
            int part1 = BinarySearch2(nums, target, 0, point - 1);
            int part2 = BinarySearch2(nums, target, point, nums.Length - 1);
            return part1 != -1 ? part1 : part2;
        }
        public int BinarySearch2(int[] nums, int target, int start, int end)
        {
            while(end>=start)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    end = mid - 1;
                else if (nums[mid] < target)
                    start = mid + 1;
            }
            return -1;
        }
    }



}
