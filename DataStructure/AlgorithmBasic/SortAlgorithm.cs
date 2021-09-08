using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic
{
    public class SortAlgorithm
    {
        public void BubbledSort(int[] numbers)
        {
            int len = numbers.Length;
            //总的冒泡
            for (int i = 0; i < len - 1; i++)
            {
                //每次的冒泡
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

        }
    }
}
