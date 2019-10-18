using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Strings
{
    class _1221
    {
        public static void Main(String[] args)
        {
            _1221 a = new _1221();
            string s = "RLRRLLRLRL";
            int result = a.BalancedStringSplit(s);
            List<int> list = new List<int>();
            String A = "kushal";
            char c = A[0];
            string f = c.ToString().ToLower();
            string result2 =  A.Substring(1, A.Length - 1);


        }
        public int BalancedStringSplit(string s)
        {
            if (s.Length == 0)
                return 0;
            Stack<char> stack = new Stack<char>();
            char[] ch = s.ToCharArray();
            int result = 0;
            foreach (char c in ch)
            {
                if (c == 'R' &&  stack.Count != 0 &&  stack.Peek() == 'L')
                {
                    stack.Pop();
                    if(stack.Count == 0)
                        result++;
                }
                else if (c == 'L' && stack.Count != 0 && stack.Peek() == 'R')
                {
                    stack.Pop();
                    if (stack.Count == 0)
                        result++;
                }
                else
                {
                    stack.Push(c);
                }
            }
            return result;
        }
    }
}
