using System;
using System.Collections.Generic;

namespace AlgorithmBasic
{
    public class SimpleData
    {

        /// <summary>
        /// 回文字符串
        /// </summary>
        public string PalindromicSubString { get; set; } 
            = "mnbjabcdecbkjklipql";

        public void ThrowException(bool isYes)
        {
            if (isYes)
            {
                throw new Exception(message: "YES");
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        /// <summary>
        /// 获取排序好的数组
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public int[] GetOrderedArray(int length=10)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                numbers.Add(i);
            }
            return numbers.ToArray();
        }

        /// <summary>
        /// 洗牌
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="shuffleCount"></param>
        public void Shuffle(int[] numbers,int shuffleCount=10)
        {
            Random r = new Random();

            for (int i = 0; i < shuffleCount; i++)
            {
                int pos_1 = r.Next(0, numbers.Length);
                int pos_2 = r.Next(0, numbers.Length);
                if (pos_1 != pos_2)
                {
                    int temp = numbers[pos_1];
                    numbers[pos_1] = numbers[pos_2];
                    numbers[pos_2] = temp;
                }
            }

        }
        /// <summary>
        /// 获取随机数组
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public int[] GetShuffleArray(int length = 10)
        {
            var result = GetOrderedArray(length);
            Shuffle(result,result.Length);
            return result;
        }

    }
}
