using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Pramp
{
    class Pairs_with_Specific_Differences
    {
        public static int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.ContainsKey(arr[i]))
                    hash[arr[i]] = i;
                else
                    hash[arr[i]] = i;
            }

            List<int[]> result = new List<int[]>();
            bool[] visited = new bool[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                int[] temp = new int[2];
                if (hash.ContainsKey(arr[j] + k))
                {
                    temp[0] = arr[j];
                    temp[1] = hash[arr[j] + k];
                    //visited[j]=true;
                    //visited[arr[j]+k]= true;
                }
                result.Add(temp);
            }
            return null;
        }

        public static void Main(String[] args)
        {
            int[] arr = { 0, -1, -2, 2, 1 };
            int k = 1;
            int[,] result = FindPairsWithGivenDifference(arr, k);
        }
    }
}
