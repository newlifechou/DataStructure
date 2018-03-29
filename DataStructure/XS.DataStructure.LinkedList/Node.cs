using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// public Node
    /// two-way Node
    /// if you want one-way node, just use next.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public Node()
        {

        }
        public Node(T data)
        {
            this.data = data;
        }
        public T data;
        public Node<T> next;
        public Node<T> prev;
    }
}
