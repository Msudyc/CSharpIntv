/* Question 1.4
 
 Write a method to replace all spaces in a string with '%20'. 
 You may assume that the string has sufficient space at the end of 
 the string to hold the additional characters, and that you are given
 the "true" length of the string. please use character array.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q04
    {
        public static void ReplaceSpaces(char[] str, int length)
        {
            int ns = 0;
            for (int i = 0; i < length; i++)
                if (str[i] == ' ')
                    ns++;
            if (ns == 0) return;
            int total = length + 2 * ns;
            int p = length - 1;
            int q = total - 1;
            while (p >= 0)
            {
                if (str[p] != ' ')
                    str[q--] = str[p--];
                else
                {
                    str[q--] = '0';
                    str[q--] = '2';
                    str[q--] = '%';
                    p--;
                }
            }
        }
    }
}
