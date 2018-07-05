using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class TestTime
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;

            Console.WriteLine(today);
            Console.WriteLine(now);
            string num = now.ToLongTimeString();
            Console.WriteLine(num.Substring(5, 2));

            num = num.Substring(5, 2);
            char[] ch = num.ToCharArray();
            if (ch[0] == '0')
                num = num.Substring(1, 1);
            int randomValue = Int32.Parse(num);
            Console.WriteLine(num);

            Console.ReadLine();
        }

    }
}
