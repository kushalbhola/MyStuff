using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.ProgrammingInterviewExposed.ArraysAndStrings
{
    class RemoveSpecifiedCharacters
    {
        public static void Main(String[] args)
        {
            string input = "Battle of the Vowels: Hawaii vs. Gronzy";
            string remove = "aeiou";
            char[] inputChar = input.ToCharArray();
            char[] removeChar = remove.ToCharArray();
            int dest = 0;
            for(int i = 0; i < inputChar.Length; i++)
            {
                if (!removeChar.Contains(inputChar[i]))
                {
                    inputChar[dest++] = inputChar[i];
                }
            }
            string output = new string(inputChar);

        }
    }
}
