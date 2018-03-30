using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 使用头指针来实现
    /// 不包含头节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListByCircularOneWayHead<T> : IList<T>
    {
        private Node<T> head;
        private int length;
        public ListByCircularOneWayHead()
        {
            head = null;
            length = 0;
        }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            //如果是第一个节点，设置为头结点
            if (length == 0)
            {
                head = newNode;
                newNode.next = head;
            }
            else
            {
                //移动游标到最后一个位置
                Node<T> slider = head;
                for (int i = 1; i < length; i++)
                {
                    slider = slider.next;
                }
                //重新构成一个圈
                slider.next = newNode;
                newNode = head;
            }
            length++;
        }

        public void Clear()
        {
            head = null;
            length = 0;
        }

        /// <summary>
        /// 循环链表这里可以不考虑越界，
        /// 因为index大于length的时候是循环
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetData(int index)
        {
            if (index < 0 || index > length - 1)
                throw new IndexOutOfRangeException();
            Node<T> slider = head;
            //移动index次位置
            for (int i = 0; i < index; i++)
            {
                slider = slider.next;
            }
            return slider.data;
        }

        public int GetLength()
        {
            return length;
        }


        public void Insert(int index, T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (index < 0 || index > length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Node<T> slider = head;
                //找到插入位置的前一个位置
                for (int i = 0; i < index - 1; i++)
                {
                    slider = slider.next;
                }
                newNode.next = slider.next;
                slider.next = newNode;
            }
            length++;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > length - 1)
                throw new IndexOutOfRangeException();

            Node<T> slider = head;
            //找到删除位置的前一个位置
            for (int i = 0; i < index - 1; i++)
            {
                slider = slider.next;
            }
            Node<T> deletedNode = slider.next;
            slider.next = deletedNode.next;
            length--;
        }
    }
}
