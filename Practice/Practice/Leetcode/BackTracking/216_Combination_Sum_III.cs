﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempProject.BackTracking
{
    class _216_Combination_Sum_III
    {
        public static void Main(string[] args)
        {
            //List<List<int>> result = CombinationSum3(3, 9);
            int[] nums = { 2, 3, 6, 7 };
            int target = 8;
            //List<List<int>> result = combinationSum(nums, target);


            int[] nums2 = { 10, 1, 2, 7, 6, 1, 5 };
            int target2 = 8;
            //List<List<int>> result = combinationSum2(nums2, target2);
            int[] nums3 = { 1, 2, 3 };

            //List<List<int>> result = subset(nums3);

            int[] nums4 = { 1, 2, 3 };
            //List<List<int>> result = permute(nums3);

            List<List<int>> result = CombinationSum3(3, 9);
        }
        public static List<List<int>> permute(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> list = new List<List<int>>();
            permuteHelper(nums, list, new List<int>(), 0);
            return list;
        }
        public static void permuteHelper(int[] nums, List<List<int>> list, List<int> tempList, int start)
        {
            if (tempList.Count == nums.Length)
                list.Add(tempList);
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                permuteHelper(nums, list, tempList, i + 1);
                tempList.RemoveAt(tempList.Count - 1);

            }
        }

        public static List<List<int>> subset(int[] nums)
        {
            List<List<int>> list = new List<List<int>>();
            Array.Sort(nums);
            subsethelper(list, new List<int>(), nums, 0);
            return list;
        }
        public static void subsethelper(List<List<int>> list, List<int> tempList, int[] nums, int start)
        {
            if (tempList.Count != 0)
                list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                subsethelper(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
        public static List<List<int>> combinationSum(int[] nums, int target)
        {
            List<List<int>> list = new List<List<int>>();
            Array.Sort(nums);
            combinationSumHelper(list, new List<int>(), nums, target, 0);
            return list;

        }
        public static void combinationSumHelper(List<List<int>> list, List<int> tempList, int[] nums, int remain, int start)
        {
            if (remain < 0)
                return;
            else if (remain == 0) list.Add(new List<int>(tempList));
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    tempList.Add(nums[i]);
                    combinationSumHelper(list, tempList, nums, remain - nums[i], start);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
        public static List<List<int>> combinationSum2(int[] nums, int target)
        {
            List<List<int>> list = new List<List<int>>();
            Array.Sort(nums);
            combinationSum2Helper(list, new List<int>(), nums, target, 0);
            return list;

        }
        public static void combinationSum2Helper(List<List<int>> list, List<int> tempList, int[] nums, int remain, int start)
        {
            if (remain < 0)
                return;
            else if (remain == 0) list.Add(new List<int>(tempList));
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    if (i > start && nums[i] == nums[i - 1])
                        continue;
                    tempList.Add(nums[i]);
                    combinationSum2Helper(list, tempList, nums, remain - nums[i], i + 1);
                    tempList.RemoveAt(tempList.Count - 1);

                }
            }
        }
        public static List<List<int>> CombinationSum3(int k, int target)
        {
            int[] nums = Enumerable.Range(1, 9).ToArray();
            List<List<int>> list = new List<List<int>>();
            Array.Sort(nums);
            CombinationSum3Helper(list, new List<int>(), nums, target, 0, k);
            return list;

        }
        public static void CombinationSum3Helper(List<List<int>> list, List<int> tempList, int[] nums, int remain, int start, int k)
        {
            if (remain < 0)
                return;
            if (tempList.Count > k)
                return;
            else if (remain == 0 && tempList.Count == k)
                list.Add(new List<int>(tempList));
            else
            {
                for (int i = start; i < nums.Length; i++)
                {
                    tempList.Add(nums[i]);
                    CombinationSum3Helper(list, tempList, nums, remain - nums[i], i + 1, k);
                    tempList.RemoveAt(tempList.Count - 1);

                }
            }
        }

        //public static List<List<int>> CombinationSum3(int k, int n)
        //{
        //    int[] nums = Enumerable.Range(1, 9).ToArray();
        //    List<List<int>> result = new List<List<int>>();
        //    CombinationSum3Helper(nums, result, new List<int>(), k, n, 0);
        //    return result;
        //}
        //public static  void CombinationSum3Helper(int[] nums, List<List<int>> result, List<int> list, int k, int target, int start)
        //{
        //    if (k == 0 && target == 0)
        //        result.Add(list);
        //    else
        //    {
        //        for(int i=start;i<nums.Length && k>0 && target > 0; i++)
        //        {
        //            list.Add(nums[i]);
        //            CombinationSum3Helper(nums, result, list, k - 1, target - nums[i], start + 1);
        //            list.RemoveAt(list.Count - 1);
        //        }
        //    }
        //}
    }
}
