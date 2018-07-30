using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _495_Teemo_Attacking
    {
        public static void Main(String[] args)
        {
            int[] timeSeries = { 1,2,3,4,5};
            int duration = 2;
            int result = FindPoisonedDuration(timeSeries, duration);
        }
        public static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            if (timeSeries.Length == 0 || duration == 0 || timeSeries == null) return 0;
            int start = timeSeries[0];
            int result = 0;
            for (int i = 1; i < timeSeries.Length; i++)
            {
                if (timeSeries[i] < start + duration)
                    result = result + (timeSeries[i] - start);
                else
                    result = result + duration;
            }
            return result + duration;
        }
    }
}
