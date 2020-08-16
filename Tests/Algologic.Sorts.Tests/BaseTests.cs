using Algoholic.Sorts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algologic.Sorts.Tests
{
    //Test naming is [tested method]_[input data]_[expected result]

    public class BaseTests
    {
        protected BaseSort sorting;

        [SetUp]
        public virtual void Setup()
        {
            sorting = new TestSort();
        }

        [Test]
        public virtual void Sort_OrderedArray_SorteredArray()
        {
            var collection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var sortedCollection = sorting.Sort(collection);

            Assert.IsTrue(IsSorted(sortedCollection));
        }

        [Test]
        public virtual void Sort_ReverseOrderedArray_SortedArray()
        {
            var collection = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var sortedCollection = sorting.Sort(collection);

            Assert.IsTrue(IsSorted(sortedCollection));
        }

        [Test]
        public virtual void Sort_RandomOrderedArray_SortedArray()
        {
            var rnd = new Random();
            var collection = new int[10];
            for (int i = 0; i < collection.Length; i++)
                collection[i] = rnd.Next();

            var sortedCollection = sorting.Sort(collection);

            Assert.IsTrue(IsSorted(sortedCollection));
        }

        protected bool IsSorted(IEnumerable<int> collection)
        {
            var coll = collection.ToList();

            if (coll.Count < 2)
                return true;

            for (int i = 1; i < coll.Count; i++)
            {
                    if (coll[i] < coll[i - 1])
                        return false;
            }
            return true;
        }
    }
}