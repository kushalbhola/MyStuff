using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _485_Max_Consecutive_Ones
    {
        public static void Main(String[] args)
        {
            _485_Max_Consecutive_Ones a = new _485_Max_Consecutive_Ones();
            int[] nums = { 1 };
            int result = a.FindMaxConsecutiveOnes(nums);
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            if (nums.Length == 0) return 0;
            else
            {
                int OnesSoFar = 0;
                if (nums[0] == 1)
                    OnesSoFar = 1;
                int maxOnes = OnesSoFar;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == 1 )
                    {
                        OnesSoFar++;
                        if (OnesSoFar > maxOnes)
                            maxOnes = OnesSoFar;
                    }
                    else
                        OnesSoFar = 0;
                }
                return maxOnes;
            }

        }
    }
}
