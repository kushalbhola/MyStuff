using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Pramp
{
    class SentenceReverse
    {
        public static void Main(String[] args)
        {
            char[] arr = { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' };
            arr = ReverseWords(arr);
        }
        public static char[] ReverseWords(char[] arr)
        {
            // your code goes here
            string newArr = Reverse(arr, 0, arr.Length - 1);
            int start = 0;
            int end = arr.Length - 1;
            string finalResult = "";
            for (int i = 0; i < newArr.Length; i++)
            {
                if(newArr[i] == ' ')
                {
                    end = i;
                    string tempStr = Reverse(newArr.ToCharArray(), start, end-1);
                    start = end;
                    finalResult += tempStr;
                }
            }
            return finalResult.ToCharArray();
        }
        public static string Reverse(char[] arr, int start, int end)
        {
            while (end > start)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            string output = new string(arr);
            return output;
        }
    }
}
