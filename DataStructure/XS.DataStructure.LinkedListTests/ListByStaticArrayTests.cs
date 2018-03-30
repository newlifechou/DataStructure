using Microsoft.VisualStudio.TestTools.UnitTesting;
using XS.DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList.Tests
{
    [TestClass()]
    public class ListByStaticArrayTests
    {
        private ListByArray<int> list;

        [TestInitialize]
        public void Initilze()
        {
            list = new ListByArray<int>();
        }


        [TestMethod()]
        public void AppendTest()
        {
            list.Append(1);
            list.Append(2);
            list.Append(3);
            int one = list.GetData(0);
            int two = list.GetData(1);
            int three = list.GetData(2);
            Assert.AreEqual(1, one);
            Assert.AreEqual(2, two);
            Assert.AreEqual(3, three);

        }

        [TestMethod()]
        public void InsertTest()
        {
            list.Append(1);//0
            list.Append(2);//1插入位置
            list.Append(3);//2
            list.Insert(1, 5);
            int expect1 = list.GetData(1);
            int expect2 = list.GetData(2);
            Assert.AreEqual(expect1, 5);
            Assert.AreEqual(expect2, 2);

        }
        [TestMethod]
        public void InsertOnlyOneTest()
        {
            list.Append(1);//0
            list.Insert(0, 5);
            Assert.AreEqual(2, list.GetLength());
            Assert.AreEqual(5, list.GetData(0));
        }
        [TestMethod]
        public void InsertOnlyTwo()
        {
            list.Append(1);//0
            list.Append(2);//1
            list.Insert(1, 5);
            Assert.AreEqual(3, list.GetLength());
            Assert.AreEqual(5, list.GetData(1));
        }

        [TestMethod()]
        public void GetDataTest()
        {
            list.Append(10);
            int expect = list.GetData(0);
            Assert.AreEqual(expect, 10);
        }

        [TestMethod()]
        public void RemoveAtTest()
        {
            list.Append(10);
            list.Append(20);
            list.Append(30);
            Assert.AreEqual(3, list.GetLength());
            list.RemoveAt(1);
            Assert.AreEqual(30, list.GetData(1));
            Assert.AreEqual(2, list.GetLength());
        }

        [TestMethod()]
        public void ClearTest()
        {
            list.Append(1);
            list.Append(2);
            list.Append(3);
            Assert.AreEqual(3, list.GetLength());
            list.Clear();
            Assert.IsTrue(list.IsEmpty());
        }
    }
}