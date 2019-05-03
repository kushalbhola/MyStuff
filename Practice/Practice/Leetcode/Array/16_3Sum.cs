using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _16_3Sum
    {
        public static void Main(string[] args)
        {
            _16_3Sum a = new _16_3Sum();
            int[] nums = { 1, 1, -1, -1, 3 };
            int result = a.ThreeSumClosest(nums, 1);
        }
        public int ThreeSumClosest(int[] nums, int target)
        {

            /*
            a + b + c = target

            b + c = target - a
            */

            System.Array.Sort(nums);
            int globalDiff = 100000;
            int result = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //int newTarget = target - nums[i];
                int start = i + 1;
                int end = nums.Length - 1;
                while (end > start)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (sum > target)
                        end--;
                    else
                        start++;
                    int currDiff = Math.Abs(target - sum);
                    if (currDiff < globalDiff)
                    {
                        globalDiff = currDiff;
                        result = sum;
                    }


                }
            }
            return result;
        }

        public int ThreeSumClosest2(int[] nums, int target)
        {
            //Sort the array
            //[-1, 2, 1, -4] target: 1
            System.Array.Sort(nums);

            for (int i = 0;i< nums.Length;i++)
            {
                int first = nums[i];
                int targetToLookFor = target - first;
                int start = i + 1;
                int last = nums.Length - 1;
                int globalMin = 10000;
                while (last > start)
                {
                    int currDiff = nums[first] + nums[last] - targetToLookFor;
                    if (globalMin > currDiff)
                        globalMin = currDiff;
                    else
                    {

                    }


                }
            }
            return 0;
        }

    }
}
