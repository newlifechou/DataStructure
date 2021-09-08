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
            var array = data.GetOrderedArray(number_count);
            data.Shuffle(array, array.Length);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.BubbleSort(array);


            bool isSame = true;

            for (int i = 0; i < number_count; i++)
            {
                isSame = isSame && (i == array[i]);
            }

            Assert.IsTrue(isSame);
        }

        [TestMethod()]
        public void BubbledSortTest2()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetOrderedArray(number_count);
            data.Shuffle(array, array.Length);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.BubbleSort(array);


            bool isSame = true;

            for (int i = 0; i < number_count; i++)
            {
                isSame = isSame && (i == array[i]);
            }

            Assert.IsTrue(isSame);
        }

        [TestMethod()]
        public void BubbleSort2Test()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetOrderedArray(number_count);
            data.Shuffle(array, array.Length);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.BubbleSort2(array);


            bool isSame = true;

            for (int i = 0; i < number_count; i++)
            {
                isSame = isSame && (i == array[i]);
            }

            Assert.IsTrue(isSame);
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetOrderedArray(number_count);
            data.Shuffle(array, array.Length);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.SelectionSort(array);


            bool isSame = true;

            for (int i = 0; i < number_count; i++)
            {
                isSame = isSame && (i == array[i]);
            }

            Assert.IsTrue(isSame);
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetOrderedArray(number_count);
            data.Shuffle(array, array.Length);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.InsertionSort(array);


            bool isSame = true;

            for (int i = 0; i < number_count; i++)
            {
                isSame = isSame && (i == array[i]);
            }

            Assert.IsTrue(isSame);
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            int number_count = 125;
            SimpleData data = new SimpleData();
            var array = data.GetOrderedArray(number_count);
            data.Shuffle(array, array.Length);

            SortAlgorithm algorithm = new SortAlgorithm();
            algorithm.ShellSort(array);


            bool isSame = true;

            for (int i = 0; i < number_count; i++)
            {
                isSame = isSame && (i == array[i]);
            }

            Assert.IsTrue(isSame);
        }
    }
}