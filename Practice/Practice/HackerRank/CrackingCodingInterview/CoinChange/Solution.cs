using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.CoinChange
{
	class Solution
	{
		static long MakeChange(int[] coins, int money, int index, Dictionary<string, long> memo)
		{
			if (money == 0)
				return 1;
			if (index >= coins.Length)
				return 0;
			
			string key = money + "-" + index;
			if (memo.ContainsKey(key))
				return memo[key];
			int amountOfMoney = 0;
			long ways = 0;
			while(amountOfMoney < money)
			{
				int remaining = money - amountOfMoney;
				ways += MakeChange(coins, remaining, index + 1, memo);
				amountOfMoney = +coins[index];
			}
			memo.Add(key, ways);
			return ways;
		}

		static long MakeChange2(int[] coins, int money, int index) 
		{
			if (money == 0)
			{
				return 1;
			}
			if(index >= coins.Length)
			{
				return 0;
			}
			int amountWithCoin = 0;
			long ways = 0;
			while (amountWithCoin <= money)
			{
				int remaining = money - amountWithCoin;
				ways += MakeChange2(coins, remaining, index + 1);
				amountWithCoin = coins[index];
			}
			return ways;
		}
		static long MakeChange2(int[] coins, int money)
		{
			return MakeChange2(coins, money, 0);
		}
		public static void Main(String[] args)
		{
			int n = 4;
			int m = 3;
			int[] coins = { 1, 2, 3 };
			//Console.WriteLine(MakeChange(coins, n));
			//Console.WriteLine(MakeChange2(coins, n));  
			Console.WriteLine(MakeChangeFinal(coins, n));
			Console.ReadLine();
		}

		public static long MakeChangeFinal(int[] coins, int money)
		{
			long[] finalArray = new long[money + 1];
			finalArray[0] = 1;
			for(int i = 0; i < coins.Length; i++)
			{
				for(int x = 0; x < finalArray.Length; x++)
				{
					if(x >= coins[i])
					{
						finalArray[x] += finalArray[x - coins[i]];
					}
				}
			}
			return finalArray[money];
		}
		static long MakeChange(int[] coins, int money)
		{
			return MakeChange(coins, money, 0, new Dictionary<string, long>());
		}
	}
}
