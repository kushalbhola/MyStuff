using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Array
{
    class _168_Excel_Sheet_Column_Title
    {
        public static void Main(String[] args)
        {
            int n = 701;
            _168_Excel_Sheet_Column_Title a = new _168_Excel_Sheet_Column_Title();
            string result = a.ConvertToTitle(n);
        }
        public string ConvertToTitle(int n)
        {
            string res = "";
            while (n != 0)
            {
                char ch = (char)((n - 1) % 26 + 65);
                n = (n - 1) / 26;
                res = ch + res;
            }
            return res;
        }
    }
}
