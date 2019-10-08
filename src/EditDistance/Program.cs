using System;

namespace EditDistance
{
    public class Program
    {
        public static int GetEditDistance(string str1, string str2)
        {

            int m = str1.Length, n = str2.Length;

            // Create a table to store 
            // results of subproblems 
            int[,] solutionDP = new int[m + 1, n + 1];

            // Fill d[][] in bottom up manner 
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    // If first string is empty, only option is to 
                    // insert all characters of second string 
                    if (i == 0)
                    {
                        // Min. operations = j 
                        solutionDP[i, j] = j;
                    }

                    // If second string is empty, only option is to 
                    // remove all characters of second string 
                    else if (j == 0)
                    {
                        // Min. operations = i 
                        solutionDP[i, j] = i;
                    }

                    // If last characters are same, ignore last char 
                    // and recur for remaining string 
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        solutionDP[i, j] = solutionDP[i - 1, j - 1];
                    }

                    // If the last character is different, consider all 
                    // possibilities and find the minimum 
                    else
                    {
                        int insertValue = solutionDP[i, j - 1];
                        int removeValue = solutionDP[i - 1, j];
                        int replaceValue = solutionDP[i - 1, j - 1];

                        solutionDP[i, j] = 1 + Math.Min(insertValue, Math.Min(removeValue, replaceValue));
                    }
                }
            }

            return solutionDP[m, n];
        }

        public static int GetEditDistanceRecursive(string str1, string str2)
        {
            return GetEditDistanceRecursive(str1, str2, str1.Length, str2.Length);
        }

        private static int GetEditDistanceRecursive(string str1, string str2, int m, int n)
        {
            // If first string is empty, the only option is to 
            // insert all characters of second string into first 
            if (m == 0) return n;

            // If second string is empty, the only option is to 
            // remove all characters of first string 
            if (n == 0) return m;

            // If last characters of two strings are same, nothing 
            // much to do. Ignore last characters and get count for 
            // remaining strings. 
            if (str1[m-1] == str2[n-1])
            {
                return GetEditDistanceRecursive(str1, str2, m - 1, n - 1);
            }

            // If last characters are not same, consider all three 
            // operations on last character of first string, recursively 
            // compute minimum cost for all three operations and take 
            // minimum of three values. 

            int insertValue = GetEditDistanceRecursive(str1, str2, m, n - 1);
            int removeValue = GetEditDistanceRecursive(str1, str2, m - 1, n);
            int replaceValue = GetEditDistanceRecursive(str1, str2, m - 1, n - 1);

            return 1 + Math.Min(insertValue, Math.Min(removeValue, replaceValue));
        }
    }
}
