using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Quesiton: https://leetcode.com/problems/coin-change/description/
namespace Practice.Leetcode.DP
{
    class _322_Coin_Change
    {
        Dictionary<int, int> amountDict = new Dictionary<int, int>();
        public static void Main(String[] args)
        {
            
            int[] coins = {1,2,5};
            int amount = 11;
            _322_Coin_Change a = new _322_Coin_Change();
            int result = a.CoinChange(coins, amount);

            //int result = a.CoinChange2(coins, amount);
            //int result = minCoins(coins, coins.Length, amount);
        }
        public static int CoinChange2(int[] coins, int amount)
        {
            if (amount == 0) return 0;
            int currentMin = amount + 1;
            foreach (int coin in coins)
            {
                int curr = 0;
                if (amount >= coin)
                {
                    int next = CoinChange2(coins, amount - coin);
                    if (next >= 0)
                        curr = next + 1;
                    else curr = next;
                    if (curr < currentMin)
                        currentMin = curr;
                }
                
            }
            return currentMin == amount + 1 ? -1 : currentMin;
        }
        // m is size of coins array 
        // (number of different coins)
        static int minCoins(int[] coins, int m, int V)
        {

            // base case
            if (V == 0) return 0;

            // Initialize result
            int res = int.MaxValue;

            // Try every coin that has
            // smaller value than V
            for (int i = 0; i < m; i++)
            {
                if (coins[i] <= V)
                {
                    int sub_res = minCoins(coins, m,
                                      V - coins[i]);

                    // Check for INT_MAX to 
                    // avoid overflow and see 
                    // if result can minimized
                    if (sub_res != int.MaxValue &&
                                sub_res + 1 < res)
                        res = sub_res + 1;
                }
            }
            return res;
        }
        private int CoinChange(int[] coins, int amount)
        {
            _322_Coin_Change b = new _322_Coin_Change();
            if (amount == 0)
                return 0;
            if (b.amountDict.ContainsKey(amount))
                return amountDict[amount];
            int currentMin = amount + 1;
            foreach (int coin in coins)
            {
                int curr = 0;
                if (amount >= coin)
                {
                    int next = CoinChange(coins, amount - coin);
                    if (next >= 0)
                        curr = 1 + next;
                }
                if (curr > 0) {
                    currentMin = Math.Min(currentMin, curr);
                    if (!amountDict.ContainsKey(amount - coin))
                        amountDict[amount - coin] = currentMin;
                }
                    
            }
            int finalCount = (currentMin == amount + 1) ? -1 : currentMin;
            return finalCount;
        }
    }
}
