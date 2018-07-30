using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _122_Best_Time_to_Buy_and_Sell_Stock_II
    {
        public static void Main(String[] args)
        {
            //int[] prices = { 7, 1, 5, 3, 6, 4 };
            int[] prices = { 1,2,3,4,5};
            int profit = MaxProfit(prices);
        }
        public static int MaxProfit(int[] prices)
        {
            int i = 0;
            int peak = prices[0];
            int valley = prices[0];
            int maxProfit = 0;
            while (i < prices.Length - 1)
            {
                while (i < prices.Length - 1 && prices[i] > prices[i + 1])
                    i++;
                valley = prices[i];
                while (i < prices.Length - 1 &&  prices[i] < prices[i + 1])
                    i++;
                peak = prices[i];
                maxProfit = maxProfit + (peak - valley);
            }
            return maxProfit;
        }
    }
}
