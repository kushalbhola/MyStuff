//https://leetcode.com/problems/4sum/description/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _18_4Sum
    {
        public static void Main(String[] args)
        {
            int[] nums = {-1,0,-5,-2,-2, -4,0,1,-2};
            int target = -9;
            List<List<int>> result = fourSum(nums, target);
        }
        public static List<List<int>>  fourSum(int[] nums, int target)
        {
            List<List<int>> ans = new List<List<int>>();
            if (nums.Length < 4) return ans;
            Array.Sort(nums);
            
            for(int i = 0; i < nums.Length - 3; i++)
            {
                //first value is too small
                if (nums[i] + nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3] < target) continue;
                //first value is too large
                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) break;

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    //second value is too large
                    if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target) break;
                    //second value is very small
                    if (nums[i] + nums[j] + nums[nums.Length - 1] + nums[nums.Length - 2] < target) continue;

                    int low = j + 1;
                    int high = nums.Length - 1;
                    while(high > low)
                    {
                        int sum = nums[i] + nums[j] + nums[low] + nums[high];
                        if (sum == target)
                        {
                            List<int> temp = new List<int>();
                            temp.Add(nums[i]); temp.Add(nums[j]); temp.Add(nums[low]); temp.Add(nums[high]);
                            while (low < high && nums[low] == nums[low + 1]) low++;
                            while (low < high && nums[high] == nums[high - 1]) high--;

                            ans.Add(temp);
                            low++;
                            high--;
                        }
                        //move the window
                        else if (sum < target) low++;
                        else high--;
                    }
                }
            }
            return ans;
        }
    }
}
