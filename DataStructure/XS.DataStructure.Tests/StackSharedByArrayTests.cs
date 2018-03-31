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
    public class StackSharedByArrayTests
    {
        private StackSharedByArray<int> stack;
        [TestInitialize]
        public void Intialize()
        {
            stack = new StackSharedByArray<int>();
        }
        [TestMethod()]
        public void ClearTest1()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(3, 1);
            stack.Push(4, 1);
            stack.Push(5, 1);
            Assert.AreEqual(3, stack.GetLength(1));
            Assert.AreEqual(5, stack.GetTop(1));
            Assert.AreEqual(3, stack.GetLength(1));
        }
        [TestMethod()]
        public void ClearTest2()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(3, 2);
            stack.Push(4, 2);
            stack.Push(5, 2);
            Assert.AreEqual(3, stack.GetLength(2));
            Assert.AreEqual(5, stack.GetTop(2));
            Assert.AreEqual(3, stack.GetLength(2));
        }
        [TestMethod()]
        public void GetTopTest1()
        {
            Assert.IsTrue(stack.IsEmpty(1));
            stack.Push(3, 1);
            stack.Push(4, 1);
            stack.Push(5, 1);
            Assert.AreEqual(3, stack.GetLength(1));
            Assert.AreEqual(5, stack.GetTop(1));
            Assert.AreEqual(3, stack.GetLength(1));
        }
        [TestMethod()]
        public void GetTopTest2()
        {
            Assert.IsTrue(stack.IsEmpty(2));
            stack.Push(3, 2);
            stack.Push(4, 2);
            stack.Push(5, 2);
            Assert.AreEqual(3, stack.GetLength(2));
            Assert.AreEqual(5, stack.GetTop(2));
            Assert.AreEqual(3, stack.GetLength(2));
        }
        [TestMethod()]
        public void PopTest1()
        {
            Assert.IsTrue(stack.IsEmpty(1));
            stack.Push(3, 1);
            stack.Push(4, 1);
            stack.Push(5, 1);
            Assert.IsFalse(stack.IsEmpty(1));

            Assert.AreEqual(3, stack.GetLength(1));
            Assert.AreEqual(5, stack.Pop(1));
            Assert.AreEqual(2, stack.GetLength(1));
            Assert.AreEqual(4, stack.Pop(1));
            Assert.AreEqual(3, stack.Pop(1));
            Assert.IsTrue(stack.IsEmpty(1));
        }

        [TestMethod()]
        public void PopTest2()
        {
            Assert.IsTrue(stack.IsEmpty(2));
            stack.Push(3, 2);
            stack.Push(4, 2);
            stack.Push(5, 2);
            Assert.IsFalse(stack.IsEmpty(2));

            Assert.AreEqual(3, stack.GetLength(2));
            Assert.AreEqual(5, stack.Pop(2));
            Assert.AreEqual(2, stack.GetLength(2));
            Assert.AreEqual(4, stack.Pop(2));
            Assert.AreEqual(3, stack.Pop(2));
            Assert.IsTrue(stack.IsEmpty(2));
        }
    }
}