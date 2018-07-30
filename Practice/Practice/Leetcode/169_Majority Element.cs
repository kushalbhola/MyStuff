using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _169_Majority_Element
    {
        public static void Main(String[] args)
        {
            int[] arr = { 2, 2, 1, 1, 1, 2, 2 };
            int result = majorityElement(arr);
        }
        public static int majorityElement(int[] nums)
        {
            //construct hashmap
            Dictionary<int, int> hash = new Dictionary<int, int>();
            foreach(int x in nums)
            {
                if (hash.ContainsKey(x))
                    hash[x] += 1;
                else
                    hash[x] = 1;
            }
            foreach(int x in hash.Keys)
            {
                if (hash[x] > nums.Length / 2)
                    return x;
            }
            return 0;
        }
    }
}
