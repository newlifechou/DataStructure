using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
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
    }
}
