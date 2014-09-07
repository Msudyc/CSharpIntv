/*
Given n points on a 2D plane, find the maximum number of 
points that lie on the same straight line.

class Solution {
public:
    int maxPoints(List<Point> &points) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex149
    {
        public static int MaxPoints(List<Point> points)
        {
            if(points.Count < 3) 
                return points.Count;

            int max = 0;
            for(int i = 0; i < points.Count - 1; i++)
            {
                for(int j = i + 1; j < points.Count; j++)
                {
                    int sign = 0, a = 0, b = 0, c = 0;
                    if(points[i].X == points[j].X) 
                        sign=1;
                    else
                    {
                        a = points[j].X - points[i].X;
                        b = points[j].Y - points[i].Y;
                        c = a * points[i].Y - b * points[i].X;
                    }
                
                    int len=0;
                    for(int k = 0; k < points.Count; k++)
                        if((0 == sign && a * points[k].Y == c + b * points[k].X) || 
                            (1 == sign && points[k].X == points[j].X)) 
                            len++;

                    if(len > max) 
                        max = len;
                }
            }
        
            return max;
        }
    }
}