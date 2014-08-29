/* Question 18.5
 
You have a large text file containing words. Given any two words, find the shortest distance 
(in terms of number of words) bwtween them in the file. Can you make the searching operation 
in O(1) time? What about the space comlexity for you solution? 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q05
    {
        public static int Shortest(string[] words, string word1, string word2)
        {
            int min = int.MaxValue;
            int lastPWord1 = -1;
            int lastPWord2 = -1;

            for (int i = 0; i < words.Length; i++)
            {
                string cur = words[i];
                if (cur == word1)
                {
                    lastPWord1 = i;
                    int dist = lastPWord1 - lastPWord2;
                    if (lastPWord2 >= 0 && min > dist)
                        min = dist;
                }
                else if (cur == word2)
                {
                    lastPWord2 = i;
                    int dist = lastPWord2 - lastPWord1;
                    if (lastPWord1 >= 0 && min > dist)
                        min = dist;
                }
            }

            return min;
        }
    }
}
