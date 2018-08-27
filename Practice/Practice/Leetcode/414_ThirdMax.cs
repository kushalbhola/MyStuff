using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _414_ThirdMax
    {
        public static void Main(String[] args)
        {
            int[] nums = { 100, 211, 222, 8827 };
            _414_ThirdMax a = new _414_ThirdMax();
            int result = a.ThirdMax(nums);
        }
        public int ThirdMax(int[] nums)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            foreach (int n in nums)
            {
                if (!hash.ContainsKey(n))
                    hash[n] = 1;
                else
                    hash[n] += 1;
            }
            var ThirHighest = hash.Keys.OrderByDescending(o => o).Where(k=>k == 2).ToList();
            var Highest = hash.Keys.OrderByDescending(o => o).Where(k => k == 0).ToArray();


            return 3;

        }
    }
}
