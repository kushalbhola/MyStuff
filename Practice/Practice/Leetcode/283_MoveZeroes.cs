using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _283_MoveZeroes
    {
        static void Main(String[] args)
        {
            int[] nums = {1,0};
            _283_MoveZeroes a = new _283_MoveZeroes();
            int[] result = a.MoveZeroes(nums);
        }
        public int[] MoveZeroes(int[] nums)
        {
            int slow = -1;
            int fast = 0;
            while (fast < nums.Length && nums.Length > 1)
            {
                if (nums[fast] == 0)
                {
                    fast++;
                }
                else
                {
                    slow++;
                    if (slow != fast)
                    {
                        nums[slow] = nums[fast];
                        nums[fast] = 0;
                    }
                    else
                        fast++;
                }
            }
            return nums;
        }
    }
}
