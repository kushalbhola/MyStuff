using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BinarySearchQuestions
{
    class _350_Intersection_2_Array
    {
        public static void Main(String[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            _350_Intersection_2_Array a = new _350_Intersection_2_Array();
            int[] output = intersect(nums1, nums2);
        }
        public static int[] intersect(int[] A, int[] B)
        {
            if (A.Length == 0 || B.Length == 0) return new int[0];
            if (A.Length > B.Length) return intersect(B, A);  // apply bs on bigger array
            List<int> list = new List<int>();
            System.Array.Sort(A);
            System.Array.Sort(B);

            int lowerBound = 0;  // lower bound for binary search
            for (int i = 0; i < A.Length; i++)
            {
                int index = binarySearch(B, lowerBound, A[i]);
                int v = 1 / 2;
                //int index = binarySearch2(B, lowerBound, A[i]);
                if (index < B.Length && B[index] == A[i])
                {  // found on B
                    list.Add(A[i]);
                    lowerBound = index + 1;
                }
            }

            // adding result from list to final int[]
            int[] res = new int[list.Count];
            int x = 0;
            foreach (int n in list)
                res[x++] = n;
            return list.ToArray(); 
        }

        private static int binarySearch(int[] A, int lo, int target)
        {
            int L = lo, R = A.Length - 1;
            while (L < R)
            {
                int M = L + (R - L) / 2;
                if (A[M] < target)
                    L = M + 1;
                else
                    R = M;
            }
            return L;
        }
        private static int binarySearch2(int[] A, int lo, int target)
        {
            int end = A.Length;
            while(end > lo)
            {
                int mid = lo + (lo + end) / 2;
                if (A[mid] == target)
                {
                    lo = mid;
                    return lo;
                }
                    
                if (target > A[mid])
                    end = mid + 1;
                if (target < A[mid])
                    lo = mid - 1;
            }
            return lo;
        }
    }
}
