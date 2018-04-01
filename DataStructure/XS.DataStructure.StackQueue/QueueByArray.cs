using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    /// <summary>
    /// 采用循环数组
    /// 判断空：front=rear,也可以采用flag的方式
    /// 队列长度：(rear - front + maxSize) % maxSize
    /// 判断满:（rear+1）%maxSize=front
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueByArray<T> : IQueue<T>
    {
        private int maxSize;
        private int front, rear;
        private T[] dataList;

        public QueueByArray()
        {
            maxSize = 100;
            Clear();
        }
        public void Clear()
        {
            front = 0;
            rear = 0;
            dataList = new T[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                dataList[i] = default(T);
            }
        }

        public T DeQueue()
        {
            if(IsEmpty())
                throw new ArgumentNullException();
            T result = dataList[front];
            if(front<maxSize-1)
            {
                front++;
            }
            else
            {
                front = 0;
            }
            return result;
        }

        public void EnQueue(T data)
        {
            if (IsFull())
                throw new IndexOutOfRangeException();
            dataList[rear] = data;
            if (rear < maxSize - 1)
            {
                rear++;
            }
            else
            {
                rear = 0;
            }
        }

        public T GetHead()
        {
            if (IsEmpty())
                throw new ArgumentNullException();
            T result = dataList[front];
            return result;
        }

        public int GetLength()
        {
            return (rear - front + maxSize) % maxSize;
        }

        public bool IsEmpty()
        {
            return front == rear;
        }
        /// <summary>
        /// 辅助判断栈满的方法
        /// </summary>
        /// <returns></returns>
        private bool IsFull()
        {
            return (rear + 1) % maxSize == front;
        }
    }
}
