using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    /// <summary>
    /// 链队列（使用头结点）
    /// 空：front==rear
    /// 满：不存在满的情况
    /// 入队：插入结点链表尾
    /// 出队：头结点之后的结点出列，如果是最后一个，则front=rear
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueByLinkNode<T> : IQueue<T>
    {
        private Node<T> front, rear;//front头节点,rear尾指针
        private int length;
        public QueueByLinkNode()
        {
            Clear();
        }


        public void Clear()
        {
            front = new Node<T>();
            rear = front;
            length = 0;
        }

        public T DeQueue()
        {
            if (IsEmpty())
                throw new ArgumentNullException();
            var readyNode = front.next;
            front.next = readyNode.next;
            length--;
            //特殊情况处理，如果只剩下最后一个元素，read重新指向front
            if (readyNode == rear)
            {
                rear = front;
            }

            return readyNode.data;
        }

        public void EnQueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = null;

            rear.next = newNode;
            rear = newNode;
            length++;
        }

        public T GetHead()
        {
            if (IsEmpty())
                throw new ArgumentNullException();
            var readyNode = front.next;
            return readyNode.data;
        }

        public int GetLength()
        {
            return length;
        }

        public bool IsEmpty()
        {
            //或者判断front==rear
            return length == 0;
        }
    }
}
