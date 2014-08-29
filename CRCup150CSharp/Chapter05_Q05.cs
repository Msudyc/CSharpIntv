/* Question 5.5
 
Write a function to determine the number of bits required to convert 
integer A to integer B.
Example
Input: 31, 14
Output: 2
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter05_Q05
    {
        public static int BitSwapRequired(int a, int b)
        {
            int count = 0;
            // c & (c-1) clear LSB
            for (int c = a ^ b; c != 0; c = c & (c - 1))
                count++;

            return count;
        }
    }
}
