using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _121_Best_Time_to_Buy_and_Sell_Stock
    {
        public static void Main(String[] args)
        {
            int[] prices = {2,4,1};
            int result = MaxProfit(prices);
        }
        public static int MaxProfit(int[] prices)
        {
            int minValue = 100000;
            int profit = 0;
            int maxValue = -100000;
            for(int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                    maxValue = prices[i];
                    //profit = maxValue - minValue;
                }
                else if(prices[i] > minValue && prices[i] - minValue > profit)
                {
                    maxValue = prices[i];
                    profit = maxValue - minValue;
                }
            }
            return profit;
        }
    }
}
