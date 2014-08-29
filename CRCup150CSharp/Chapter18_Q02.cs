/* Question 18.2
 
Write a method to shuffle a deck of cards. It must be a perfect shuffle - in other words 
each of the 52! permutations of the deck has to be equally likely. Assume that you are 
given a random number generator which is perfect. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q02
    {
        public static void ShuffleArray(int[] cards)
        {
            int temp, index;
            for (int i = 0; i < cards.Length; i++)
            {
                index = new Random().Next(cards.Length - i) + i;
                temp = cards[i];
                cards[i] = cards[index];
                cards[index] = temp;
            }
        }
    }
}
