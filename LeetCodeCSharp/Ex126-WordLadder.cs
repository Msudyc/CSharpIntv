/*
Given two words (start and end), and a dictionary, find 
the length of shortest transformation sequence from start
to end, such that: 

1.Only one letter can be changed at a time
2.Each intermediate word must exist in the dictionary

For example, 

Given:
start = "hit"
end = "cog"
dict = ["hot","dot","dog","lot","log"]

As one shortest transformation is "hit" . "hot" . "dot" .
"dog" . "cog", return its length 5. 

Note:

.Return 0 if there is no such transformation sequence.
.All words have the same length.
.All words contain only lowercase alphabetic characters.

class Solution {
public:
    int ladderLength(string start, string end, unordered_set<string> &dict) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex126
    {
        public static int LadderLength(string start, string end, HashSet<string> dict)
        {
            Queue<Tuple<string, int>> q = new Queue<Tuple<string,int>>();
            HashSet<string> visited = new HashSet<string>();
            q.Enqueue(new Tuple<string, int>(start, 1));
            visited.Add(start);

            while (q.Count != 0)
            {
                string curStr = q.Peek().Item1;
                int curStep = q.Peek().Item2;
                q.Dequeue();

                for (int i = 0; i < curStr.Length; i++)
                {
                    char[] tmp = curStr.ToCharArray();
                    for (int j = 0; j < 26; j++)
                    {
                        tmp[i] = (char)(j + 'a');
                        string s = new string(tmp);
                        if (new string(tmp) == end) 
                            return curStep + 1;

                        if (!visited.Contains(s) && dict.Contains(s))
                        {
                            q.Enqueue(new Tuple<string, int>(s, curStep + 1));
                            visited.Add(s);
                        }
                    }
                }
            }

            return 0;
        }
    }
}