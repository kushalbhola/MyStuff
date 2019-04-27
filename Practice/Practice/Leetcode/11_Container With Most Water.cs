using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _11_Container_With_Most_Water
    {
        public static void Main(String[] args)
        {
            _11_Container_With_Most_Water a = new _11_Container_With_Most_Water();
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = a.MaxArea(height);
            result = a.MaxArea2(height);
        }
        public int MaxArea(int[] height)
        {
            /*
            Sp basically as I can see, this problem is abolut finding max possible area.
            have a loop and have 2 pointers to maintain the maxArea and maxArea so far kinda approach
            */
            int start = 0;
            int end = height.Length-1;
            int currArea = 0;
            int maxArea = 0;
            while (end > start)
            {
                currArea = Math.Min(height[start], height[end]) * (end - start);
                if (currArea > maxArea)
                    maxArea = currArea;
                if (height[start] > height[end])
                    end--;
                else
                    start++;
            }
            return maxArea;

        }

        //Attempt 2
        public int MaxArea2(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;
            int maxArea = 0;
            while (end > start)
            {
                int currArea = Math.Min(height[start], height[end]) * (end - start);
                if (currArea > maxArea)
                    maxArea = currArea;
                if (height[start] < height[end])
                    start++;
                else
                    end--;
            }
            return maxArea;
        }
    }
}
