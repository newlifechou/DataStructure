using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    public interface IStack<T>
    {
        /// <summary>
        /// 获取不出栈
        /// </summary>
        /// <returns></returns>
        T GetTop();
        void Push(T e);
        T Pop();
        int GetLength();
        bool IsEmpty();
        void Clear();
    }
}
