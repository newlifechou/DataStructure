using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.LeetCode
{
    public class LeetCodeEasy
    {
        /// <summary>
        /// 两数之和
        /// 遍历方法
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] numbers,int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        /// <summary>
        /// TwoSum
        /// 利用dict的索引功能，数字为key，index为value
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum2(int[] numbers,int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { i, dict[complement] };
                }
                dict.Add(numbers[i], i);
            }

            return new int[] { -1, -1 };
        }








    }
}
