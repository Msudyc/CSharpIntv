/* Question 8.10
 
Design and implement a hash table which uses chaining (linked list) to handle collisions. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q10
    {
        public class Hash<K, V>
        {
            private const int MaxSize = 10;
            private List<LinkedList<Cell<K, V>>> items = new List<LinkedList<Cell<K, V>>>();
            public int HashCodeOfKey(K key)
            {
                throw new NotImplementedException();
            }

            public void Put(K key, V value)
            {
                int x = this.HashCodeOfKey(key);
                if(items[x] == null)
                    items[x] = new LinkedList<Cell<K,V>>();
                LinkedList<Cell<K, V>> collided = items[x];
                foreach (Cell<K, V> c in collided)
                    if (c.Key.Equals(key))
                    {
                        collided.Remove(c);
                        break;
                    }

                Cell<K, V> cell = new Cell<K, V>()
                {
                    Key = key,
                    Value = value
                };
                collided.AddLast(cell);
            }

            public V Get(K key)
            {
                int x = this.HashCodeOfKey(key);
                if (items[x] == null)
                    return default(V);
                LinkedList<Cell<K, V>> collided = items[x];
                foreach (Cell<K, V> c in collided)
                    if (c.Key.Equals(key))
                    {
                        return c.Value;
                    }
                return default(V);
            }
        }

        public class Cell<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }
    }
}
