using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.IceCreamParlor
{
	class Solution
	{
        /*
         * Algorithm: 
         * 1. 
         */
        static void Main(String[] args)
		{
            int money = 5;
            int[] menu = { 1,4,5,3,2};

            BuyIceCream(menu, money);
            //Dictionary<int, int> dict = new Dictionary<int, int>(); //key: cost, value: iceCreamID
            //for(int i = 0; i < menu.Length; i++)
            //{
            //    int iceCreamID = i + 1;
            //    int cost = menu[i];

            //    int valueToLookFor = money - cost;
            //    if (dict.ContainsKey(valueToLookFor))
            //    {
            //        Console.WriteLine(dict[valueToLookFor] + " " + iceCreamID);
            //    }
            //    if (!dict.ContainsKey(cost))
            //        dict.Add(cost, iceCreamID);
            //}
            //Console.ReadKey();
		}
        static void BuyIceCream(int[] costs, int money)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < costs.Length; i++)
            {
                int iceCreamID = i + 1;
                int cost = costs[i];
                int valueToSearch = money - cost;
                if (dict.ContainsKey(valueToSearch))
                {
                    Console.WriteLine(dict[valueToSearch] + " " + iceCreamID);
                }
                if (!dict.ContainsKey(costs[i]))
                    dict.Add(costs[i], iceCreamID);
            }
        }
    }
}