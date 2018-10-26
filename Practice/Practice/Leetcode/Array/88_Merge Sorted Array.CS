using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _88_Merge_Sorted_Array
    {
        public static void Main(String[] args)
        {
            _88_Merge_Sorted_Array A = new _88_Merge_Sorted_Array();
            int[] nums1 = { 2,0};
            int[] nums2 = { 1 };
            A.Merge(nums1, 1, nums2, 1);
        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while(m>0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else if (nums1[m - 1] <= nums2[n - 1])
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }
        }
        public int[] swap(int[] nums1, int start, int val)
        {
            for (int i = start; i < nums1.Length - 1; i++)
            {
                int temp = nums1[start];
                nums1[start] = val;
                val = nums1[start + 1];
            }
            return nums1;
        }
    }
}
