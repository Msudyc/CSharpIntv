/* Question 11.8
 
Imagine you are reading in a stream of integers. Periodically, you wish to be able to look up 
the rank of a number x (the number of values less that or equal to x). Implement the data structures
and algorithms to support these operations. That is, implement the method track(int x), which is 
called when each number is generated, and the method getRankOfNumber(int x), which returns the number
of values less than or equal to x (not including x itself).
Example:
Stream: 5, 1, 4, 4, 5, 9, 7, 13, 3
getRankOfNumber(1) = 0
getRankOfNumber(3) = 1
getRankOfNumber(4) = 3
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter11_Q08
    {
        private static RankNode root = null;

        public static void Track(int num)
        {
            if (root == null)
                root = new RankNode(num);
            else
                root.Insert(num);
        }

        public static int GetRankOfNumber(int num)
        {
            if (root == null)
                return -1;

            return root.GetRank(num);
        }

        private class RankNode
        {
            public int LeftSize { get; set; }
            public RankNode Left { get; set; }
            public RankNode Right { get; set; }
            public int Data { get; set; }

            public RankNode(int data)
            {
                this.Data = data;
            }

            public void Insert(int d)
            {
                if (d <= this.Data)
                {
                    if (this.Left != null)
                        this.Left.Insert(d);
                    else
                        this.Left = new RankNode(d);
                    this.LeftSize++;
                }
                else
                {
                    if (this.Right != null)
                        this.Right.Insert(d);
                    else
                        this.Right = new RankNode(d);
                }
            }

            public int GetRank(int d)
            {
                if (d == this.Data)
                    return this.LeftSize;

                else if (d < this.Data)
                {
                    if (this.Left == null)
                        return -1;
                    else
                        return this.Left.GetRank(d);
                }
                else
                {
                    int rightRank = Right == null ? -1 : this.Right.GetRank(d);
                    if (rightRank == -1)
                        return -1;
                    else
                        return this.LeftSize + 1 + rightRank;
                }
            }
        }
    }
}
