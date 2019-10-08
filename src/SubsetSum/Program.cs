using System;

namespace SubsetSum
{
    public class Program
    {
        public static bool IsSubsetSumPossible(int[] arr, int sum)
        {
            int n = arr.Length;
            bool[,] dp = new bool[sum + 1, n + 1];

            for(int i=1; i <= sum; i++)
            {
                dp[i, 0] = false;
            }

            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = true;
            }

            for(int i=1; i<=sum; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    if(i < arr[j-1])
                    {
                        dp[i, j] = dp[i, j-1];
                    }
                    else if(i >= arr[j-1])
                    {
                        dp[i, j] = dp[i, j-1] || dp[i - arr[j - 1], j - 1];
                    }
                }
            }

            return dp[sum,n];
        }

        public static bool IsSubsetSumPossibleRecursive(int[] arr, int sum)
        {
            return IsSubsetSumPossibleRecursive(arr, arr.Length, sum);
        }

        private static bool IsSubsetSumPossibleRecursive(int[] arr, int n, int sum)
        {
            if (sum == 0) return true;

            if (n == 0 && sum != 0) return false;

            if (sum < arr[n - 1]) return IsSubsetSumPossibleRecursive(arr, n - 1, sum);

            return IsSubsetSumPossibleRecursive(arr, n - 1, sum) || 
                    IsSubsetSumPossibleRecursive(arr, n - 1, sum - arr[n - 1]);
        }
    }
}
