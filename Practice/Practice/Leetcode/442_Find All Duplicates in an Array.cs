using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _442_Find_All_Duplicates_in_an_Array
    {
        public static void Main(String[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> result = FindDuplicates(nums);

        }
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            HashSet<int> hash = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!hash.Contains(nums[i]))
                    hash.Add(nums[i]);
                else
                    result.Add(nums[i]);
            }
            return result;
        }
    }
}

