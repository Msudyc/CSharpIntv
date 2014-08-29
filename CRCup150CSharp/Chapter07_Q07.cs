/* Question 7.7
 
Design an algorithm to find the kth number such that the only prime factors are 3, 5, and 7. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q07
    {
        public static int GetKthMagicNumber(int k)
        {
            if (k < 0)
                return 0;

            int val = 0;
            Queue<int> queue3 = new Queue<int>();
            Queue<int> queue5 = new Queue<int>();
            Queue<int> queue7 = new Queue<int>();
            queue3.Enqueue(1);

            for (int i = 0; i <= k; i++)
            {
                int v3 = queue3.Count > 0 ? queue3.Peek() : int.MaxValue;
                int v5 = queue5.Count > 0 ? queue5.Peek() : int.MaxValue;
                int v7 = queue7.Count > 0 ? queue7.Peek() : int.MaxValue;

                val = Math.Min(v3, Math.Min(v5, v7));
                if (val == v3)
                {
                    queue3.Dequeue();
                    queue3.Enqueue(3 * val);
                    queue5.Enqueue(5 * val);
                    
                }
                else if (val == v5)
                {
                    queue5.Dequeue();
                    queue5.Enqueue(5 * val);
                }
                else if (val == v7)
                    queue7.Dequeue();

                queue7.Enqueue(7 * val);
            }

            return val;
        }
    }
}
