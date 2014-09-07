/*
Say you have an array for which the ith element is the 
price of a given stock on day i.

Design an algorithm to find the maximum profit. You may
complete at most two transactions.

Note:
 You may not engage in multiple transactions at the same
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

    public class Ex123
    {
        public static int MaxProfit(int[] prices)
        {
            int len = prices.Length;
            if (len <= 1) 
                return 0;

            int[] maxFromHead = new int[len];
            maxFromHead[0] = 0;

            int minprice = prices[0], maxprofit = 0;

            for (int i = 1; i < len; i++)
            {
                minprice = Math.Min(prices[i - 1], minprice);
                maxprofit = Math.Max(maxprofit, prices[i] - minprice);
                maxFromHead[i] = maxprofit;
            }

            int maxprice = prices[len - 1];
            int res = maxFromHead[len - 1];
            maxprofit = 0;

            for (int i = len - 2; i >= 0; i--)
            {
                maxprice = Math.Max(maxprice, prices[i + 1]);
                maxprofit = Math.Max(maxprofit, maxprice - prices[i]);
                if (res < maxFromHead[i] + maxprofit)
                    res = maxFromHead[i] + maxprofit;
            }

            return res;
        }
    }
}