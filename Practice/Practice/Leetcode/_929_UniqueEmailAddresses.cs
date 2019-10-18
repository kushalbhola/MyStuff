using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _929_UniqueEmailAddresses
    {
        public static void Main(string[] args)
        {
            _929_UniqueEmailAddresses a = new _929_UniqueEmailAddresses();
            string[] emails = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            int results = a.NumUniqueEmails(emails);

            char x = 'a';
            char X = 'A';
            int test = x;
            int test2 = X;

            char final = Convert.ToChar(test2 + 1);
            string test4 = "kushal ".Trim();
            int test6 = Int32.Parse("1");

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            list.Add(6);
            list.Add(7);
            list.Add(11);
            list.Add(21);
            int test3 = list.OrderByDescending(m => m).FirstOrDefault();
            


            string[,] newArray =  { { "A", "B" }, { "A", "C" }, { "B", "D" }, { "B", "C"}, { "A", "D"} };
            Dictionary<string, int> result = a.FindFriends(newArray);
            bool results4 = a.ValidateIP("0.121.121");
            Console.WriteLine(a.ValidateIP("0.121.121"));
            Console.WriteLine(a.ValidateIP("1"));
            Console.WriteLine(a.ValidateIP("0.121.121.232"));
            Console.WriteLine(a.ValidateIP("11.121.121.878"));
            Console.WriteLine(a.ValidateIP("11.121.121.23"));
            Console.WriteLine(a.ValidateIP("11.121.121.878.23232"));
            string input = "Let's take LeetCode contest";
            string output = a.ReverseWords(input);

        }
        static void printList(List<int> list)
        {
            foreach (int i in list)
                Console.WriteLine(i);
        }
        //You have a 2-D array of friends like[[A, B],[A, C],[B, D],[B, C],[R, M], [S],[P], [A]]
        //Write a function that creates a dictionary of how many friends each person has.People can have 0 to many friends.However, there won't be repeat relationships like [A,B] and [B,A] and neither will there be more than 2 people in a relationship  
        //
        private Dictionary<string, int> FindFriends(string[,] arr)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string test3 = dict.Select(x => x.Key).OrderByDescending(o => o).FirstOrDefault();
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                if (dict.ContainsKey(arr[i, 0]))
                    dict[arr[i, 0]]++;
                else
                    dict.Add(arr[i, 0], 1);
                    
            }
            return dict;
        }
        private bool ValidateIP(string ip)
        {
            if (ip[0] == '0')
                return false;
            string[] parts = ip.Split('.');
            if (parts.Length != 4)
                return false;
            int test = 0;
            foreach(string p in parts)
            {
                int temp = Int32.Parse(p); ;
                if (temp <= 0 || temp > 255 && test == 0)
                {
                    return false;
                    test++;
                }
                    
                else if (temp < 0 || temp > 255 && test != 0)
                    return false;
            }
            return true;
        }
        public int NumUniqueEmails(string[] emails)
        {
            if (emails.Length == 0) return 0;
            List<string> finalList = new List<string>();
            var send = new List<string>();
            foreach (string email in emails)
            {
                var emailPar = email.Split('@');
                string leftPart = emailPar[0].Replace(".", "").Split('+')[0] ;
                string rightPart = emailPar[1];
                finalList.Add(leftPart + "@" + rightPart);
                if (!finalList.Contains(leftPart + "@" + rightPart))
                    finalList.Add(leftPart + "@" + rightPart);

            }
            return finalList.Distinct().Count();
        }
        //557_Reverse Words in a String III
        //https://leetcode.com/problems/reverse-words-in-a-string-iii/
        public string ReverseWords(string s)
        {
            char[] ch = s.ToCharArray();
            int start = 0;
            int end = ch.Length - 1;
            while (end > start)
            {
                char test = ch[start];
                ch[start] = ch[end];
                ch[end] = test;
                start++; end--;
            }
            return ch.ToString();
        }
    }
}
