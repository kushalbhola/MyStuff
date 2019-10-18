using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Strings
{
    class Test
    {
        public static void Main(String[] args)
        {
            String input = "Hi my name is Bob";
            string[] strArray = input.Split(' ');
            int x = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                int len = strArray[i].Length;
                x = x + len;
            }
            Console.WriteLine(x / strArray.Length);
            //Console.ReadKey();
            String input2 = "10.100.100.100";
            string[] strArray2 = input2.Split('.');
            string output22 = null;
            for (int i = 0; i < strArray2.Length; i++)
            {
                output22 = strArray2[i] + "[.]";
            }
            checkIp(input2);

            //var abc = hash.GroupBy(l => l).Select(y => y.Count());
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var output2 = from n in numbers
                          where n % 2 == 0
                          select n;

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Rex", 4));
            dogs.Add(new Dog("Sean", 0));
            dogs.Add(new Dog("Stacy", 3));
            dogs.Add(new Dog("frodo", 7));
            dogs.Add(new Dog("frodo", 13));
            
            int[,] arr2D = new int[2, 3];
            print2DArray(arr2D);

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };
            int p = jaggedArray2[0][1];
            int l = jaggedArray2.Length;
            int l2 = jaggedArray2[0].Length;
            printJaggedArray(jaggedArray2);

            //find average age of dogs
            int averageAge = dogs.Select(b => b).Max(a => a.Age);
            var test3 = dogs.GroupBy(b => b.name).Select(n => new { name = n.Key, countDogs = n.Count() });
            var test4 = dogs.GroupBy(i => i.name).Select(t => new { name = t.Key, count = t.Count() }).Where(b=>b.count > 1);

            int[] arr = { 1, 2, 3, 4, 5};
            int u = Median(arr);

            char[][] jaggedArray3 = new char[][]
            {
                new char[] { 'A', 'B' },
                new char[] { 'A', 'C' },
                new char[] { 'B', 'D' },
                new char[] { 'B', 'C' },
                new char[] { 'R', 'M' },
                new char[] { 'S' },
                new char[] { 'P' },
                new char[] { 'A' }
            };
        }
        public static void friendsDictionary(char[][] jaggedArray)
        {
            //Create a dictionary with first element as the key and if second element exist then increment the counter
            //below doesnt work if dups
            //Dictionary<char, int> hash = new Dictionary<char, int>();
            //for(int i=0;i<jaggedArray.Length;i++)
            //{
            //    if (hash.ContainsKey(jaggedArray[i][0]))
            //    {
            //        if (jaggedArray[i].Length > 1)
            //            hash[jaggedArray[i][0]]++;
            //    }
            //    else
            //    {
            //        if (jaggedArray[i].Length > 1)
            //            hash.Add(jaggedArray[i][0], 1);
            //    }
            //}
            //fix for dups
            Dictionary<char, HashSet<char>> hash = new Dictionary<char, HashSet<char>>();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (hash.ContainsKey(jaggedArray[i][0]) && jaggedArray[i].Length > 1)
                {
                    hash[jaggedArray[i][0]].Add(jaggedArray[i][1]);
                }
                else if (jaggedArray[i].Length > 1)
                {
                    HashSet<char> h = new HashSet<char>();
                    h.Add(jaggedArray[i][1]);
                    hash.Add(jaggedArray[i][0], h);
                }
            }
        }
        public static void printJaggedArray(int[][] jaggedArray)
        {
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.WriteLine(jaggedArray[i][j]);
            }
        }
        public static void print2DArray(int[,] arr)
        {
            int rowNum = arr.GetLength(0);
            int colNum = arr.GetLength(1);

            rowNum = arr.GetUpperBound(0);
            colNum = arr.GetUpperBound(1);
        }
        public static int Median(int[] nums)
        {
            System.Array.Sort(nums);
            int mid = 0;
            if(nums.Length %2 == 0)
            {
                int a = nums[nums.Length / 2];
                int b = nums[nums.Length / 2 - 1];
                mid = ( a+b) / 2;
            }
            else
            {
                mid = nums[nums.Length / 2];
            }
            return (int)mid;
        }
        public static void checkIp(string input2)
        {
            string[] str = input2.Split('.');
            string output = "Yes";
            foreach (string c in str)
            {
                try
                {
                    int y = Convert.ToInt32(c);
                    if (y < 0 || y > 1000)
                        output = "No";
                }
                catch (Exception e)
                {
                    output = "No";
                }
            }
            Console.WriteLine(output);
        }




    }
    class Dog
    {
        public string name;
        public int Age;
        public Dog(string name , int Age)
        {
            this.name = name;
            this.Age = Age;
        }
    }
}
