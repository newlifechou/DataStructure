using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.Search
{
    public static class Fibonacci
    {
        /// <summary>
        /// 利用递归的方式计算
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Fib(int i)
        {
            if (i <= 1)
            {
                return 1;
            }

            return Fib(i - 1) + Fib(i - 2);
        }
        /// <summary>
        /// 返回Fib数组
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] FibArray(int length)
        {
            int[] result = null;
            if (length == 1)
            {
                result = new int[1] { 1 };
            }
            if (length >= 2)
            {
                result = new int[length];
                result[0] = 1;
                result[1] = 1;
                for (int i = 2; i < length; i++)
                {
                    result[i] = result[i - 1] + result[i - 2];
                }
            }
            return result;
        }


    }
}
