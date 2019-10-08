using System;

namespace GoldMine
{
    /*
    Gold Mine Problem

    Given a gold mine of n*m dimensions. Each field in this mine contains a positive integer 
    which is the amount of gold in tons. Initially the miner is at first column but can be at any row. 
    He can move only (right->,right up /,right down\) that is from a given cell, 
    the miner can move to the cell diagonally up towards the right or right or 
    diagonally down towards the right. Find out maximum amount of gold he can collect. 
     */

    public class Program
    {
        public static int GetMaxGold(int[,] gold, int n, int m)
        {
            for(int col = m - 2; col >= 0; col--)
            {
                for(int row=0; row < n; row++)
                {
                    var right = gold[row,col + 1];
                    var rightUp = (row - 1 >= 0) ? gold[row - 1,col + 1] : 0;
                    var rightDown = (row + 1 < n) ? gold[row + 1, col + 1] : 0;

                    gold[row, col] += Math.Max(right, Math.Max(rightUp, rightDown));
                }
            }

            var result = 0;
            for(int i=0; i <n; i++)
            {
                result = Math.Max(result, gold[i, 0]);
            }

            return result;
        }
    }
}
