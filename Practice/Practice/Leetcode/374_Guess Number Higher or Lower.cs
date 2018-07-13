using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _374_Guess_Number_Higher_or_Lower
    {
        public int guessNumber(int n)
        {
            int start = 0;
            int end = n;
            int mid = 0;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (guess(mid) == -1)
                    end = mid - 1;
                else if (guess(mid) == 1)
                    start = mid + 1;
                else
                    return mid;
            }
            return 0;
        }
    }
}
