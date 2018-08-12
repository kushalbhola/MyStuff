using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Question: https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
namespace Practice.Leetcode
{
    class _448_Find_All_Numbers_Disappeared_in_an_Array
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            //Create a hashmap 
            int count = nums.Length;
            List<int> result = new List<int>();
            Dictionary<int, int> hash = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                if (!hash.ContainsKey(n))
                    hash[n] = 1;
                else
                    hash[n] += 1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.ContainsKey(i + 1))
                    result.Add(i + 1);
            }
            return result;
        }
    }
}
