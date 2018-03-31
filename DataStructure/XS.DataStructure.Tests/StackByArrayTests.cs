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
    public class StackByArrayTests
    {
        private StackByArray<int> stack;
        [TestInitialize]
        public void Intialize()
        {
            stack = new StackByArray<int>();
        }
        [TestMethod()]
        public void GetTopTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.AreEqual(3, stack.GetLength());
            Assert.AreEqual(5, stack.GetTop());
            Assert.AreEqual(3, stack.GetLength());

        }

        [TestMethod()]
        public void PopTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.IsFalse(stack.IsEmpty());

            Assert.AreEqual(3, stack.GetLength());
            Assert.AreEqual(5, stack.Pop());
            Assert.AreEqual(2, stack.GetLength());
            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(3, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());

        }
        [TestMethod()]
        public void ClearTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.IsFalse(stack.IsEmpty());
            stack.Clear();
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}