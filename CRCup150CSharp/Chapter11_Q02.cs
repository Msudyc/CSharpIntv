/* Question 11.2
 
Write a method to sort an array of strings so that all the anagrams are next to each other. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q02
    {
        public static void Sort(string[] array)
        {
            Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>();
            foreach (string s in array)
            {
                char[] arr = s.ToCharArray();
                Array.Sort(arr);
                string ss = new string(arr);
                if (!hash.ContainsKey(ss))
                    hash.Add(ss, new List<string>());
                hash[ss].Add(s);
            }

            int index = 0;
            foreach (string ss in hash.Keys)
            {
                List<string> v = hash[ss];
                foreach (string s in v)
                    array[index++] = s;
            }
        }
    }
}
