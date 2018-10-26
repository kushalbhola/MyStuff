using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode.Pramp
{
    class TimePlanner
    {
        public static void Main(String[] args)
        {
            int[,] slotsA =
            {
                {10, 50}, 
                {60,120 }, 
                {140,210 }
            };
            int[,] slotsB =
            {
                {0, 15}, 
                {60,70 }
            };
            TimePlanner a = new TimePlanner();
            int[] result = MeetingPlanner(slotsA, slotsB, 8);
        }
        public static int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            int[] result = new int[2];
            // your code goes here
            int slotARowLen = slotsA.GetLength(0);
            int slotBRowLen = slotsB.GetLength(0);
            if (slotARowLen > slotBRowLen)
            {
                for (int i = 0; i < slotBRowLen; i++)
                {
                    int[] slotATemp = { slotsA[i, 0], slotsA[i, 1] };
                    int[] slotBTemp = { slotsB[i, 0], slotsB[i, 1] };
                    int delta = isOverLap(slotATemp, slotBTemp);
                    if (delta > dur)
                    {
                        result[0] = delta;
                        result[1] = delta + dur;
                    }
                }
            }
            else if (slotARowLen < slotBRowLen)
            {
                for (int i = 0; i < slotARowLen; i++)
                {
                    int[] slotATemp = { slotsA[i, 0], slotsA[i, 1] };
                    int[] slotBTemp = { slotsB[i, 0], slotsB[i, 1] };
                    if (isOverLap(slotATemp, slotBTemp) > 0)
                    {
                        result[0] = Math.Max(slotATemp[0], slotBTemp[0]);
                        result[1] = Math.Max(slotATemp[0], slotBTemp[0]) + dur;
                    }
                }
            }
            return result;
        }
        public static int isOverLap(int[] epochA, int[] epochB)
        {
            int delta = Math.Min(epochB[1], epochA[1]) - Math.Max(epochA[0], epochB[0]);
            if (delta > 0)
                return delta;
            else
                return 0;

        }
    }
}
