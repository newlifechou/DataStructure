using System;
using System.Collections.Generic;

namespace AlgorithmBasic
{
    public class SimpleData
    {
        public int[] GetOrderedArray(int length=10)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                numbers.Add(i);
            }
            return numbers.ToArray();
        }

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


    }
}
