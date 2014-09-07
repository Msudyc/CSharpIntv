/*
Design and implement a data structure for Least Recently 
Used (LRU) cache. It should support the following operations:
get and set. 

get(key) - Get the value (will always be positive) of the
key if the key exists in the cache, otherwise return -1.

set(key, value) - Set or insert the value if the key is 
not already present. When the cache reached its capacity,
it should invalidate the least recently used item before
inserting a new item. 

class LRUCache{
public:
    LRUCache(int capacity) {
        
    }
    
    int get(int key) {
        
    }
    
    void set(int key, int value) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex146
    {
        public class Ex146LRUCache
        {
            private int size;
            private LinkedList<Tuple<int, int>> cacheList = new LinkedList<Tuple<int, int>>();
            private Dictionary<int, LinkedListNode<Tuple<int, int>>> map = 
                new Dictionary<int, LinkedListNode<Tuple<int, int>>>();

            public Ex146LRUCache(int capacity)
            {
                this.size = capacity;
            }

            public int Get(int key)
            {
                if (!this.map.ContainsKey(key)) 
                    return -1;

                LinkedListNode<Tuple<int, int>> node = this.map[key];
                this.cacheList.Remove(node); // O(1) for removing node
                this.cacheList.AddFirst(node); // O(1)
                this.map[key] = this.cacheList.First;
                
                return node.Value.Item2;
            }

            public void Set(int key, int value)
            {
                if (!this.map.ContainsKey(key))
                {
                    this.CheckCapacity();
                    this.cacheList.AddFirst(new Tuple<int, int>(key, value));
                    this.map.Add(key, this.cacheList.First);                    
                }
                else
                {
                    LinkedListNode<Tuple<int, int>> node = this.map[key];
                    this.cacheList.Remove(node); // O(1)
                    this.cacheList.AddFirst(node); // O(1)
                    this.map[key] = this.cacheList.First;
                }
            }

            private void CheckCapacity()
            {
                if (this.map.Count == this.size)
                {
                    LinkedListNode<Tuple<int, int>> node = this.cacheList.Last;
                    this.map.Remove(node.Value.Item1);
                    this.cacheList.RemoveLast();
                }
            }
        }
    }
}