using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.HackerRank.Algorithms
{
    public class knapsack_Greedy
    {
        public static void Main(String[] args)
        {
            double[] obj = { 2, 4, 5, 10, 20, 11 };
            double[] weights = { 1, 2, 3, 4, 5, 6 };
            double[] ratio = getRatio(obj, weights);
            double capacity = 200;
            double maxProfit = getMaxProfit(obj, weights, ratio, capacity);
        }
        private static double getMaxProfit(double[] obj, double[] weights, double[] ratio, double capacity)
        {
            double currentWeight = 0.0;
            while (currentWeight < capacity)
            {
                int maxRatioIndex = getmaxRatioItem(ratio);
                currentWeight = currentWeight + weights[maxRatioIndex] * obj[maxRatioIndex];
            }
            return 0.0;
        }
        private static double[] getRatio(double[] obj, double[] weights)
        {
            double[] ratio = new double[obj.Length];
            for(int i = 0; i < obj.Length; i++)
            {
                ratio[i] = obj[i] / weights[i];
            }
            return ratio;
        }
        private static int getmaxRatioItem(double[] ratio)
        {
            double maxRatio = 0;
            int maxRatioIndex = -1;
            for (int i = 0; i < ratio.Length; i++)
            {
                if(ratio[i] > maxRatio)
                {
                    maxRatio = ratio[i];
                    maxRatioIndex = i;
                }
            }
            return maxRatioIndex;
        }
    }

}
