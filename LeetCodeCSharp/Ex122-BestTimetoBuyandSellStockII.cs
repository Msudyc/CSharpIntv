/*
Say you have an array for which the ith element is the 
price of a given stock on day i.

Design an algorithm to find the maximum profit. You may 
complete as many transactions as you like (ie, buy one 
and sell one share of the stock multiple times). However, 
you may not engage in multiple transactions at the same 
time (ie, you must sell the stock before you buy again).

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

    public class Ex122
    {
        public static int MaxProfit(int[] prices)
        {
            int p = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int delta = prices[i] - prices[i - 1];
                if (delta > 0) 
                    p += delta;
            }

            return p;
        }
    }
}