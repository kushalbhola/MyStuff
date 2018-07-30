using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _238_Product_of_Array_Except_Self
    {
        public static void Main(String[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            _238_Product_of_Array_Except_Self a = new _238_Product_of_Array_Except_Self();
            int[] output = a.ProductExceptSelf(nums);
        }
        private int[] ProductExceptSelf(int[] nums)
        {
            int left = 1;
            int right = 1;
            int[] output = new int[nums.Length];
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                output[i] = right;
                right *= nums[i];
            }
            for(int j = 0; j < nums.Length; j++)
            {
                output[j] *= left;
                left *= nums[j];
            }
            return output;
        }

    }
}
