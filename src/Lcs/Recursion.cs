using System;

namespace Lcs
{
    public class Recursion
    {
        public static int GetLCS(string x, string y)
        {
            return LCS(x.ToCharArray(), y.ToCharArray(), x.Length, y.Length);
        }

        private static int LCS(char[] x, char[] y, int m, int n)
        {
            if (m == 0 || n == 0) return 0;

            if (x[m - 1] == y[n - 1]) return 1 + LCS(x, y, m - 1, n - 1);

            return Math.Max(LCS(x, y, m, n - 1), LCS(x, y, m - 1, n));
        }
    }
}
