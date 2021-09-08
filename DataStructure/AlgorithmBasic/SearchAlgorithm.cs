using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic
{
    /// <summary>
    /// 查找算法
    /// </summary>
    public class SearchAlgorithm
    {


        /// <summary>
        /// 遍历查找笨办法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="number"></param>
        /// <returns></returns>

        public int StupidSearch(int[] nums,int number)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (number == nums[i])
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// 二分法查找
        /// 每次猜中间值，然后直接去掉一半的不可能的数值
        /// </summary>
        /// <param name="nums">有序序列</param>
        /// <param name="number"></param>
        /// <returns></returns>
        public int BinarySearch(int[] nums, int number)
        {
            int len = nums.Length;

            int low = 0;
            int high = len - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                int guess = nums[mid];

                if (guess > number)
                {
                    high = mid - 1;
                }
                else if (guess < number)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
