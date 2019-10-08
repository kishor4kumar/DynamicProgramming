using System;
using System.Collections.Generic;
using System.Text;

namespace Lis
{
    public class Recursive
    {
        /**
        * Recursive way of solving LIS
        */
        public static int LongestSubsequenceRecursive(int[] arr)
        {
            int maxLen = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int len = LongestSubsequenceRecursive(arr, i + 1, arr[i]);
                if (len > maxLen)
                {
                    maxLen = len;
                }
            }
            return maxLen + 1;
        }

        private static int LongestSubsequenceRecursive(int[] arr, int pos, int lastNum)
        {
            if (pos == arr.Length)
            {
                return 0;
            }

            int t1 = 0;
            if (arr[pos] > lastNum)
            {
                t1 = 1 + LongestSubsequenceRecursive(arr, pos + 1, arr[pos]);
            }

            int t2 = LongestSubsequenceRecursive(arr, pos + 1, lastNum);

            return Math.Max(t1, t2);
        }
    }
}
