﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// some public operations for list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IList<T>
    {
        /// <summary>
        /// 默认从尾部插入
        /// </summary>
        /// <param name="data"></param>
        void Append(T data);
        void Insert(int index, T data);
        T GetData(int index);
        void RemoveAt(int index);
        void Clear();
        int GetLength();
        bool IsEmpty();

        /// <summary>
        /// 辅助输出看链表是否有问题
        /// </summary>
        void Print();

    }
}
