/*
Given a set of non-overlapping intervals, insert a new 
interval into the intervals (merge if necessary).

You may assume that the intervals were initially sorted 
according to their start times.

Example 1:
 Given intervals [1,3],[6,9], insert and merge [2,5] in 
 as [1,5],[6,9]. 

Example 2:
 Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and 
 merge [4,9] in as [1,2],[3,10],[12,16]. 

This is because the new interval [4,9] overlaps 
 with [3,5],[6,7],[8,10]. 

class Solution {
public:
    List<Interval> insert(List<Interval> &intervals, Interval newInterval) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex056
    {
        public static List<Interval> Insert(List<Interval> intervals, Interval newInterval)
        {
            List<Interval> v = new List<Interval>();
            int i = 0, n = intervals.Count;
            while (i < n && newInterval.Start > intervals[i].End)
                v.Add(intervals[i++]);

            while (i < n && newInterval.End >= intervals[i].Start)
            {
                newInterval.End = Math.Max(newInterval.End, intervals[i].End);
                newInterval.Start = Math.Min(newInterval.Start, intervals[i].Start);
                i++;
            }

            v.Add(newInterval);
            while (i < n) 
                v.Add(intervals[i++]);
            return v;
        }
    }
}