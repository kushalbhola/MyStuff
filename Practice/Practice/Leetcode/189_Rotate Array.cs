using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _189_Rotate_Array
    {
        public static void Main(String[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 1;
            int[] result = Rotate(nums, k);
        }
        public static int[] Rotate(int[] nums, int k)
        {
            int[] newArr = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                newArr[(i + k) % nums.Length] = nums[i];
            }
            nums = newArr;
            return newArr;
        }
    }
}
