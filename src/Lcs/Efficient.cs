using System;

namespace Lcs
{
    /*
    LCS Problem Statement: Given two sequences, find the length of longest subsequence 
    present in both of them. A subsequence is a sequence that appears in the same 
    relative order, but not necessarily contiguous. For example, “abc”, “abg”, 
    “bdf”, “aeg”, ‘”acefg”, .. etc are subsequences of “abcdefg”. 
    */

    public class Efficient
    {
        public static int GetLCS(string x, string y)
        {
            return LCS(x.ToCharArray(), y.ToCharArray(), x.Length, y.Length);
        }

        private static int LCS(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            /* Following steps build L[m+1][n+1]  
            in bottom up fashion. Note 
            that L[i][j] contains length of  
            LCS of X[0..i-1] and Y[0..j-1] */
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }
    }
}
