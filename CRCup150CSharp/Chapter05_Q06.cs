/* Question 5.6
 
Write a program to swap odd and even bits in an integer with as few instructions as possible 
(e.g., bit 0 nd 1 are swapped, bit 2 and 3 are swapped, and so on). 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter05_Q06
    {
        public static uint SwapOddEvenBits(uint x)
        {
            return (((x & 0xaaaaaaaa) >> 1) | ((x & 0x55555555) << 1));
        }
    }
}
