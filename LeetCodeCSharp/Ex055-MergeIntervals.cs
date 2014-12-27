/*
Given a collection of intervals, merge all overlapping intervals.

For example,
 Given [1,3],[2,6],[8,10],[15,18],
 return [1,6],[8,10],[15,18]. 

 Definition for an interval.
  struct Interval {
      int start;
      int end;
      Interval() : start(0), end(0) {}
      Interval(int s, int e) : start(s), end(e) {}
  };

class Solution {
public:
    List<Interval> merge(List<Interval> &intervals) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex055
    {
        public static List<Interval> Merge(List<Interval> intervals)
        {
            List<Interval> res = new List<Interval>();
            intervals.Sort(IsLower);
            int i = 0;
            while (i < intervals.Count)
            {
                res.Add(intervals[i]);
                i++;
                while (i < intervals.Count && intervals[i].Start <= res[res.Count - 1].End)
                {
                    res[res.Count - 1].End = Math.Max(res[res.Count - 1].End, intervals[i].End);
                    i++;
                }
            }

            return res;
        }

        public static List<Interval> Merge2(List<Interval> intervals)
        {
            List<Interval> res = new List<Interval>();
            if (intervals.Count == 0)
                return res;

            intervals.Sort(IsLower);
            res.Add(intervals[0]);
            for (int i = 1; i < intervals.Count; i++)
            {
                Interval cur = intervals[i];
                Interval last = res[res.Count - 1];
                if (last.End >= cur.Start)
                    last.End = Math.Max(last.End, cur.End);
                else
                    res.Add(cur);
            }

            return res;
        }

        private static int IsLower(Interval v1, Interval v2)
        {
            return v1.Start - v2.Start;
        }
    }
}