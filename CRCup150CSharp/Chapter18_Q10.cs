/* Question 18.10
 
Given two words of equal length that are in a dictionary, write a method to transform one 
word into another word by changing only one letter at a time. The new word you get in each
step must be in the dictionary. 
Example:
Input: DAMP, LIKE
Output: DAMP->LAMP->LIMP->LIME-LIKE
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q10
    {
        public static List<string> Transform(string start, string stop, HashSet<string> dict)
        {
            start = start.ToUpper();
            stop = stop.ToUpper();
            Queue<string> actionQueue = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            Dictionary<string, string> backtrack = new Dictionary<string, string>();

            actionQueue.Enqueue(start);
            visited.Add(start);

            while (actionQueue.Count != 0)
            {
                string w = actionQueue.Dequeue();
                List<string> all = GetOneEditWords(w);
                foreach (string v in all)
                {
                    if (v == stop)
                    {
                        List<string> result = new List<string>();
                        result.Add(v);
                        while (w != null)
                        {
                            result.Add(w);
                            if (!backtrack.ContainsKey(w))
                                break;
                            w = backtrack[w];
                        }

                        return result;
                    }

                    if (dict.Contains(v) && !visited.Contains(v))
                    {
                        actionQueue.Enqueue(v);
                        visited.Add(v);
                        backtrack.Add(v, w);
                    }
                }
            }

            return null;
        }

        private static List<string> GetOneEditWords(string word)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                char[] arr = word.ToCharArray();
                for (char c = 'A'; c <= 'Z'; c++)
                    if (c != word[i])
                    {
                        arr[i] = c;
                        result.Add(new string(arr));
                    }
            }

            return result;
        }
    }
}
