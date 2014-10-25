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

        public static int MaxPoints1(List<Point> points)
        {
            Dictionary<Line, HashSet<Point>> map = new Dictionary<Line, HashSet<Point>>(new Comparer());
            for (int i = 0; i < points.Count - 1; i++)
                for (int j = i + 1; j < points.Count; j++)
                {
                    Line line = Line.GetLine(points[i], points[j]);
                    if (!map.ContainsKey(line))
                        map.Add(line, new HashSet<Point>());
                    if (!map[line].Contains(points[i]))
                        map[line].Add(points[i]);
                    if (!map[line].Contains(points[j]))
                        map[line].Add(points[j]);
                }

            int max = 0;
            foreach (Line l in map.Keys)
            {
                if (map[l].Count > max)
                    max = map[l].Count;
            }

            return max;
        }

        public class Line
        {
            public double Slobe { get; set; }
            public double Y { get; set; }
            public bool Strait { get; set; }

            public static Line GetLine(Point l1, Point l2)
            {
                if (l1.X == l2.X)
                    return new Line()
                    {
                        Slobe = int.MaxValue,
                        Y = l1.Y,
                        Strait = true
                    };

                double k = (l2.Y - l1.Y) / (double)(l2.X - l1.X);
                double y = (l1.Y * l2.X - l2.Y * l1.X) / (double)(l2.X - l1.X);
                return new Line()
                {
                    Slobe = k,
                    Y = y,
                    Strait = false
                };
            }
        }

        public class Comparer : IEqualityComparer<Line>
        {
            public bool Equals(Line x, Line y)
            {
                return x.Strait == y.Strait && x.Slobe == y.Slobe && x.Y == y.Y;
            }

            public int GetHashCode(Line obj)
            {
                return obj.Slobe.GetHashCode() ^ obj.Y.GetHashCode();
            }
        }
    }
}