using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Leetcode
{
    class _593_ValidSquare
    {
        static void Main(String[] args)
        {
            int[] p1 = { 0, 0 };
            int[] p2 = { 1, 1 };
            int[] p3 = { 1, 0 };
            int[] p4 = { 0, 1 };
            bool result = ValidSquare(p1, p2, p3, p4);
        }
        public static bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            if (Length(p1, p2) == Length(p2, p3) && (Length(p1, p2) == Length(p3, p4)) && (Length(p1, p2) == Length(p4, p1)))
                return true;
            else
                return false;
        }
        private static double Length(int[] p, int[] q)
        {
            double result = Math.Sqrt((q[1] - p[1] * q[1] - p[1]) + (q[0] - p[0] * q[0] - p[0]));
            return result;
        }
    }
}
