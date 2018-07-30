using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _33_Search_in_Rotated_Sorted_Array
    {
        public static void Main(String[] args)
        {
            int[] nums = { 5,6,7,8,9,11, 1, 2, 3, 4};
            //concatenate these 2 arrays together. 
            //string[] n1 = ConvertIntToStringArray(nums);
            //string[] concatenatedArray = getConcatenatedArray(n1, n1);
            int result = search(nums, 3);

            // Now find the location where the array deviates from ascending order. It should happen twice. If you remove everything before and after this point you should get sorted array

        }
        
            private static int search(int[] A, int target)
        {
            int lo = 0;
            int hi = A.Length - 1;
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if(A[lo] < A[mid])
                {
                    if (target < A[mid] && target > A[lo])
                        hi = mid - 1;
                    else
                        lo = mid + 1;
                }
                else
                {
                    if (target > A[mid] && target < A[hi])
                        lo = mid + 1; 
                    else
                        hi = mid - 1;
                }
            }
            return A[lo] == target ? lo : -1;
        }
        //private static string[] getConcatenatedArray(string[] s1, string[] s2)
        //{
        //    string[] concatenatedArray = new string[s1.Length + s2.Length];
        //    for(int i = 0; i < s1.Length; i++)
        //    {
        //        concatenatedArray[i] = s1[i];
        //    }
        //    for (int j = 0; j < s2.Length; j++)
        //    {
        //        concatenatedArray[j + s1.Length] = s2[j];
        //    }
        //    return concatenatedArray;
        //}
        //private static string[] ConvertIntToStringArray(int[] n )
        //{
        //    string[] s = new string[n.Length];
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        s[i] = n[i].ToString();
        //    }
        //    return s;
        //}
    }
}
