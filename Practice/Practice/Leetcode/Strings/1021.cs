using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Practice.Leetcode.Strings
{
    class _1021
    {
        public static void Main(String[] args)
        {
            string h = "A man, a plan, a canal: Panama";

            //average word length
            h = h.ToLower();
            Regex rgx2 = new Regex("[^a-zA-Z0-9]");
            //h = rgx2.Replace(h, "");
            string[] words = h.Split(' ');
            int p = 0;
            foreach(string w in words)
            {
                p = p + w.Length;
            }
            int averageWordLength = p / words.Length;


            Regex rgx = new Regex("[^a-zA-Z0-9]");
            string n = rgx.Replace(h.ToLower().Replace(" ", ""), "");
            _1021 a = new _1021();
            string input = "(()())(())";
            string output = a.RemoveOuterParentheses(input);

        }
        public string RemoveOuterParentheses(string S)
        {
            char[] ch = S.ToCharArray();
            Stack<char> stack = new Stack<char>();
            int x = 0;
            /*
            (()())(())
            element: )
            stack:  
            i = 5
            x = 0
            */
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(' && stack.Count > 0 && stack.Peek() != ')')
                {
                    stack.Push(ch[i]);
                    x++;
                }

                else if (ch[i] == ')' && stack.Count > 0 &&  stack.Peek() == '(')
                {
                    stack.Pop();
                    if (x != 0)
                        x--;
                }
                else if (stack.Count == 0)
                {
                    string temp = S.Substring(x, i);
                }
            }
            return null;
        }
    }
}
