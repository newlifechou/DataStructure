using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    class NodeStatic<T>
    {
        public NodeStatic()
        {

        }
        public NodeStatic(T data)
        {
            this.data = data;
        }
        public T data;
        public int cursor;
    }
}
