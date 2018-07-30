using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.CrackingCodingInterview.Fibonacci
{
	class Solution
	{
		public static int Fibonacci(int n)
		{
			if (n == 0 || n == 1)
				return n;
			else
				return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
		static int FibonacciMemo(int n)
		{
			return FibonacciMemo(n, new int[n+1]);
		}
		static int FibonacciMemo(int n, int[] memo)
		{
			if (n == 0 || n == 1)
				return n;
			else if(memo[n]==0)
				{
					memo[n] = FibonacciMemo(n - 1) + FibonacciMemo(n - 2);
				}
			return memo[n];
		}
		static int FibonacciDP(int n)
		{
			//if (n == 0 || n == 1)
			//	return 1;
			//else
			//{
				int[] fib = new int[n+1];
				fib[0] = 1;
				fib[1] = 1;
				for(int i = 2; i <= n; i++)
				{
					fib[i] = fib[i - 1] + fib[i - 2];
				}
				return fib[n-1];
			//}
		}
		public static void Main(String[] args)
		{
            var watch = System.Diagnostics.Stopwatch.StartNew();
			//Console.WriteLine(Fibonacci(40));
            Console.WriteLine(FibonacciMemo(40));
            //Console.WriteLine(FibonacciDP(40));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs + " ms");
            Console.ReadLine();
		}
	}
}
