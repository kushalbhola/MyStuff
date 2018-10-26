using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _670_Maximum_Swap
    {
        public static void Main(String[] args)
        {
            int num = 2736;
            _670_Maximum_Swap a = new _670_Maximum_Swap();
            int result = a.MaximumSwap(num);
        }
        public int MaximumSwap(int num)
        {
            string temp = num.ToString();   //Convert to int array (num -> digits[])
            int[] digits = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                digits[i] = temp[i] - '0';
            }                                       //Ignore all digits until decreasing, until (next digit > prev). store the min and minindex
            int min = digits[0], minIndex = 0;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i + 1] > digits[i])
                {
                    minIndex = i;
                    min = digits[i];
                    break;
                }
                else if (i == digits.Length - 2)  //Reached end. Nothing to swap. Return original number.           
                    return num;
            }                                       //Starting from minindex find the largest digit in the remaining digits.
            int max = min, maxIndex = -1;
            for (int j = minIndex; j < digits.Length; j++)
            {
                if (digits[j] >= max)
                {
                    max = digits[j];
                    maxIndex = j;
                }
            }                                       //Iterate through the array till minIndex to find any digit that might be lesser than max 
            int result = 0, swapindex = minIndex;
            for (int i = 0; i <= minIndex; i++)
            {
                if (digits[i] < max)
                {
                    swapindex = i;
                    break;
                }
            }                                       //Swap the maxIndex digit with swapIndex
            int tmp = digits[swapindex];
            digits[swapindex] = digits[maxIndex];
            digits[maxIndex] = tmp;
            //Convert the result into integer(digits -> result) 
            for (int i = digits.Length - 1, j = 0; i >= 0; i--)
            {
                result = result + (digits[j] * ((int)Math.Pow(10, i)));
                j++;
            }
            return result;
        }
    }
}
