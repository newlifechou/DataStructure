using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    public class StackByArray<T> : IStack<T>
    {
        private int maxSize;
        private int length;
        private T[] dataList;
        private int currentTop;
        public StackByArray()
        {
            maxSize = 100;
            length = 0;
            currentTop = -1;
            dataList = new T[100];
        }

        public void Clear()
        {
            currentTop = -1;
            length = 0;
        }

        public int GetLength()
        {
            return length;
        }

        public T GetTop()
        {
            if (currentTop < 0 || currentTop > length - 1)
                throw new IndexOutOfRangeException();
            return dataList[currentTop];
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public T Pop()
        {
            if (currentTop < 0 || currentTop > length - 1)
                throw new IndexOutOfRangeException();
            T result= dataList[currentTop];
            currentTop--;
            length--;
            return result;
        }

        public void Push(T e)
        {
            if (currentTop < maxSize - 1)
            {
                currentTop++;
                dataList[currentTop] = e;
                length++;
            }
        }
    }
}
