using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _70_Climbing_Stairs
    {
        public static void Main(String[] args)
        {
            _70_Climbing_Stairs a = new _70_Climbing_Stairs();
            int n = 3;
            int[] DP = new int[n + 1];
            int result = a.ClimbStairs(n);
        }
        private int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (n == 2) return 2;

            int[] DP = new int[n + 1];

            DP[0] = 0; DP[1] = 1;DP[2] = 2;
            for(int i = 3; i < DP.Length; i++)
            {
                DP[i] = DP[i - 1] + DP[i - 2];
            }
            return DP[n];
        }
        private int ClimbStairs(int n, int[] DP)
        {
            if (n == 0)
            {
                DP[n] = 0;
                return DP[0];
            }
            else if (n == 1)
            {
                DP[n] = 1;
                return DP[n];

            }
            else if (n == 2)
            {
                DP[n] = 2;
                return DP[n];
            }
            else
                DP[n] = DP[n - 1] + DP[n - 2];
            return DP[n];
        }
    }
}
