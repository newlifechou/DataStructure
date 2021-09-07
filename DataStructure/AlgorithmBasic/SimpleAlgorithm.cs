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
        /// 最小公倍数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int ShowLeastCommonMutiple(int a,int b)
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
    }
}
