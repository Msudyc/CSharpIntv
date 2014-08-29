/* Question 18.4
 
Write a method to count the number of 2s that appear in all the numbers between 0 and n (inclusive).
Example;
Input: 25
Output; 9 (2, 12,20,21,22,23,24,25. Note that 22 counts for two 2s.)
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q04
    {
        public static int Count2sInRange(int num)
        {
            int count = 0;
            int len = num.ToString().Length;
            for (int digit = 0; digit < len; digit++)
                count += Count2sInRangeAtDigit(num, digit);
            return count;
        }

        private static int Count2sInRangeAtDigit(int num, int d)
        {
            int powerOf10 = (int)Math.Pow(10, d);
            int nextPowerOf10 = powerOf10 * 10;
            int right = num % powerOf10;

            int roundDown = num - num % nextPowerOf10;
            int roundUp = roundDown + nextPowerOf10;

            int digit = (num / powerOf10) % 10;
            if (digit < 2)
                return roundDown / 10;
            else if (digit == 2)
                return roundDown / 10 + right + 1;
            else
                return roundUp / 10;
        }
    }
}
