/* Question 18.9
 
Numbers are randomly generated and passed to a method. Write a program to find and 
maintain the median value as new values are generated. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter18_Q09
    {
        private SortedSet<int> maxHeap = new SortedSet<int>();
        private SortedSet<int> minHeap = new SortedSet<int>();

        public void AddNewNumber(int num)
        {
            if (maxHeap.Count == minHeap.Count)
            {
                if (minHeap.Count != 0 && num > minHeap.Min)
                {
                    int min = minHeap.Min;
                    minHeap.Remove(min);
                    maxHeap.Add(min);
                    minHeap.Add(num);
                }
                else
                    maxHeap.Add(num);
            }
            else
            {
                if (num < maxHeap.Max)
                {
                    int max = maxHeap.Max;
                    maxHeap.Remove(max);
                    minHeap.Add(max);
                    maxHeap.Add(num);
                }
                else
                    minHeap.Add(num);
            }
        }

        public double GetMedian()
        {
            if (this.maxHeap.Count == 0)
                return 0;
            if (this.maxHeap.Count == this.minHeap.Count)
                return ((double)this.maxHeap.Max + (double)this.minHeap.Min) / 2;
            else
                return this.maxHeap.Max;
        }
    }
}
