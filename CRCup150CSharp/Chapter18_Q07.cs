/* Question 18.7
 
Given a list of words, write a program to find the longest word made of other words in the list.
Example:
Input: cat, banana, dog, nana, walk, walker, dogwalker
Output: dogwalker
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q07
    {
        public static string PrintLongestWord(string[] arr)
        {
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            foreach(string s in arr)
                map.Add(s, true);

            Array.Sort(arr, new LenComparer());
            foreach (string s in arr)
                if (CanBuildWord(s, true, map))
                    return s;

            return string.Empty;
        }

        private static bool CanBuildWord(string str, bool original, Dictionary<string, bool> map)
        {
            if (map.ContainsKey(str) && !original)
                return map[str];

            for (int i = 1; i < str.Length; i++)
            {
                string left = str.Substring(0, i);
                string right = str.Substring(i);
                if (map.ContainsKey(left) && 
                    map[left] == true &&
                    CanBuildWord(right, false, map))
                    return true;
            }

            map.Add(str, false);
            return false;
        }

        public class LenComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return y.Length - x.Length;
            }
        }
    }
}
