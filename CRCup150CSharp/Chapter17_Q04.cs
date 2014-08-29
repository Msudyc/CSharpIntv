/* Question 17.4
 
Write a method which find the maximum of two numbers. You should not use if-else or any 
other comparison operator. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q04
    {
        public static int GetMax(int a, int b)
        {
            int c = a - b;
            int sa = Sign(a);
            int sb = Sign(b);
            int sc = Sign(c);

            int useSignA = sa ^ sb;
            int useSignC = Flip(sa ^ sb);
            int k = useSignA * sa + useSignC * sc;
            int q = Flip(k);
            return a * k + b * q;
        }

        private static int Flip(int bit)
        {
            return 1 ^ bit;
        }

        private static int Sign(int a)
        {
            return Flip((a >> 31) & 0x1);
        }
    }
}
