using System;

namespace Lis
{
    /*
     The Longest Increasing Subsequence (LIS) problem is to find the length 
     of the longest subsequence of a given sequence such that all elements 
     of the subsequence are sorted in increasing order. For example, 
     the length of LIS for {10, 22, 9, 33, 21, 50, 41, 60, 80} is 6 
     and LIS is {10, 22, 33, 50, 60, 80}.
     */

    public class Program
    {
        public static int GetLIS(int[] arr)
        {
            int n = arr.Length;
            int[] list = new int[n];
            int[] solution = new int[n];

            for(int i=0; i<n; i++)
            {
                list[i] = 1;
                solution[i] = i;
            }

            for(int i=1; i<n; i++)
            {
                for(int j=0; j<i; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        if(list[j]+1 > list[i])
                        {
                            list[i] = 1 + list[j];
                            solution[i] = j; 
                        }
                    }
                }
            }


            //find the index of max number in T 
            int maxIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (list[i] > list[maxIndex])
                {
                    maxIndex = i;
                }
            }

            //lets print the actual solution
            int t, newT = maxIndex;
            do
            {
                t = newT;
                Console.Write(arr[t] + " ");
                newT = solution[t];
            } while (t != newT);
            Console.WriteLine();

            return list[maxIndex];
        }
    }
}
