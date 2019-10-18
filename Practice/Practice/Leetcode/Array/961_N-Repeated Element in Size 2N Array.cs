using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Leetcode.Array
{
    class _961_N_Repeated_Element_in_Size_2N_Array
    {
        static void Main(String[] args)
        {
            int[] input = { 2, 1, 2, 5, 3, 2 };
            _961_N_Repeated_Element_in_Size_2N_Array a = new _961_N_Repeated_Element_in_Size_2N_Array();
            int result = a.RepeatedNTimes(input);
        }
        public int RepeatedNTimes(int[] A)
        {
            int N = A.Length / 2;
            Dictionary<int, int> hash = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (!hash.ContainsKey(A[i]))
                {
                    hash.Add(A[i], 1);
                    if (N == 1)
                        return A[i];
                }
                else
                {
                    hash[A[i]]++;
                    if (N == hash[A[i]])
                        return A[i];
                }
            }
            return 0;
        }
    }
}
