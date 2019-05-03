using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Array
{
    class _153_FindMinimumInRotatedSortedArray
    {
        public static void Main(String[] args)
        {
            int[] nums = {2,3,4,5,1};
            _153_FindMinimumInRotatedSortedArray a = new _153_FindMinimumInRotatedSortedArray();
            int result = a.FindMin(nums);
        }
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2)
                return nums[0] > nums[1] ? nums[1] : nums[0];
            int start = 0;
            int end = nums.Length - 1;
            while(end > start)
            {
                int mid = (start + end) / 2;
                if (mid > 0 && nums[mid] < nums[mid - 1])
                    return nums[mid];
                if(nums[mid] >= nums[start] && nums[mid] > nums[end])
                {
                    //go right
                    start = mid + 1;
                }
                else
                {
                    //go left
                    end = mid - 1;
                }

            }
            return nums[start];
        }
    }
}
