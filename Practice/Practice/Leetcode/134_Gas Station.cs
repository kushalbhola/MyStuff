using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    public class _134_Gas_Station
    {
        public static void Main(String[] args)
        {
            int[] gas = { 1,2,3,4,5};
            int[] cost = {3,4,5,1,2};
            int result = FindGasStationLoop(gas, cost);

        }
        private static int FindGasStationLoop(int[] gas, int[] cost)
        {
            int tank = 0;
            int deficit = 0;
            int start = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                tank = tank + (gas[i] - cost[i]);
                if(tank < 0)
                {
                    start = i + 1;
                    deficit = deficit + tank;
                    tank = 0;
                }
            }
            if (tank + deficit >= 0)
                return start;
            else
                return -1;
        }
    }
}

/*
 *      int start = gas.size()-1;
       int end = 0;
       int sum = gas[start] - cost[start];
       while (start > end) {
          if (sum >= 0) {
             sum += gas[end] - cost[end];
             ++end;
          }
          else {
             --start;
             sum += gas[start] - cost[start];
          }
       }
       return sum >= 0 ? start : -1;
 */
