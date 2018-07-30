using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _432_K_diff_Pairs_in_an_Array
    {
        static void Main(String[] args)
        {
            int[] nums = { 1,3,1,5,4 };
            _432_K_diff_Pairs_in_an_Array a = new _432_K_diff_Pairs_in_an_Array();
            int k = 0;
            int result = a.FindPairs(nums, k);
        }
        public int FindPairs(int[] nums, int k)
        {
            int left = 0;
            int right = 1;
            int count = 0;
            Array.Sort(nums);
            while (right < nums.Length)
            {
                if(nums[right] - nums[left]  < k)
                {
                    right++;
                }
                else if (nums[right] - nums[left] > k)
                {
                    left--;
                }
                else
                {
                    int first = nums[left];
                    count++;
                    while(first == nums[left])
                        left++;
                    right = left + 1;
                }
            }
            return count;
        }
        private bool BinarySearch(int[] nums, int k)
        {
            int start = 0;
            int end = nums.Length;

            while (end > start)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == k)
                {
                    return true;
                }
                else if (k < nums[mid])
                {
                    end = nums[mid - 1];
                }
                else
                {
                    start = nums[mid + 1];
                }
            }
            return false;
        }
    }
}
