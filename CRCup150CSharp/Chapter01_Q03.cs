/* Question 1.3
 
 Given two strings, write a method to decide if one is a permutation of the other.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q03
    {
        public static bool Permutation(string s, string t)
        {
            int[] map = new int[256];
            if (s.Length != t.Length)
                return false;
            foreach (char c in s)
                map[c]++;
            foreach (char c in t)
                map[c]--;
            for(int i=0; i<map.Length; i++)
                if (map[i] != 0)
                    return false;
            return true;
        }

        public static bool Permutation2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            return Sort(s) == Sort(t);
        }

        private static string Sort(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}
