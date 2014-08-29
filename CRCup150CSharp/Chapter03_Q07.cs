/* Question 3.7
 
An animal shelter holds only dogs and cats, and operates on a strictly "first in, first out" basis.
People must adopt either the oldest (based on arrival time) of all animals at the shelter, or they can 
select whether they would perfer a dog or a cat (and will receive the oldest animal of that type). They
cannot select which specific animal they would like. Create the data structures to maintain this system
and implement operations such as enqueue, dequeueAny, dequeueDog, dequeueCat. You may use the built-in
LinkedList data structure.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q07
    {
        public class AnimalQueue
        {
            private LinkedList<Dog> dogs = new LinkedList<Dog>();
            private LinkedList<Cat> cats = new LinkedList<Cat>();
            private int order = int.MaxValue;

            public void Enqueue(Animal a)
            {
                if (a is Dog) 
                    this.dogs.AddLast((Dog)a);
                else if (a is Cat) 
                    this.cats.AddLast((Cat)a);
                else
                    throw new InvalidOperationException("Unsupported animal");
                a.Older = this.order--;
            }

            public Animal DequeueAny()
            {
                if (this.dogs.Count == 0 && this.cats.Count == 0)
                    throw new IndexOutOfRangeException("Queue is empty");

                if (this.dogs.Count == 0)
                    return this.DequeueCats();
                else if (this.cats.Count == 0)
                    return this.DequeueDogs();
                else
                {
                    Dog dog = this.dogs.First.Value;
                    Cat cat = this.cats.First.Value;
                    if (dog.IsOlderThan(cat))
                        return this.DequeueDogs();
                    else
                        return this.DequeueCats();
                }
            }

            public Dog DequeueDogs()
            {
                if (this.dogs.Count == 0)
                    throw new IndexOutOfRangeException("No dogs");
                Dog dog = this.dogs.First.Value;
                this.dogs.RemoveFirst();
                return dog;
            }

            public Cat DequeueCats()
            {
                if (this.cats.Count == 0)
                    throw new IndexOutOfRangeException("No cats");
                Cat cat = this.cats.First.Value;
                this.cats.RemoveFirst();
                return cat;
            }
        }

        public abstract class Animal
        {
            public int Older { get; set; }
            public string Name { get; set; }
            public Animal(string name)
            {
                this.Name = name;
            }

            public bool IsOlderThan(Animal a)
            {
                return this.Older > a.Older;
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }
        }

        public class Cat : Animal
        {
            public Cat(string name) : base(name)
            {
            }
        }
    }
}
