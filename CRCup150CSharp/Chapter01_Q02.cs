/* Question 1.2
 
 Implement a function void Reverse(string str) which reverses a null terminated string
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q02
    {
        public static void Reverse(char[] str)
        {
            int len = str.Length;
            int i = 0;
            while (i < len/2)
            {
                char t = str[i];
                str[i] = str[len - i - 1];
                str[len - i - 1] = t;
                i++;
            }
        }

        public static void Reverse2(char[] str)
        {
            int len = str.Length;
            for(int i=0; i<len/2; i++)
            {
                char t = str[i];
                str[i] = str[len - i - 1];
                str[len - i - 1] = t;
            }
        }
    }
}
