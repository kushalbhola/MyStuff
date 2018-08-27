using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings.AlternatingCharacters
{
    //A
	class Solution
	{
		static int alternatingCharacters(string s)
		{
            char[] ch = s.ToCharArray();
            ArrayList newCharArray = new ArrayList();
            int slow = 0;
            int fast = 1;
            int count = 0;
            while (fast < ch.Length)
            {
                if(ch[slow] == ch[fast])
                    count++;
                fast++;
                slow++;
            }

            return count;
        }

        static void Main(String[] args)
		{
            string s = "ABBABBAA";
            int result = alternatingCharacters(s);

        }
	}
}
