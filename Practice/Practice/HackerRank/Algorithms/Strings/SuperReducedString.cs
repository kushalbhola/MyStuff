using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings
{
	class SuperReducedString
	{
		public static void Main(String[] args)
		{
			StringBuilder str = new StringBuilder("zztqooauhujtmxnsbzpykwlvpfyqijvdhuhiroodmuxiobyvwwxupqwydkpeebxmfvxhgicuzdealkgxlfmjiucasokrdznmtlwh");
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i= 0; i < str.Length; i++)
            {
                if (dict.ContainsKey(str[i]))
                {
                    dict[str[i]] = dict[str[i]] + 1;
                }
                else
                {
                    dict.Add(str[i], 1);
                }
            }
            StringBuilder result = new StringBuilder();
            foreach(var x in dict)
            {
                if(x.Value % 2 == 1)
                {
                    result.Append(x.Key);
                }
            }
		}
		
	}
}
