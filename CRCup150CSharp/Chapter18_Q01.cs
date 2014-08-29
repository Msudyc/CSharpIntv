/* Question 18.1
 
Write a function that adds two numbers. You should not use + or any arithmetic operators. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q01
    {
        public static int Add(int a, int b)
        {
            if (b == 0) return a;
            int sum = a ^ b; // add without carry
            int carry = (a & b) << 1; // carry but not add
            return Add(sum, carry);
        }
    }
}
