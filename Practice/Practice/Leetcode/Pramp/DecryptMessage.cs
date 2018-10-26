using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Pramp
{
    //Question: https://www.pramp.com/challenge/8noLWxLP6JUZJ2bA2rnx
    class DecryptMessage
    {
        public static void Main(String[] args)
        {
            string word = "dnotq";
            string result = Decrypt(word);
        }
        public static string Decrypt(string word)
        {
            char[] ch = word.ToCharArray();
            int[] asciiArray = new int[ch.Length];
            asciiArray[0] = asciiArray[0] - 1;
            for (int i= 0;i< ch.Length; i++){
                asciiArray[i] = ch[i];
            }
            //for each subtract the last one from it
            for (int j = 1; j < asciiArray.Length;j++)
            {
                asciiArray[j] = asciiArray[j - 1];
            }
            return word;

                
        }
    }
}
