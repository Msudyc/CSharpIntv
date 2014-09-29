/*
Given two words (start and end), and a dictionary, find 
all shortest transformation sequence(s) from start to end,
such that: 

1.Only one letter can be changed at a time
2.Each intermediate word must exist in the dictionary

For example, 

Given:
start = "hit"
end = "cog"
dict = ["hot","dot","dog","lot","log"]

Return
  [
    ["hit","hot","dot","dog","cog"],
    ["hit","hot","lot","log","cog"]
  ]

Note:

.All words have the same length.
.All words contain only lowercase alphabetic characters.

class Solution {
public:
    List<List<string>> findLadders(string start, string end, unordered_set<string> &dict) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex127
    {
        public static List<List<string>> FindLadders(string start, string end, HashSet<string> dict)
        {
            List<List<string>> soln = new List<List<string>>();
            bool exist = false;
            HashSet<string> chk = new HashSet<string>();
            Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
            Queue<string> level = new Queue<string>();
            level.Enqueue(start);
            chk.Add(start);
            dict.Add(end);

            while (level.Count != 0)
            {
                HashSet<string> toBuild = new HashSet<string>();
                Queue<string> nextLevel = new Queue<string>();

                while (level.Count != 0)
                {
                    List<string> neighbor = new List<string>();
                    string wd = level.Dequeue();
                    char[] word = wd.ToCharArray();

                    for (int i = 0; i < start.Length; i++)
                    {
                        char ch = word[i];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            word[i] = c;
                            string nword = new string(word);
                            if (dict.Contains(nword) && !chk.Contains(nword))
                            {
                                if (toBuild.Add(nword))
                                    nextLevel.Enqueue(nword);
                                neighbor.Add(nword);
                            }

                            exist = exist || nword == end;
                        }

                        word[i] = ch;
                    }

                    graph.Add(wd, neighbor);
                }

                foreach (string s in toBuild)
                    chk.Add(s);
                if (exist)
                    break;
                level = nextLevel;
            }

            if (exist)
                DFS(start, end, graph, new List<string>(), soln);

            return soln;
        }

        private static void DFS(
            string start, 
            string end, 
            Dictionary<string, List<string>> graph, 
            List<string> oneSoln, 
            List<List<string>> soln)
        {
            if (start == end)
            {
                List<string> oneSolution = new List<string>(oneSoln);
                oneSolution.Add(start);
                soln.Add(oneSolution);
                return;
            }

            if (graph.ContainsKey(start))
            {
                oneSoln.Add(start);
                List<string> alist = graph[start];
                for (int i = 0; i < alist.Count; i++)
                    DFS(alist[i], end, graph, oneSoln, soln);

                oneSoln.Remove(start);
            }
        }

        public static List<List<string>> FindLaddersBFS(string start, string end, HashSet<string> dict)
        {
            dict.Add(end);
            HashSet<string> visited = new HashSet<string>();
            List<List<string>> result = new List<List<string>>();
            Queue<Tuple<string, List<string>>> queue = new Queue<Tuple<string, List<string>>>();
            queue.Enqueue(new Tuple<string, List<string>>(start, new List<string>()));

            while (queue.Count > 0)
            {
                Tuple<string, List<string>> temp = queue.Dequeue();
                visited.Add(temp.Item1);
                if (temp.Item1 == end)
                {
                    temp.Item2.Add(end);
                    if (result.Count == 0 || result[0].Count == temp.Item2.Count)
                        result.Add(new List<string>(temp.Item2));
                    else
                        if (result[0].Count > temp.Item2.Count)
                        {
                            result.RemoveAt(0);
                            result.Add(new List<string>(temp.Item2));
                        }
                }
                else
                {
                    List<string> words = GetAllWords(temp.Item1, dict, visited);
                    foreach (string w in words)
                    {
                        List<string> l = new List<string>(temp.Item2);
                        l.Add(temp.Item1);
                        Tuple<string, List<string>> item = new Tuple<string, List<string>>(w, l);
                        queue.Enqueue(item);
                    }
                }
            }

            return result;
        }

        private static List<string> GetAllWords(
            string word, HashSet<string> dict, HashSet<string> visited)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                char[] str = word.ToCharArray();
                for (int j = 0; j < 26; j++)
                {
                    char c = (char)(j + 'a');
                    if (c != word[i])
                    {
                        str[i] = c;
                        string stt = new string(str);
                        if (dict.Contains(stt) && !visited.Contains(stt))
                            result.Add(stt);
                    }
                }
            }

            return result;
        }
    }
}