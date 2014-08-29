using System.Collections.Generic;

namespace CRCup150CSharp
{
    public class ListNode<T>
    {
        public ListNode(T data)
        {
            this.Data = data;
        }

        public ListNode<T> Next { get; set; }

        public T Data { get; set; }        
    }

    public class TreeNode<T>
    {
        public TreeNode(T data)
        {
            this.Data = data;
        }

        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Parent { get; set; }

        public T Data { get; set; }
    }

    public class GraphNode<T>
    {
        public GraphNode(T data)
        {
            this.Data = data;
            this.Neighbors = new List<GraphNode<T>>();
        }

        public List<GraphNode<T>> Neighbors { get; set; }

        public T Data { get; set; }
    }

#region Trie
    public class Trie
    {
        private TrieNode root;
        
        public Trie(IEnumerable<string> list)
        {
            this.root = new TrieNode();
            foreach (string s in list)
                this.root.AddWord(s);
        }

        public bool Contains(string prefix, bool exact)
        {
            TrieNode lastNode = this.root;
            for (int i = 0; i < prefix.Length; i++)
            {
                lastNode = lastNode.GetChild(prefix[i]);
                if (lastNode == null)
                    return false;
            }

            return !exact || lastNode.Terminates;
        }

        public bool Contains(string prefix)
        {
            return this.Contains(prefix, false);
        }
    }

    public class TrieNode
    {
        private List<TrieNode> children; 

        public TrieNode()
        {
            this.children = new List<TrieNode>();
        }

        public TrieNode(char c) : this()
        {
            this.Character = c;
        }

        public bool Terminates { get; private set; }

        public char Character { get; private set; }

        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return;

            TrieNode child;
            char firstChar = word[0];
            TrieNode t = this.GetChild(firstChar);
            if (t == null)
            {
                child = new TrieNode(firstChar);
                this.children.Add(child);
            }
            else
                child = t;

            if (word.Length > 1)
                child.AddWord(word.Substring(1));
            else
                child.Terminates = true;
        }

        public TrieNode GetChild(char c)
        {
            foreach (TrieNode t in this.children)
                if (t.Character == c)
                    return t;
            return null;
        }
    }
#endregion
}