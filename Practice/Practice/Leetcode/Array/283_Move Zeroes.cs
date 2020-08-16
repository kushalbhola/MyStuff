using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _283_Move_Zeroes
    {
        public static void Main(String[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
        }
        public static void MoveZeroes(int[] nums)
        {
            /*
            Algorithm:
            1. 2 pointers slow and fast
            2. slow = 0; fast = slow +1;
            3. if fast == 0 then fast ++
            4. if slow != 0 slow++
            5. if slow == 0 && fast != 0 then swap slow and fast
            */
            if (nums.Length == 0 || nums.Length == 1) return;
            int slow = 0;
            int fast = slow + 1;
            while (fast < nums.Length)
            {
                while (slow < nums.Length - 1 && nums[slow] != 0)
                {
                    slow++;
                    fast = slow + 1;
                }
                while (fast < nums.Length-1 && nums[fast] == 0  )
                    fast++;
                //swap 
                if(slow <nums.Length && fast < nums.Length)
                {
                    nums[slow] = nums[fast];
                    nums[fast] = 0;
                }
                


            }
        }
    }
}
