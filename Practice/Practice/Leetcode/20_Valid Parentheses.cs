using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _20_Valid_Parentheses
    {
        static void Main(String[] args)
        {
            string input = "(])";
            bool result = IsValid(input);
            result = IsValid2(input);
        }
        public static bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                    st.Push(c);
                else if ((c == ')' || c == '}' || c == ']') && st.Count == 0)
                    return false;
                else if (c == ')' && st.Peek() == '(')
                    st.Pop();
                else if (c == '}' && st.Peek() == '{')
                    st.Pop();
                else if (c == ']' && st.Peek() == '[')
                    st.Pop();
                else
                    return false;
            }
            //check if stack is empty
            if (st.Count == 0)
                return true;
            else
                return false;
        }
        public static bool IsValid2(string s)
        {
            char[] ch = s.ToCharArray();
            Stack<char> st = new Stack<char>();
            foreach(char c in ch)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    st.Push(c);
                }
                else if ((c == ')' || c == '}' || c == ']') && st.Count == 0)
                    return false;
                else if (c == ')' && st.Peek() == '(')
                    st.Pop();
                else if (c == '}' && st.Peek() == '{')
                    st.Pop();
                else if (c == ']' && st.Peek() == '[')
                    st.Pop();
                return false;
            }
            if (st.Count == 0)
                return true;
            else
                return false;
        }
    }
}
