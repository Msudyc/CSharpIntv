/* Question 17.12
 
Design an algorithm to find all pairs of integers within an array which sum to a specified value. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q12
    {
        public static List<Tuple<int, int>> GetPairSums1(int[] array, int sum)
        {
            Dictionary<int, bool> map = new Dictionary<int, bool>();
            List<Tuple<int, int>> result = new List<Tuple<int,int>>();
            foreach(int a in array)
                map.Add(a, true);

            foreach(int a in array)
                if (map.ContainsKey(sum - a))
                {
                    result.Add(new Tuple<int, int>(a, sum - a));
                    map.Remove(a);
                }

            return result;
        }

        public static List<Tuple<int, int>> GetPairSums2(int[] array, int sum)
        {
            List<Tuple<int, int>> result = new List<Tuple<int,int>>();
            Array.Sort(array);
            int first = 0;
            int last = array.Length - 1;
            while(first < last)
            {
                int s = array[first] + array[last];
                if(s == sum)
                    result.Add(new Tuple<int,int>(array[first++], array[last--]));
                else if (s < sum) first++;
                else last --;
            }

            return result;
        }
    }
}
