using System;

namespace Practice.Leetcode
{
    class Program
    {
        public void sortieren(int[] myArr)
        {
            Array.Sort(myArr);
        }
        public static void Main(string[] args)
        {
            int[] myArr = new int[5] { 1, 5, 3, 8, 21 };
            Program.sortieren(myArr);
            foreach (int u in myArr)
            {
                Console.WriteLine(u);
            }
        }
    }
}
