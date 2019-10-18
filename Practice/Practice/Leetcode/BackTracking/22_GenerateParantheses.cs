using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BackTracking
{
    class _22_GenerateParantheses
    {
        public static void Main(String[] args)
        {
            int n = 3;

        }
        public IList<string> GenerateParenthesis(int n)
        {
            string input = "";
            for (int i = 0; i < n; i++)
            {
                input += "()";
            }
            IList<string> result = new List<string>();
            string tempList = null;
            CreateParanthesis(result, tempList,input, 0, n);
            return null;
        }
        public void CreateParanthesis(IList<string> result, string tempList, string input, int start, int n)
        {
            if (tempList.Length == 5)
            {
                result.Add(tempList);
            }
                
        }
    }
}
