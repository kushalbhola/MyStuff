using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _229_Majority_Element_II
    {
        public static void Main(String[] args)
        {
            int[] arr = { 1, 1, 1, 3, 3, 2, 2, 2 };
            List<int> result = majorityElement(arr);
        }
        public static List<int> majorityElement(int[] nums)
        {
            //construct hashmap
            Dictionary<int, int> hash = new Dictionary<int, int>();
            foreach (int x in nums)
            {
                if (hash.ContainsKey(x))
                    hash[x] += 1;
                else
                    hash[x] = 1;
            }
            List<int> returnList = new List<int>();
            foreach (int x in hash.Keys)
            {
                if (hash[x] > nums.Length / 3)
                    returnList.Add(x);
            }
            return returnList;
        }
    }
}
