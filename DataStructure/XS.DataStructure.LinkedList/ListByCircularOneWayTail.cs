using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 循环链表(推荐)
    /// 使用尾指针
    /// 没有尾节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListByCircularOneWayTail<T> : IList<T>
    {
        private Node<T> tail;
        private int length;
        public ListByCircularOneWayTail()
        {
            tail = null;
            length = 0;
        }


        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (IsEmpty())
            {
                tail = newNode;
                tail.next = tail;
            }
            else
            {
                //使用尾指针插入不用循环了，非常的方便
                //tail.next其实就是之前的head
                newNode.next = tail.next;
                tail.next = newNode;
                tail = newNode;
            }
            length++;
        }

        public void Clear()
        {
            tail = null;
            length = 0;
        }

        public T GetData(int index)
        {
            if (IsEmpty())
                return default(T);
            if (length == 1)
                return tail.data;
            int realIndex = index % length;
            //游标指向头位置
            Node<T> slider = tail.next;
            for (int i = 0; i < realIndex; i++)
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
                throw new IndexOutOfRangeException();
            if (length == 0)
            {
                newNode.next = tail;
            }
            else
            {
                //游标指向头位置
                Node<T> slider = tail.next;
                //移动到要插入的前一个位置
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
            if (IsEmpty())
            {
                Console.WriteLine("empty");
                return;
            }

            Node<T> slider = tail.next;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{slider.data} ");
                slider = slider.next;
            }
            Console.WriteLine();
        }

        public void RemoveAt(int index)
        {
            if (IsEmpty())
                return;
            if (length == 1)
            {
                Clear();
                return;
            }
            int realIndex = index % length;
            //游标指向头位置
            Node<T> slider = tail.next;
            //移动到要删除的前一个位置
            for (int i = 0; i < realIndex - 1; i++)
            {
                slider = slider.next;
            }
            var deletedNode = slider.next;
            slider.next = deletedNode.next;
            //如果移除的正好是尾节点的话，重新设定尾结点
            if (realIndex == length - 1)
            {
                tail = slider;
            }
            length--;
        }

    }
}
