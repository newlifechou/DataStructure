using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic
{
    /// <summary>
    /// 排序算法
    /// 
    /// 所有都是从小到大排列
    /// </summary>
    public class SortAlgorithm
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        /// <summary>
        /// 冒泡排序
        /// 比较相邻，交换位置
        /// 最好情况就是已经正序
        /// 最坏情况就是都是反序
        /// </summary>
        /// <param name="numbers"></param>
        public void BubbleSort(int[] numbers)
        {
            int len = numbers.Length;
            //总的冒泡
            //需要n-1次循环
            for (int i = 0; i < len - 1; i++)
            {
                //每次的冒泡过程
                for (int j = 0; j < len - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                        //int temp = numbers[j];
                        //numbers[j] = numbers[j + 1];
                        //numbers[j + 1] = temp;
                    }
                }
            }

        }

        /// <summary>
        /// 另外一种写法
        /// 反向考虑
        /// </summary>
        /// <param name="numbers"></param>
        public void BubbleSort2(int[] numbers)
        {
            int len = numbers.Length;

            for (int i = len - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                        //int temp = numbers[j];
                        //numbers[j] = numbers[j + 1];
                        //numbers[j + 1] = temp;
                    }
                }
            }




        }

        /// <summary>
        /// 选择排序
        /// 找到最小值，放到已排序的队尾
        /// </summary>
        /// <param name="numbers"></param>
        public void SelectionSort(int[] numbers)
        {
            int len = numbers.Length;

            int minIndex;
            for (int i = 0; i < len - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                Swap(ref numbers[i], ref numbers[minIndex]);
                //temp = numbers[i];
                //numbers[i] = numbers[minIndex];
                //numbers[minIndex] = temp;
            }


        }


        /// <summary>
        /// 插入排序
        /// 从已经排序的队列找位置，插入
        /// </summary>
        /// <param name="numbers"></param>
        public void InsertionSort(int[] numbers)
        {
            int len = numbers.Length;
            int preIndex, current;
            for (int i = 0; i < len; i++)
            {
                preIndex = i - 1;
                current = numbers[i];

                while (preIndex >= 0 && numbers[preIndex] > current)
                {
                    numbers[preIndex + 1] = numbers[preIndex];
                    preIndex--;
                }
                numbers[preIndex + 1] = current;
            }


        }

        /// <summary>
        /// 希尔排序
        /// 基于插入排序
        /// 先将整个待排序的记录序列分割成为若干子序列分别进行直接插入排序，
        /// 待整个序列中的记录"基本有序"时，再对全体记录进行依次直接插入排序。
        /// </summary>
        /// <param name="numbers"></param>
        public void ShellSort(int[] numbers)
        {
            int len = numbers.Length;
            int temp;
            for (int step = len / 2; step >= 1; step /= 2)
            {
                for (int i = step; i < len; i++)
                {
                    temp = numbers[i];
                    int j = i - step;
                    while (j >= 0 && numbers[j] > temp)
                    {
                        numbers[j + step] = numbers[j];
                        j -= step;
                    }
                    numbers[j + step] = temp;
                }
            }
        }


        /// <summary>
        /// 归并排序
        /// 非递归
        /// 分治法 Divide and Conquer
        /// 比较占用空间
        /// 递归思想
        /// </summary>
        /// <param name="numbers"></param>
        public void MergeSort(int[] numbers)
        {
            int len = numbers.Length;
            if (len < 2) return;
            int gap = 1;

            while (gap<=len)
            {
                int i = 0;
                int left = i * (gap * 2);
                while (left<len)
                {
                    int right = (i + 1) * (gap * 2) - 1;
                    if (right >= len)
                    {
                        right = len - 1;
                    }

                    MergeSort(numbers, left, right);
                    i++;
                    left = i * (gap * 2);
                }
                gap *= 2;
            }

        }
        /// <summary>
        /// 分别对left to mid,mid+1 to right两组进行排序
        /// </summary>
        /// <param name="number"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void MergeSort(int[] numbers, int left, int right)
        {
            if (right <= left) return;
            int mid = left + (right - left) / 2;

            int[] nums = new int[right - left + 1];
            int index = 0;
            int i = left;
            int j = mid + 1;
            while (i <= mid && j <= right)
            {
                if (numbers[i] <= numbers[j])
                {
                    nums[index++] = numbers[i++];
                }
                else
                {
                    nums[index++] = numbers[j++];
                }
            }

            while (i <= mid)
            {
                nums[index++] = numbers[i++];
            }

            while (j <= right)
            {
                nums[index++] = numbers[j++];
            }

            for (int n = 0; n < index; n++)
            {
                numbers[left + n] = nums[n];
            }
        }

        /// <summary>
        /// 归并
        /// 递归
        /// 递归方式就是不断拆分数组，直到数组长度为1，然后不断归并
        /// </summary>
        /// <param name="numbers"></param>
        public void MergeSortRecursive(int[] numbers)
        {
            int len = numbers.Length;
            if (len < 2) return;
            MergeSortRecursive(numbers, 0, len - 1);
        }
        private void MergeSortRecursive(int[] numbers, int left, int right)
        {
            if (left >= right) return;
            int mid = left + (right - left) / 2;
            //int mid = (left + right) / 2;
            MergeSortRecursive(numbers, left, mid);
            MergeSortRecursive(numbers, mid + 1, right);

            int[] nums = new int[right - left + 1];
            int index = 0;
            int i = left;
            int j = mid + 1;
            while (i <= mid && j <= right)
            {
                if (numbers[i] <= numbers[j])
                {
                    nums[index++] = numbers[i++];
                }
                else
                {
                    nums[index++] = numbers[j++];
                }
            }

            while (i <= mid)
            {
                nums[index++] = numbers[i++];
            }

            while (j <= right)
            {
                nums[index++] = numbers[j++];
            }

            for (int n = 0; n < index; n++)
            {
                numbers[left + n] = nums[n];
            }

        }


        /// <summary>
        /// 归并
        /// 自然归并
        /// </summary>
        /// <param name="numbers"></param>
        public void MergeSortNatural(int[] numbers)
        {

        }

    }
}
