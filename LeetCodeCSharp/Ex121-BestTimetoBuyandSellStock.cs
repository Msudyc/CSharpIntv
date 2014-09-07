/*
Say you have an array for which the ith element is the 
price of a given stock on day i.

If you were only permitted to complete at most one 
transaction (ie, buy one and sell one share of the 
stock), design an algorithm to find the maximum profit.

class Solution {
public:
    int maxProfit(List<int> &prices) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex121
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) 
                return 0;

            int low = prices[0];
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                low = Math.Min(prices[i], low);
                profit = Math.Max(profit, prices[i] - low);
            }

            return profit;
        }
    }
}