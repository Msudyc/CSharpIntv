/* Question 7.4
 
Write methods to implement the multiply, subtract, and divide operations for integers. 
Use only the add operation. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q04
    {
        public static int Minus(int a, int b)
        {
            return a + Negate(b);
        }

        public static int Multiply(int a, int b)
        {
            if (a < b)
                return Multiply(b, a);

            int sum = 0;
            for (int i = Math.Abs(b); i > 0; i--)
                sum += a;

            if (b < 0)
                sum = Negate(sum);

            return sum;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException();

            int absa = Math.Abs(a);
            int absb = Math.Abs(b);

            int product = 0;
            int x = 0;

            while (product + absb <= absa)
            {
                product += absb;
                x++;
            }

            if ((a < 0) && (b < 0) || (a > 0) && (b > 0))
                return x;
            else
                return Negate(x);
        }

        private static int Negate(int a)
        {
            int neg = 0;
            int d = a < 0 ? 1 : -1;
            while (a != 0)
            {
                neg += d;
                a += d;
            }

            return neg;
        }
    }
}
