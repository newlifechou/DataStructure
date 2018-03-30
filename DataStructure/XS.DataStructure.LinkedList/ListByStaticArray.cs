using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 静态链表
    /// 在没有指针或者引用的语言中，通过数组来表示链表
    /// Static Linked List
    /// </summary>
    class ListByStaticArray<T> : IList<T>
    {

        private NodeStatic<T>[] dataList;
        private int maxSize;
        private int length;

        //存储可用节点的数组索引
        private int firstFreeNodeCursor = 0;
        //存储数据节点的第一个节点的数组索引
        private int firstDataNodeCursor = -1;

        /// <summary>
        /// 把数据的每个位置按照默认的顺序连接起来
        /// </summary>
        private void Initialize()
        {
            //把所有空闲位串起来
            for (int i = 0; i < maxSize; i++)
            {
                dataList[i].cursor = i + 1;
            }
            //最后一个位置cursor为-1，表示它后面没有元素了
            dataList[maxSize - 1].cursor = -1;

            firstFreeNodeCursor = 0;
            firstDataNodeCursor = -1;
            length = 0;
        }
        /// <summary>
        /// 分配空闲位
        /// </summary>
        /// <returns></returns>
        private int Allocate()
        {
            int i = firstFreeNodeCursor;
            if (firstFreeNodeCursor != -1)
            {
                //将当前空闲位的cursor值，也就是下一个空闲位的cursor存在freeNodeCursor中备用
                firstFreeNodeCursor = dataList[firstFreeNodeCursor].cursor;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            return i;
        }
        /// <summary>
        /// 释放空闲位
        /// </summary>
        /// <param name="deleteCursor"></param>
        private void Free(int deleteCursor)
        {
            dataList[deleteCursor].cursor = firstFreeNodeCursor;
            firstFreeNodeCursor = deleteCursor;
        }


        public ListByStaticArray()
        {
            length = 0;
            maxSize = 100;
            dataList = new NodeStatic<T>[maxSize];
        }

        public void AppendToHead(T data)
        {
            //获取分配的空闲位Cursor
            int currentCursor = Allocate();
            dataList[currentCursor].data = data;

            if (firstDataNodeCursor == -1)
            {
                //-1表示此位置没有下一个
                dataList[currentCursor].cursor = -1;
            }
            else
            {
                dataList[currentCursor].cursor = firstDataNodeCursor;
                firstDataNodeCursor = currentCursor;
            }
            length++;
        }


        public void Append(T data)
        {
            //获取分配的空闲位Cursor
            int currentCursor = Allocate();
            dataList[currentCursor].data = data;

            //-1表示此位置没有下一个
            dataList[currentCursor].cursor = -1;

            //如果这是第一个
            if (firstDataNodeCursor == -1)
            {
                firstDataNodeCursor = currentCursor;
            }
            else
            {
                int sliderCursor = firstDataNodeCursor;
                //找到最后一个位置
                for (int i = 0; i < length; i++)
                {
                    sliderCursor = dataList[sliderCursor].cursor;
                }
                //把最后一个位置的下一个位置设置为新位置的Cursor
                dataList[sliderCursor].cursor = currentCursor;

            }

            length++;
        }

        public void Clear()
        {
            Initialize();
        }

        public T GetData(int index)
        {
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
            int slideCursor = firstDataNodeCursor;
            //找到index位置
            for (int i = 0; i < index; i++)
            {
                slideCursor = dataList[slideCursor].cursor;
            }
            return dataList[slideCursor].data;
        }

        public int GetLength()
        {
            return length;
        }

        public int IndexOf(T data)
        {
            if (length == 0)
                throw new IndexOutOfRangeException();
            int slideCursor = firstDataNodeCursor;
            //从头找
            for (int i = 0; i < length; i++)
            {
                if (dataList[slideCursor].data.Equals(data))
                {
                    return slideCursor;
                }
                slideCursor = dataList[slideCursor].cursor;
            }
            return -1;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
            int slideCursor = firstDataNodeCursor;
            //找到index位置的前一个
            for (int i = 0; i < index - 1; i++)
            {
                slideCursor = dataList[slideCursor].cursor;
            }
            //获取分配的空闲位Cursor
            int currentCursor = Allocate();
            dataList[currentCursor].data = data;

            dataList[currentCursor].cursor = dataList[slideCursor].cursor;
            dataList[slideCursor].cursor = currentCursor;

            length++;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
            int slideCursor = firstDataNodeCursor;
            //找到index前一个位置
            for (int i = 0; i < index - 1; i++)
            {
                slideCursor = dataList[slideCursor].cursor;
            }
            int deletedCursor = dataList[slideCursor].cursor;
            dataList[slideCursor].cursor = dataList[deletedCursor].cursor;
            Free(deletedCursor);
            length--;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
