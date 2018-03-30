using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 有头结点
    /// 双向链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListByLinkedNodeTwoWay<T> : IList<T>
    {
        private Node<T> head;
        private int length;
        public ListByLinkedNodeTwoWay()
        {
            length = 0;
            head = new Node<T>();
            head.prev = null;
            head.next = null;
        }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (length == 0)
            {
                newNode.prev = head;
                newNode.next = null;
                head.next = newNode;
            }
            else
            {
                Node<T> slider = head;
                for (int i = 0; i < length; i++)
                {
                    slider = slider.next;
                }
                newNode.prev = slider;
                newNode.next = null;
                slider.next = newNode;
            }

            length++;
        }

        public void Clear()
        {
            length = 0;
            head = new Node<T>();
            head.prev = null;
            head.next = null;
        }

        public T GetData(int index)
        {
            if (index < 0 || index > length - 1)
                throw new IndexOutOfRangeException();
            if (length == 1)
            {
                return head.next.data;
            }
            else
            {
                Node<T> slider = head.next;
                //移动到index位置
                for (int i = 0; i < index; i++)
                {
                    slider = slider.next;
                }
                return slider.data;
            }
        }

        public int GetLength()
        {
            return length;
        }

        public void Insert(int index, T data)
        {
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();

            Node<T> newNode = new Node<T>(data);
            //移动到插入点
            Node<T> slider = head.next;
            for (int i = 0; i < index; i++)
            {
                slider = slider.next;
            }
            //顺序非常的重要
            newNode.prev = slider.prev;
            newNode.next = slider;
            slider.prev.next = newNode;
            slider.prev = newNode;

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
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
            //移动到删除点
            Node<T> slider = head.next;
            for (int i = 0; i < index; i++)
            {
                slider = slider.next;
            }
            var pre = slider.prev;
            var nex = slider.next;
            pre.next = nex;
            nex.prev = pre;
            length--;
        }
    }
}
