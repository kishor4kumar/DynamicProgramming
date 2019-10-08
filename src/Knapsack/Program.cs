using System;

namespace Knapsack
{
    public class Program
    {
        public static int GetMaxValue(int[] val, int[] wt, int w)
        {
            int n = val.Length;

            int[,] dp = new int[n+1, w+1];

            for(int i = 0; i<=n; i++) //array 0...n as matrix row
            {
                for(int j=0; j<=w; j++) //weights 0...w as matrix col
                {
                    if(i==0 || j==0)
                    {
                        dp[i,j] = 0;
                    }
                    else if(wt[i-1] <= j)
                    {
                        dp[i, j] = Math.Max(val[i-1] + dp[i - 1, j - wt[i - 1]], dp[i - 1, j]);
                    }
                    else
                    {
                        dp[i, j] = dp[i-1, j];
                    }

                }
            }

            return dp[n,w];
        }

        public static int GetMaxValueRecursive(int[] val, int[] wt, int w)
        {
            int n = val.Length;

            return GetMaxValueRecursive(w, n, val, wt); ;
        }

        private static int GetMaxValueRecursive(int w, int n, int[] val, int[] wt)
        {
            if (w == 0 || n == 0) return 0;

            if (w < wt[n - 1]) return GetMaxValueRecursive(w, n - 1, val, wt);

            return Math.Max(val[n-1] + GetMaxValueRecursive(w - wt[n-1], n - 1, val, wt),
                GetMaxValueRecursive(w, n - 1, val, wt));
        }
    }
}
