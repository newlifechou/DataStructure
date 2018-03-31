using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    public class StackSharedByArray<T>
    {
        private T[] dataList;
        private int maxSize;
        private int currentTop1;
        private int currentTop2;
        private int length1;
        private int length2;

        public StackSharedByArray()
        {
            maxSize = 100;
            currentTop1 = -1;
            currentTop2 = maxSize;
            length1 = length2 = 0;
            dataList = new T[maxSize];
        }
        public void Clear(int stackNumber)
        {
            currentTop1 = -1;
            currentTop2 = maxSize;
            length1 = length2 = 0;
        }
        public int GetLength(int stackNumber = 1)
        {
            if (stackNumber == 1)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }
        public bool IsEmpty(int stackNumber = 1)
        {
            if (stackNumber == 1)
            {
                return length1 == 0;
            }
            else
            {
                return length2 == 0;
            }
        }

        public T GetTop(int stackNumber = 1)
        {
            if (stackNumber == 1)
            {
                if (currentTop1 < 0 || currentTop1 >= currentTop2)
                    throw new IndexOutOfRangeException();
                return dataList[currentTop1];
            }
            else
            {
                if (currentTop2 <= currentTop1 || currentTop2 > maxSize - 1)
                    throw new IndexOutOfRangeException();
                return dataList[currentTop2];
            }
        }
        public void Push(T data, int stackNumber = 1)
        {
            if (stackNumber == 1)
            {
                if (currentTop1 < currentTop2)
                {
                    currentTop1++;
                    dataList[currentTop1] = data;
                    length1++;
                }
            }
            else
            {
                if (currentTop2 > currentTop1)
                {
                    currentTop2--;
                    dataList[currentTop2] = data;
                    length2++;

                }
            }
        }
        public T Pop(int stackNumber = 1)
        {
            if (stackNumber == 1)
            {
                if (currentTop1 < 0 || currentTop1 >= currentTop2)
                    throw new IndexOutOfRangeException();
                T result = dataList[currentTop1];
                currentTop1--;
                length1--;
                return result;
            }
            else
            {
                if (currentTop2 <= currentTop1 || currentTop2 > maxSize - 1)
                    throw new IndexOutOfRangeException();
                T result = dataList[currentTop2];
                currentTop2++;
                length2--;
                return result;
            }
        }
    }
}
