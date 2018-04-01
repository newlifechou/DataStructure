using Microsoft.VisualStudio.TestTools.UnitTesting;
using XS.DataStructure.StackQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue.Tests
{
    [TestClass()]
    public class QueueByArrayTests
    {
        private QueueByArray<int> queue;
        [TestInitialize]
        public void Initialize()
        {
            queue = new QueueByArray<int>();
        }
        [TestMethod()]
        public void EnQueueLessTest()
        {
            Assert.AreEqual(0, queue.GetLength());
            int testCount = 10;
            for (int i = 0; i < testCount; i++)
            {
                queue.EnQueue(i);
            }
            Assert.AreEqual(testCount, queue.GetLength());
        }
        [TestMethod()]
        public void EnQueueMoreTest()
        {
            Assert.AreEqual(0, queue.GetLength());
            int testCount = 30;
            for (int i = 0; i < testCount; i++)
            {
                queue.EnQueue(i);
            }
            Assert.AreEqual(testCount, queue.GetLength());
        }

        [TestMethod()]
        public void DeQueueAllTest()
        {
            int testCount = 30;
            for (int i = 0; i < testCount; i++)
            {
                queue.EnQueue(i);
            }

            for (int i = 0; i < testCount; i++)
            {
                Assert.AreEqual(i, queue.DeQueue());
            }

        }
        [TestMethod()]
        public void DeQueueAllMoreTimeTest()
        {
            int testCount = 51;
            for (int i = 0; i < testCount; i++)
            {
                queue.EnQueue(i);
            }

            for (int i = 0; i < testCount; i++)
            {
                Assert.AreEqual(i, queue.DeQueue());
            }

            for (int i = 0; i < testCount; i++)
            {
                queue.EnQueue(i);
            }

            for (int i = 0; i < testCount; i++)
            {
                Assert.AreEqual(i, queue.DeQueue());
            }

        }
    }
}