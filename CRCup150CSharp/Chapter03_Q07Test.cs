using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q07Test
    {
        [TestMethod]
        public void CRCup_CH03_07_AnimalQueue1()
        {
            Chapter03_Q07.Dog dog1 = new Chapter03_Q07.Dog("dog1");
            Chapter03_Q07.Dog dog2 = new Chapter03_Q07.Dog("dog2");
            Chapter03_Q07.Dog dog3 = new Chapter03_Q07.Dog("dog3");

            Chapter03_Q07.Cat cat1 = new Chapter03_Q07.Cat("cat1");
            Chapter03_Q07.Cat cat2 = new Chapter03_Q07.Cat("cat2");
            Chapter03_Q07.Cat cat3 = new Chapter03_Q07.Cat("cat3");

            Chapter03_Q07.AnimalQueue queue = new Chapter03_Q07.AnimalQueue();
            queue.Enqueue(dog1);
            queue.Enqueue(dog2);
            queue.Enqueue(cat1);
            queue.Enqueue(dog3);
            queue.Enqueue(cat2);
            queue.Enqueue(cat3);

            Assert.AreEqual("dog1", queue.DequeueAny().Name);
            Assert.AreEqual("dog2", queue.DequeueDogs().Name);
            Assert.AreEqual("cat1", queue.DequeueAny().Name);
            Assert.AreEqual("cat2", queue.DequeueCats().Name);
            Assert.AreEqual("dog3", queue.DequeueAny().Name);
            Assert.AreEqual("cat3", queue.DequeueAny().Name);
        }
    }
}
