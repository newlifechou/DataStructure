using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    public class StackByLinkNode<T>
    {
        private Node<T> top;
        private int length;
        public StackByLinkNode()
        {
            top = null;
            length = 0;
        }
        public void Clear()
        {
            top = null;
            length = 0;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = top;
            top = newNode;
            length++;
        }

        public T Pop()
        {
            if (top == null)
                throw new IndexOutOfRangeException();
            T result = top.data;
            top = top.next;
            length--;
            return result;
        }

        public int GetLength()
        {
            return length;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }

        public T GetTop()
        {
            if (top == null)
                throw new IndexOutOfRangeException();
            T result = top.data;
            return result;
        }

    }
}
