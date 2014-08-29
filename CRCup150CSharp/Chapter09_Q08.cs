/* Question 9.8
 
Given an infinite number of quarters (25 cents), dimes (10 cents), nickels (5 cents) 
and pennies (1 cent), write code to calculate the number of ways of representing n cents. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q08
    {
        public static int MakeChange(int n)
        {
            return MakeChange(n, 25);
        }

        private static int MakeChange(int n, int denom)
        {
            int nextDenom = 0;
            switch (denom)
            {
                case 25:
                    nextDenom = 10;
                    break;
                case 10:
                    nextDenom = 5;
                    break;
                case 5:
                    nextDenom = 1;
                    break;
                case 1:
                    return 1;
            }

            int ways = 0;
            for (int i = 0; i * denom <= n; i++)
                ways += MakeChange(n - i * denom, nextDenom);

            return ways;
        }
    }
}
