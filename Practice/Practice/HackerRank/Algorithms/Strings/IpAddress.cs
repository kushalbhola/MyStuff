using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms.Strings
{
    class IpAddress
    {
        public static void Main(string[] args)
        {
            //Find average of list of words
            string[] list = { "kushal", "bhola", "ajay" };
            int total = 0;
            Console.WriteLine("average of letters: " + total / list.Length);
            

            //Select only the numbers
            string aString = "ABCDE99F-J74-12-89A";
            IEnumerable<char> stringQuery = from ch in aString where Char.IsDigit(ch) select ch;
            foreach (char c in stringQuery)
                Console.WriteLine(c + " ");

            // Select all characters before the first '-'  
            IEnumerable<char> stringQuery2 = aString.TakeWhile(c=>c != '-');
            foreach (char c in stringQuery2)
                Console.WriteLine(c + " ");
            string[] everythingBeforeFirstDash = aString.Split('-');
            string First = aString.Split('-')[2];
            int test = Int32.Parse(First);
            Console.WriteLine("First " + First);
            Console.WriteLine("##############################################################################################");
            foreach (string s in everythingBeforeFirstDash)
                Console.WriteLine(s);
            Console.WriteLine("##########################CHECKING IPADDRESS####################################################################");
            bool result = IsIPv4("172.16.254.7");
            Console.ReadKey();
            
        }
        private static bool IsIPv4(string IP)
        {
            
            string[] ips = IP.Split('.');
            if (ips.Length != 4)
                return false;
            foreach (string i in ips)
            {
                int ipInInt = Int32.Parse(i);
                if (ipInInt < 0 || ipInInt > 255)
                    return false;
            }
            return true;
        }
    }
}
