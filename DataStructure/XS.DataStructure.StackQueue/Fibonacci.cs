using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    /// <summary>
    /// 斐波拉基函数
    /// </summary>
    public class Fibonacci
    {
        public int Fib(int i)
        {
            if (i < 0)
                throw new IndexOutOfRangeException();
            if (i < 2)
                return i;
            return Fib(i - 1) + Fib(i - 2);
        }
    }
}
