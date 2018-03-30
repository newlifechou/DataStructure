using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 单向链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListByLinkedNodeOneWay<T> : IList<T>
    {
        private Node<T> head;
        private int length;

        public ListByLinkedNodeOneWay()
        {
            length = 0;
            head = new Node<T>();
            head.next = null;
        }


        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = null;
            //找出末尾的节点
            Node<T> slider = head;
            for (int i = 0; i < length; i++)
            {
                slider = slider.next;
            }
            slider.next = newNode;
            length++;
        }

        public void Clear()
        {
            head.next = null;
            length = 0;
        }

        public T GetData(int index)
        {
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
            //找到Index的位置
            Node<T> slider = head.next;
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
            if (index < 0 || index > length)
                throw new IndexOutOfRangeException();

            Node<T> newNode = new Node<T>(data);
            //找到Index前面一个位置
            Node<T> slider = head;
            for (int i = 0; i < index; i++)
            {
                slider = slider.next;
            }
            newNode.next = slider.next;
            slider.next = newNode;
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
            //找到Index前面一个的位置
            Node<T> slider = head;
            for (int i = 0; i < index; i++)
            {
                slider = slider.next;  
            }
            //这个节点的next指向下一个（要删除）的下一个节点
            var deletedNode = slider.next;
            slider.next = deletedNode.next;
            length--;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
