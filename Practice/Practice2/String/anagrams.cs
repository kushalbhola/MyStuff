using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2.String
{
    /*
     * Write a program to generate all potential 
anagrams of an input string.

For example, the potential anagrams of "biro" are

biro bior brio broi boir bori
ibro ibor irbo irob iobr iorb
rbio rboi ribo riob roib robi
obir obri oibr oirb orbi orib
     * */
    class anagrams
    {
        public static void Main(string[] args)
        {
            string str = "biro";
            List<List<string>> finallist = findAnagrams(str);
        }
        private static List<List<string>> findAnagrams(string str)
        {
            //Array.Sort(str);
            List<List<string>> finalList = new List<List<string>>();
            findAnagrams(str, finalList, new List<string>());
            return finalList;
        }
        private static void findAnagrams(string str, List<List<string>> finalList, List<string> tempList)
        {
            if (tempList.Count == str.Length)
                finalList.Add(new List<string>(tempList));
            for(int i=0;i<str.Length;i++)
            {
                if (tempList.Contains(str[i].ToString()))
                    continue;
                tempList.Add(str[i].ToString());
                findAnagrams(str, finalList, tempList);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
