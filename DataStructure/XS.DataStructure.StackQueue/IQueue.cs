using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    /// <summary>
    /// 队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IQueue<T>
    {
        void Clear();
        bool IsEmpty();
        T GetHead();
        void EnQueue(T data);
        T DeQueue();
        int GetLength();
    }
}
