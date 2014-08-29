/* Question 17.9
 
Design a method to find the frequency of occurrences of any given word in a book. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q09
    {
        private static Dictionary<string, int> map = new Dictionary<string, int>();

        public static void Setup(string[] book)
        {
            foreach (string word in book)
            {
                if (!map.ContainsKey(word.ToLower()))
                    map.Add(word.ToLower(), 0);
                map[word.ToLower()]++;
            }
        }

        public static int GetFrequency(string word)
        {
            if (map.ContainsKey(word.ToLower()))
                return map[word.ToLower()];
            else
                return 0;
        }
    }
}
