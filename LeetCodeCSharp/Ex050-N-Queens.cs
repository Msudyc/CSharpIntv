/*
The n-queens puzzle is the problem of placing n queens on 
an n×n chessboard such that no two queens attack each other.

Given an integer n, return all distinct solutions to the 
n-queens puzzle.

Each solution contains a distinct board configuration of 
the n-queens' placement, where 'Q' and '.' both indicate 
a queen and an empty space respectively.

For example,
 There exist two distinct solutions to the 4-queens puzzle:
[
 [".Q..",  // Solution 1
  "...Q",
  "Q...",
  "..Q."],

 ["..Q.",  // Solution 2
  "Q...",
  "...Q",
  ".Q.."]
]

class Solution {
public:
    List<List<string> > solveNQueens(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Ex050
    {
        public static List<List<string>> SolveNQueens(int n)
        {
            List<List<string>> ret = new List<List<string>>();
            List<int[]> res = new List<int[]>();
            int[] result = new int[n];
            DFS(res, result, 0);
            Fill(ret, res);
            return ret;
        }

        private static void DFS(List<int[]> res, int[] result, int cur)
        {
            if (cur == result.Length)
                res.Add(result);

            for (int i = 0; i < result.Length; i++)
            {
                if (IsValid(result, cur, i))
                {
                    result[cur] = i;
                    DFS(res, result, cur + 1);
                }
            }
        }

        private static void Fill(List<List<string>> ret, List<int[]> res)
        {
            foreach (int[] result in res)
            {
                List<string> r = new List<string>();
                for (int i = 0; i < result.Length; i++)
                {
                    string str = new string('.', result.Length);
                    char[] arr = str.ToCharArray();
                    // ith row queue is on result[i] col
                    arr[result[i]] = 'Q';
                    r.Add(new string(arr));
                }

                ret.Add(r);
            }
        }

        private static bool IsValid(int[] result, int cur, int Val)
        {
            for (int i = 0; i < cur; i++)
            {
                if (Val == result[i]) return false;
                else if (Math.Abs(Val - result[i]) == Math.Abs(i - cur))
                    return false;
            }

            return true;
        }
    }
}