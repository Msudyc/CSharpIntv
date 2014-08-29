/* Question 17.3
 
Write an algorithm which computes the number of trailing zeros in the n factorial. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q03
    {
        public static int CountFactZeros(int num)
        {
            int count = 0;
            if (num < 0)
                return -1;
            for (int i = 5; num / i > 0; i *= 5)
                count += num / i;
            return count;
        }
    }
}
