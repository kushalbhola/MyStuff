using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _303_Range_Sum_Query___Immutable
    {
        private int[] sum;
        public static void Main(String[] args)
        {
            int[] nums = { -2, 0, 3, -5, 2, -1 };
            _303_Range_Sum_Query___Immutable a = new _303_Range_Sum_Query___Immutable();
            a.NumArray(nums);
            int result1 = a.SumRange(2,5);
        }
        public void  NumArray(int[] nums)
        {
            int runningTotal = 0;
            sum = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                runningTotal = runningTotal + nums[i];
                sum[i] = runningTotal;
            }
        }
        public int SumRange(int i, int j)
        {
            return sum[j] - sum[i - 1];
        }
    }
}
