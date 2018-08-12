using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Pramp
{
    class Busiest_Time_in_The_Mall
    {
        static void Main(String[] args)
        {
            Busiest_Time_in_The_Mall a = new Busiest_Time_in_The_Mall();

            //int[,] data = new int[,] { { 1487799425, 14, 1 }, { 1487799425, 4, 0 }, { 1487799425, 2, 0 }, { 1487800378, 10, 1 }, { 1487801478, 18, 0 }, { 1487801478, 18, 1 }, { 1487901013, 1, 0 }, { 1487901211, 7, 1 }, { 1487901211, 7, 0 } };
            //int[,] data = new int[,] { { 1487799425, 21, 0 } , { 1487799427, 22, 1 }, { 1487901318, 7, 0 } };
            //int[,] data = { { 1487799425, 14, 1 }, { 1487799425, 4, 0 }, { 1487799425, 2, 0 }, { 1487800378, 10, 1 }, { 1487801478, 18, 0 }, { 1487801478, 18, 1 }, { 1487901013, 1, 0 }, { 1487901211, 7, 1 }, { 1487901211, 7, 0 } };
            int[,] data = { { 1487799425, 14, 1 }, { 1487799425, 4, 1 }, { 1487799425, 2, 1 }, { 1487800378, 10, 1 }, { 1487801478, 18, 1 }, { 1487901013, 1, 1 }, { 1487901211, 7, 1 }, { 1487901211, 7, 1 } };
            int result = FindBusiestPeriod(data);

        }
        public static int FindBusiestPeriod(int[,] data)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                int[] curr = getRow(data, i);
                if (dict.ContainsKey(curr[0]))
                {
                    if (curr[2] == 1)
                        dict[curr[0]] = dict[curr[0]] + curr[1];
                    else
                        dict[curr[0]] = dict[curr[0]] - curr[1];
                }
                else
                {
                    if (curr[2] == 1)
                        dict[curr[0]] = curr[1];
                    else
                        dict[curr[0]] = curr[1] - (2 * curr[1]);
                }
                    
            }
            int maxKey = 0;
            int maxValue = 0;
            foreach(var d in dict)
            {
                if (d.Value > maxValue)
                {
                    maxValue = d.Value;
                    maxKey = d.Key;
                }
            }
            return maxKey;
        }
        public static int[] getRow(int[,] data, int row)
        {
            int[] result = new int[data.GetLength(1)];
            for (int i = 0; i < data.GetLength(1); i++)
                result[i] = data[row, i];
            return result;
        }
    }
}
