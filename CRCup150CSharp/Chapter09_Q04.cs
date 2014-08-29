/* Question 9.4
 
Write a method to return all subsets of a set. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q04
    {
        public static List<List<int>> GetAllSubSets(int[] set)
        {
            List<List<int>> result = new List<List<int>>();
            result.Add(new List<int>());

            for (int i = 0; i < set.Length; i++)
            {
                int size = result.Count;
                for (int j = 0; j < size; j++)
                {
                    List<int> newList = new List<int>(result[j]);
                    newList.Add(set[i]);
                    result.Add(newList);
                }
            }

            return result;
        }
    }
}
