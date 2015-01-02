/*
Design and implement a TwoSum class. It should support 
the following operations: add and find.

add - Add the number to an internal data structure.
find - Find if there exists any pair of numbers which
       sum is equal to the value. 

For example,

add(1); add(3); add(5);
find(4) -> true
find(7) -> false

class TwoSum {
public:
	void add(int number) {
	    
	}

	bool find(int value) {
	    
	}
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex170
    {
        public class TwoSum
        {
            private Dictionary<int, int> map = new Dictionary<int, int>();

            public void Add(int number)
            {
                if (!this.map.ContainsKey(number))
                    map.Add(number, 0);

                this.map[number]++;
            }

            public bool Find(int value)
            {
                foreach (int key in this.map.Keys)
                {
                    int another = value - key;
                    if (another == key && map[key] > 1)
                        return true;
                    else if (another != key && map.ContainsKey(another))
                        return true;
                }

                return false;
            }
        }
    }
}