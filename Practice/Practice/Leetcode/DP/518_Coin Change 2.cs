using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.DP
{
    class _518_Coin_Change_2
    {
        public static void Main(String[] args)
        {
            int[] coins = { 1, 2, 5 };
            int amount = 11;
            _518_Coin_Change_2 a = new _518_Coin_Change_2();
            int result = a.Change(amount, coins);
            
        }
        private int Change(int amount, int[] coins)
        {
            int[,] DP = new int[coins.Length + 1, amount + 1];
            DP[0, 0] = 0;
            for (int i = 1; i <= coins.Length; i++)
            {
                DP[i,0] = 1;
                for (int j = 1; j <= amount; j++)
                {
                    if (j >= coins[i - 1])
                        DP[i, j] = DP[i - 1, j] + DP[i, j - coins[i - 1]];
                    else
                        DP[i, j] = DP[i - 1, j] + 0;
                }
            }
            return 0;
        }
    }
}
