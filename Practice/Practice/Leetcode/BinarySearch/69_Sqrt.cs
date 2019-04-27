using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.BinarySearch
{
    class _69_Sqrt
    {
        public static void Main(string[] args)
        {
            _69_Sqrt a = new _69_Sqrt();
            int result = a.sqrt(8);
        }
        public int sqrt(int x)
        {
            if (x == 0)
                return 0;
            int left = 1, right = x;
            int ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= x / mid)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                    right = mid - 1;
            }
            return ans;
        }
    }
}
