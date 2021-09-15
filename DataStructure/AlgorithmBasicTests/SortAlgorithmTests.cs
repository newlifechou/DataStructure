using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic.Tests
{
    [TestClass()]
    public class SortAlgorithmTests
    {
        [TestMethod()]
        public void SwapTest()
        {
            int a = 1;
            int b = 2;
            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.Swap(ref a, ref b);
            Assert.AreEqual(2, a);
            Assert.AreEqual(1, b);
        }

        [TestMethod()]
        public void BubbledSortTest1()
        {
            int number_count = 100;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.BubbleSort(array);

            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void BubbledSortTest2()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.BubbleSort(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void BubbleSort2Test()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.BubbleSort2(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.SelectionSort(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.InsertionSort(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.ShellSort(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            int number_count = 10;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.MergeSort(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void MergeSortRecursiveTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.MergeSortRecursive(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest1()
        {
            int number_count = 250;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.QuickSort(array);


            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest2()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetShuffleArray(number_count);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.QuickSort(array);
            ;

            for (int i = 0; i < number_count; i++)
            {
                Assert.AreEqual(i, array[i]);
            }
        }

        [TestMethod()]
        public void MergeArrayTest()
        {
            SortAlgorithm simple = new SortAlgorithm();
            int[] a = { 1, 4, 7 };
            int[] b = { 2, 3, 5, 6, 8 };
            int[] c = new int[a.Length + b.Length];
            simple.MergeArray(a, a.Length, b, b.Length, c);

            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(i + 1, c[i]);
            }
        }
    }
}