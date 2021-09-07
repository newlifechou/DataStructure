using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.Search
{
    public class SearchCollection
    {
        /// <summary>
        /// 暴力查找
        /// 可以查找任何顺序，任何类型的数据
        /// 时间复杂度O(n)
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SearchByViolent(int[] data, int key)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (key == data[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 折半查找
        /// 线性表必须有序
        /// 顺序存储
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SearchByBinary(int[] data, int key)
        {
            int low, high, mid;
            low = 0;
            high = data.Length - 1;
            //退出条件，low超过high
            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (data[mid] == key)
                {
                    return mid;
                }

                if (data[mid] > key)
                {
                    high = mid - 1;
                }
                else if (data[mid] < key)
                {
                    low = mid + 1;
                }

            }
            return -1;
        }

        /// <summary>
        /// 插值法
        /// 基本和二分法类似
        /// 关键在差值公式
        /// 表很长而且关键字分布比较均匀的查找表
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SearchByInterpolation(int[] data, int key)
        {
            int low, high, mid;
            low = 0;
            high = data.Length - 1;
            //退出条件，low超过high
            while (low <= high)
            {
                //差值公式
                mid = low + (high - low) * (key - data[low]) / (data[high] - data[low]);

                if (data[mid] == key)
                {
                    return mid;
                }

                if (data[mid] > key)
                {
                    high = mid - 1;
                }
                else if (data[mid] < key)
                {
                    low = mid + 1;
                }

            }
            return -1;
        }

        /// <summary>
        /// 黄金分隔查找
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int SearchByFib(int[] data, int key)
        {
            int n = data.Length;
            int k = 0;

            //构造一个长度为10的Fib序列
            int[] fib = Fibonacci.FibArray(10);

            //找到fib[k]刚好大于等于n的位置
            while (n > fib[k])
            {
                k++;
            }

            int[] temp = new int[fib[k]];
            Array.Copy(data, temp, n);
            //补齐以便刚好能够拆解n==fib(k);
            for (int i = n; i < fib[k]; i++)
            {
                temp[i] = data[n - 1];
            }


            int low = 0;
            int high = fib[k] - 1;

            while (low <= high)
            {
                int mid = low + fib[k - 1] - 1;
                if (data[mid] == key)
                {
                    if (mid <= n)
                    {
                        return mid;
                    }
                    else
                    {
                        return n;
                    }
                }
                else if (data[mid] > key)
                {
                    high = mid - 1;
                    k = k - 1;
                }
                else if (data[mid] < key)
                {
                    low = mid + 1;
                    k = k - 2;
                }
            }

            return -1;

        }

    }
}
