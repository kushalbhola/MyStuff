using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BinarySearchQuestions
{
    class _167_TwoSum_SortedArray
    {
        public static void Main(String[] args)
        {
            int[] nums = {-1,0 };
            int target = -1;
            int[] result = TwoSum(nums, target);
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            /*
            Algorithm:
            1. for every element in the array look for complement using binary search in the array , because the array is sorted
            */
            for(int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                int j = BinarySearch(numbers, complement);
                if (j != -1)
                {
                    if(i == j)
                    {
                        return new int[] { i + 1, j + 2 };
                    }
                    else 
                    {
                        return new int[] { i + 1, j + 1 };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
        public static int BinarySearch(int[] nums, int target )
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while(end >= start)
            {
                mid = start + (end - start) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }
                if(target > nums[mid])
                {
                    start = mid + 1;
                }
                if(target < nums[mid])
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
        public static int[] TwoSum2(int[] numbers, int target)
        {
            int first = 0;
            int last = numbers.Length - 1;
            while(last > first)
            {
                if(numbers[first] +numbers[last] == target)
                {
                    return new int[] { first + 1, last + 1 };
                }
                else if (numbers[first] + numbers[last] > target)
                {
                    last--;
                }
                else if (numbers[first] + numbers[last] < target)
                {
                    first++;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
