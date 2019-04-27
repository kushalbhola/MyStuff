using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _28_strStr
    {
        public static void Main(string[] args)
        {
            _28_strStr a = new _28_strStr();
            IList<string> result = a.FizzBuzz(3);
            Console.WriteLine(Int32.MinValue);
            string result2 = a.FizzBuzz2(5);

        }
        public IList<string> FizzBuzz(int n)
        {
            IList<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string temp = "";
                if (i % 3 == 0)
                {
                    temp = "Fizz";
                }
                if (i % 5 == 0)
                {
                    temp = temp + "Buzz";
                }
                else
                {
                    temp = i.ToString();
                }
                list.Add(temp);
            }
            return list;
        }
        public string FizzBuzz2(int x)
        {
            string result = "";
            for (int i = 1; i <= x; i++)
            {
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                else
                {
                    result += i.ToString();
                }
            }
            return result;
        }
    }
}
