using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode
{
    class _704_BinarySearch
    {
        public static void Main(String[] args)
        {
            int[] input = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            int[] input2 = { 5 };
            int target2 = 5;
            _704_BinarySearch a = new _704_BinarySearch();
            int result = a.Search(input2, target2);
        }
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (nums[end] >= nums[start])
            {
                int mid = (start + end) / 2;
                if (target > nums[mid])
                    start = mid + 1;
                else if (target < nums[mid])
                    end = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
