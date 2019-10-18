using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.BinarySearchQuestions
{
    class _367_ValidPerfectSquare
    {
        public static void Main(String[] args)
        {
            _367_ValidPerfectSquare a = new _367_ValidPerfectSquare();
            bool result = a.IsPerfectSquare(808201);
        }
        public bool IsPerfectSquare(int num)
        {
            if (num == 1)
                return true;
            long start = 0;
            long end = num / 2;
            long mid = 0;
            while (end >= start)
            {
                mid = start + (end - start) / 2;
                long midSquare = mid * mid;
                if (midSquare == num)
                    return true;
                if (midSquare < num)
                    start = mid + 1;
                if (midSquare > num)
                    end = mid - 1;
            }
            return false;
        }
    }
}
