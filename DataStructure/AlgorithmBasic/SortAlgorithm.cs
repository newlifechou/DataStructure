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
            MergeSort(numbers, 0, numbers.Length - 1);
        }
        /// <summary>
        /// 分别对left to mid,mid+1 to right两组进行排序
        /// </summary>
        /// <param name="number"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void MergeSort(int[] numbers, int l, int r)
        {
            if (l >= r) return;
            int mid = l + (r - l) / 2;
            MergeSort(numbers, l, mid);//left
            MergeSort(numbers, mid + 1, r);//right

            Merge(numbers, l, mid, r);
        }

        private void Merge(int[] numbers, int l, int mid, int r)
        {
            int[] temp = new int[numbers.Length];

            int i = l;
            int m = mid;
            int j = mid + 1;
            int n = r;
            int k = 0;

            while (i <= m && j <= n)
            {
                if (numbers[i] <= numbers[j])
                {
                    temp[k++] = numbers[i++];
                }
                else
                {
                    temp[k++] = numbers[j++];
                }
            }

            while (i <= m)
            {
                temp[k++] = numbers[i++];
            }

            while (j <= n)
            {
                temp[k++] = numbers[j++];
            }

            for (int ii = 0; ii < k; ii++)
            {
                numbers[l + ii] = temp[ii];
            }

        }

        /// <summary>
        /// 归并基础
        /// 将有序数组a，b合并为c
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <param name="m"></param>
        /// <param name="c"></param>
        public void MergeArray(int[] a, int n, int[] b, int m, int[] c)
        {
            int i, j, k;
            i = j = k = 0;
            while (i < n && j < m)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }

            while (i < n)
            {
                c[k++] = a[i++];
            }
            while (j < m)
            {
                c[k++] = b[j++];
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
            MergeSortRecursive(numbers, 0, numbers.Length - 1);
        }
        private void MergeSortRecursive(int[] numbers, int l, int r)
        {
            if (l >= r) return;
            int mid = l + (r - l) / 2;//这样写不容易溢出
            //int mid = (left + right) / 2;
            MergeSortRecursive(numbers, l, mid);
            MergeSortRecursive(numbers, mid + 1, r);

            int[] nums = new int[r - l + 1];
            int index = 0;
            int i = l;
            int j = mid + 1;
            while (i <= mid && j <= r)
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

            while (j <= r)
            {
                nums[index++] = numbers[j++];
            }

            for (int n = 0; n < index; n++)
            {
                numbers[l + n] = nums[n];
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


        /// <summary>
        /// 快速排序
        /// 递归思想
        /// D&C思想
        /// 选取一个pivot值，从左右同时开始扫描，小于排左边，大于排右边
        /// 不断递归
        /// </summary>
        /// <param name="numbers"></param>
        public void QuickSort(int[] numbers)
        {
            QuickSort(numbers, 0, numbers.Length - 1);
        }

        private void QuickSort(int[] numbers, int l, int r)
        {
            if (l >= r) return;

            int i = l;
            int j = r;
            int pivot = numbers[l];//选取第一个作为pivot，也可以随机选

            while (i < j)
            {
                //from right to left find smaller
                while (i < j && numbers[j] >= pivot)
                {
                    j--;
                }

                if (i < j)
                {
                    numbers[i] = numbers[j];
                    i++;
                }

                //from left to right find bigger
                while (i < j && numbers[i] < pivot)
                {
                    i++;
                }

                if (i < j)
                {
                    numbers[j] = numbers[i];
                    j--;
                }

            }

            numbers[i] = pivot;
            QuickSort(numbers, l, i - 1);
            QuickSort(numbers, i + 1, r);
        }


    }
}
