using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic
{
    public class SimpleAlgorithm
    {
        /// <summary>
        /// 计算最小公倍数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int GetLeastCommonMutiple(int a,int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int product = min * max;
            while (min != 0)
            {
                max = max > min ? max : min;
                int m = max % min;
                max = min;
                min = m;
            }

            return product / max;
        }

        /// <summary>
        /// 使用辗转相除法计算最大公约数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int GetLargestCommonVidisor(int a,int b)
        {
            int max = a > b ? a : b;
            int min = a < b ? a : b;

            int remainder = 0;
            while (min!=0)
            {
                remainder = max % min;
                max = min;
                min = remainder;
            }
            return max;
        }


    }
}
