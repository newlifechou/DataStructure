using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 线性表的顺序存储结构
    /// 优点：随机读取
    /// 缺点：插入或者删除都要移动很多元素
    /// </summary>
    class ListByArray<T> : IList<T>
    {
        private T[] dataList;
        //线性表存储最大值
        private int maxSize;
        //线性表长度
        private int length;
        public ListByArray()
        {
            length = 0;
            maxSize = 100;
            dataList = new T[maxSize];
        }
        /// <summary>
        /// 添加到尾部
        /// </summary>
        /// <param name="data"></param>
        public void Append(T data)
        {
            if (length > maxSize)
                throw new IndexOutOfRangeException();
            dataList[length] = data;
            length++;
        }

        public void Insert(int index, T data)
        {
            for (int i = length - 1; i >= index; i--)
            {
                //从最后一个元素开始，依次往后移动
                dataList[i + 1] = dataList[i];
            }
            dataList[index] = data;
            length++;
        }

        public T GetData(int index)
        {
            if (index > length || index < 0)
                throw new IndexOutOfRangeException();
            return dataList[index];
        }

        public int IndexOf(T data)
        {
            for (int i = 0; i < length; i++)
            {
                if (dataList[i].Equals(data))
                    return i;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            //依次把要删除位置之后的元素挨个往前移动
            for (int i = index + 1; i < length; i++)
            {
                dataList[i - 1] = dataList[i];
            }
            length--;
        }

        public void Clear()
        {
            length = 0;
        }

        public int GetLength()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return length > 0;
        }

    }
}
