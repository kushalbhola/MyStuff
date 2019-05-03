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
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            _442_Find_All_Duplicates_in_an_Array a = new _442_Find_All_Duplicates_in_an_Array();
            IList<int> result = a.FindDuplicates2(nums1);

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
        public IList<int> FindDuplicates2(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> result = new List<int>();
            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                    dict[i] = dict[i] + 1;
                else
                    dict.Add(i, 1);
            }
            foreach (var x in dict)
            {
                if (x.Value > 1)
                    result.Add(x.Key);
            }
            return result.OrderBy(a=>a).ToList();
        }
    }
}

