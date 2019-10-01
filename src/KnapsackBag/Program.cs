using System;
using System.Collections.Generic;

namespace KnapsackBag
{
    /*
        You are given a bag of size W kg and you are provided costs of packets 
        different weights of oranges in array cost[] where cost[i] is basically 
        cost of ‘i’ kg packet of oranges. Where cost[i] = -1 means that ‘i’ kg 
        packet of orange is unavailable

        Find the minimum total cost to buy exactly W kg oranges and 
        if it is not possible to buy exactly W kg oranges then print -1. 
        It may be assumed that there is infinite supply of all available packet types.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            int[] cost = { 1, 2, 3, 4, 5 };
            int w = 5;
            int n = cost.Length;

            Console.WriteLine(GetMinimumCost(cost, cost.Length, w));
        }

        public static int GetMinimumCost(int[] cost, int length, int w)
        {
            var values = new List<int>();
            var weights = new List<int>();

            var bagSize = 0;
            for (int i = 0; i < length; i++)
            {
                if (cost[i] == -1) continue;

                values.Add(cost[i]);
                weights.Add(i + 1);
                bagSize++;
            }

            int[,] minimumCost = new int[bagSize + 1, w + 1];

            // fill 0th row with maxvalue  
            for (int i = 0; i <= w; i++)
                minimumCost[0, i] = int.MaxValue;

            // fill 0'th column with 0  
            for (int i = 1; i <= bagSize; i++)
                minimumCost[i, 0] = 0;

            // now check for each weight one by one and  
            // fill the matrix according to the condition  
            for (int i = 1; i <= bagSize; i++)
            {
                for (int j = 1; j <= w; j++)
                {
                    // wt[i-1]>j means capacity of bag is  
                    // less then weight of item  
                    if (weights[i - 1] > j)
                    {
                        minimumCost[i, j] = minimumCost[i - 1, j];
                    }

                    // here we check we get minimum cost  
                    // either by including it or excluding  
                    // it  
                    else
                    {
                        int lowValue = minimumCost[i, j - weights[i - 1]];
                        if (lowValue != int.MaxValue)
                        {
                            lowValue += values[i - 1];
                        }

                        minimumCost[i, j] = Math.Min(minimumCost[i - 1, j], lowValue);
                    }
                }
            }

            // exactly weight W can not be made by  
            // given weights  
            return minimumCost[bagSize, w] == int.MaxValue ? -1 : minimumCost[bagSize, w];
        }
    }
}
