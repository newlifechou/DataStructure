using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasic
{
    public class SimpleAlgorithm
    {

        /// <summary>
        /// 炸弹人
        /// 墙壁不能被炸
        /// 只能空地放炸弹
        /// 炸弹威力十字形无限
        /// </summary>
        public void BombMan()
        {
            char[][] map = {
                new char[]{'#','#','#','#','#','#','#','#','#','#','#','#'},
                new char[]{'#','G','G','.','G', 'G','#','#', '#', '#', '#', '#' },
                new char[]{'#','G', 'G', 'G', '.', 'G','#','#', '#', '#', '#', '#' },
                new char[]{'#','G', 'G','#','#', 'G', 'G', '.', '#', '#', '#', '#' },
                new char[]{'#', 'G','#', 'G', 'G', '.', 'G', '#', '#', '#', '#', '#' },
                new char[]{'#','#','#', 'G', 'G', '.', 'G', 'G', '#', '#', '#', '#' },
                new char[]{'#','#','#', 'G', 'G', '.', 'G', 'G', '#', '#', '#', '#' },
                new char[]{'#','#','#','#','#','#','#','#','#','#','#','#'}
            };

            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    Console.Write(map[i][j]);
                }
                Console.WriteLine();
            }

            int sum = 0;
            int x, y;
            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    sum = 0;
                    if (map[i][j] == '.')
                    {
                        sum = 0;

                        //up
                        x = i;
                        y = j;
                        while (map[x][y] != '#')
                        {
                            if (map[x][y] == 'G')
                            {
                                sum++;
                            }
                            x--;
                        }

                        //down
                        x = i;
                        y = j;
                        while (map[x][y] != '#')
                        {
                            if (map[x][y] == 'G')
                            {
                                sum++;
                            }
                            x++;
                        }

                        //left
                        x = i;
                        y = j;
                        while (map[x][y] != '#')
                        {
                            if (map[x][y] == 'G')
                            {
                                sum++;
                            }
                            y--;
                        }

                        //right
                        x = i;
                        y = j;
                        while (map[x][y] != '#')
                        {
                            if (map[x][y] == 'G')
                            {
                                sum++;
                            }
                            y++;
                        }
                    }
                    if (sum != 0)
                    {
                        Console.WriteLine($"{i},{j}={sum}");
                    }
                }
            }

        }

        public int[] RemoveRepeat(int[] nums)
        {
            int len = nums.Max() + 1;
            int[] temp = new int[len];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                temp[nums[i]] += 1;
            }

            List<int> result = new List<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > 0)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// ab+cd=ef
        /// </summary>
        public void NumberPlusMatch()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            for (int e = 1; e < 10; e++)
                            {
                                for (int f = 1; f < 10; f++)
                                {
                                    if (a != b && b != c && c != d && d != e
                                        && e != f && a != c && a != d
                                        && a != e && a != f)
                                    {
                                        if (a * 10 + b + c * 10 + d == e * 10 + f)
                                        {
                                            Console.WriteLine($"{a}{b}+{c}{d}={e}{f}");
                                        }
                                    }


                                }
                            }
                        }
                    }
                }
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }


        /// <summary>
        /// 纸牌游戏，小猫钓鱼
        /// 两个人每人有一副牌，一次摆放在桌子上，当刚放下的一张牌和之前的某一张一样的时候，这两张一样的牌包括中间的纸牌都可以被收走，放到这个人的队尾
        /// 两个队列一个栈
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool PokerGame(int[] a, int[] b)
        {
            Queue<int> aa = new Queue<int>();
            Queue<int> bb = new Queue<int>();

            for (int i = 0; i < a.Length; i++)
            {
                aa.Enqueue(a[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                bb.Enqueue(b[i]);
            }

            Stack<int> gamepool = new Stack<int>();


            int temp = 0;
            bool isAwin = false, isBwin = false;
            while (aa.Count > 0 && bb.Count > 0)
            {
                //a turn
                temp = aa.Dequeue();
                isAwin = false;
                foreach (var item in gamepool)
                {
                    if (item == temp)
                    {
                        isAwin = true;
                        break;
                    }
                }

                if (isAwin)
                {
                    aa.Enqueue(temp);

                    int pop = 0;
                    //注意这里得用do while
                    do
                    {
                        pop = gamepool.Pop();
                        aa.Enqueue(pop);
                    } while (pop != temp);

                    isAwin = false;
                }
                else
                {
                    gamepool.Push(temp);
                }
                temp = 0;

                //b turn

                temp = bb.Dequeue();
                isBwin = false;
                foreach (var item in gamepool)
                {
                    if (item == temp)
                    {
                        isBwin = true;
                        break;
                    }
                }

                if (isBwin)
                {
                    bb.Enqueue(temp);

                    int pop = 0;
                    do
                    {
                        pop = gamepool.Pop();
                        bb.Enqueue(pop);
                    } while (pop != temp);

                    isBwin = false;
                }
                else
                {
                    gamepool.Push(temp);
                }
                temp = 0;

            }


            return aa.Count > 0;//true = a win,false=a lose.
        }



        /// <summary>
        /// 判断是否是回文
        /// 利用栈来判断
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindromicSubString(string s)
        {
            int len = s.Length;
            int mid = len / 2 - 1;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= mid; i++)
            {
                stack.Push(s[i]);
            }

            int next;
            if (len % 2 == 0)
            {
                next = mid + 1;
            }
            else
            {
                next = mid + 2;
            }

            for (int i = next; i < len; i++)
            {
                if (s[i] != stack.Pop())
                {
                    break;
                }
            }

            return stack.Count == 0;

        }


        /// <summary>
        /// 计算最小公倍数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int GetLeastCommonMutiple(int a, int b)
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
        public int GetLargestCommonVidisor(int a, int b)
        {
            int max = a > b ? a : b;
            int min = a < b ? a : b;

            int remainder = 0;
            while (min != 0)
            {
                remainder = max % min;
                max = min;
                min = remainder;
            }
            return max;
        }

        /// <summary>
        /// 斐波那契数 第n项
        /// 递归
        /// Fibonacci
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int Fibonacci(int number)
        {
            if (number < 0)
            {
                return -1;
            }

            if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }


        /// <summary>
        /// 找出最大值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Index</returns>
        public Tuple<int, int> Max(int[] nums)
        {
            int max_value = nums[0];
            int max_index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max_value)
                {
                    max_value = nums[i];
                    max_index = i;
                }
            }
            return new Tuple<int, int>(max_index, max_value);
        }

        /// <summary>
        /// 阶乘n!
        /// 利用了递归
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Factorial(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }

        /// <summary>
        /// 利用递归来求和
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int RecursionSum(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                var subNums = numbers.Skip(1).ToArray();
                return numbers[0] + RecursionSum(subNums);
            }
        }

        public int RecursionCount(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                var subNums = numbers.Skip(1).ToArray();
                return 1 + RecursionCount(subNums);
            }
        }

        /// <summary>
        /// 利用递归来找出最大值
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int RecursionMax(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers[0];
            }
            var subNums = numbers.Skip(1).ToArray();
            int temp = RecursionMax(subNums);
            if (numbers[0] > temp)
            {
                return numbers[0];
            }
            else
            {
                return temp;
            }
        }


        /// <summary>
        /// 10个互不相等的整数，求其中的第2大的数字，要求数组不能用排序
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindSecondMax(int[] numbers)
        {
            int max_first = numbers[0], max_second = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max_first)
                {
                    max_second = max_first;
                    max_first = numbers[i];
                }
                else if (numbers[i] > max_second)
                {
                    max_second = numbers[i];
                }
            }
            return max_second;
        }

        /// <summary>
        /// 是否质数
        /// </summary>
        public bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 将大于2的偶数分解成两个素数之和
        /// </summary>
        /// <param name="n"></param>

        public Tuple<int, int> GetPrimePair(int n)
        {
            if (n % 2 != 0 || n < 2)
            {
                return null;
            }

            for (int i = 2; i < n / 2; i++)
            {
                if (IsPrime(i) && IsPrime(n - i))
                {
                    return Tuple.Create(i, n - i);
                }
            }

            return Tuple.Create(-1, -1);
        }


        /// <summary>
        /// 判断是否是闰年
        /// 公历闰年的精确计算方法：（按一回归年365天5小时48分45.5秒）
        /// 普通年能被4整除而不能被100整除的为闰年。 （如2004年就是闰年，1900年不是闰年）
        /// 世纪年能被400整除而不能被3200整除的为闰年。 (如2000年是闰年，3200年不是闰年)
        /// 对于数值很大的年份能整除3200,但同时又能整除172800则又是闰年。(如172800年是闰年，86400年不是闰年）
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public bool IsLeapYear(int year)
        {
            bool isLeap = false;
            isLeap = (year % 4 == 0 && year % 100 != 0);
            isLeap = isLeap || (year % 400 == 0 && year % 3200 != 0);
            isLeap = isLeap || (year % 3200 == 0 && year % 172800 == 0);

            return isLeap;
        }

        /// <summary>
        /// 按照日期获取是当年的第几天
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int GetDaysByDate(DateTime date)
        {
            Dictionary<int, int> days_of_month = new Dictionary<int, int>();
            days_of_month.Add(1, 31);
            if (IsLeapYear(date.Year))
            {
                days_of_month.Add(2, 29);
            }
            else
            {
                days_of_month.Add(2, 28);
            }
            days_of_month.Add(3, 31);
            days_of_month.Add(4, 30);
            days_of_month.Add(5, 31);
            days_of_month.Add(6, 30);
            days_of_month.Add(7, 31);
            days_of_month.Add(8, 31);
            days_of_month.Add(9, 30);
            days_of_month.Add(10, 31);
            days_of_month.Add(11, 30);
            days_of_month.Add(12, 31);

            int days = 0;

            for (int i = 1; i < date.Month; i++)
            {
                days += days_of_month[i];
            }
            days += date.Day;
            return days;
        }

        /// <summary>
        /// 渔夫分鱼
        /// A、B、C、D、E5个渔夫夜间合伙捕鱼，各自在河边的树丛中休息。待日上三竿，渔夫A第一个醒来，他将鱼分作5份，把多余的一条扔回河中，拿自己的一份回家了。渔夫B第二个醒来，也将鱼分作5份，扔掉多余的一条，拿走自己的一份，接着后三个也按同样的办法分鱼，问5个渔夫至少合伙捕了多少条鱼。
        /// </summary>
        /// <returns></returns>
        public int Fish_Count1()
        {
            int total = 0;
            for (int j = 0; j < int.MaxValue; j++)
            {
                total = j;
                for (int i = 0; i < 5; i++)
                {
                    if (total < 1)
                    {
                        break;
                    }

                    total -= 1;
                    if (total % 5 != 0)
                    {
                        break;
                    }

                    int one_share = total / 5;
                    total = one_share * 4;

                    //如果循环到最后一个人，说明找到了
                    if (i == 4)
                    {
                        return j;
                    }

                }
            }

            return -1;
        }


        /// <summary>
        /// 渔夫分鱼
        /// 使用递归的方式
        /// </summary>
        /// <returns></returns>
        private static int num = 1;
        public int Fish_Count2(int person)
        {
            int total = 0;
            if (person == 1)
            {
                total = num * 5 + 1;
                num++;
                return total;
            }
            else
            {
                while (true)
                {
                    total = Fish_Count2(person - 1);
                    if (total % 4 != 0 || total <= 0)
                    {
                        continue;
                    }
                    else
                    {
                        int one_share = total / 4;
                        total = one_share * 5;
                        total += 1;
                        return total;
                    }
                }
            }


        }

        /// <summary>
        /// 丢番图的一生1/6是童年，青少年时代占了他一生的1/12，随后1/7他说过着独身的生活，结婚后5年他生了一个儿子，他感到很幸福，可是这孩子的生命只有他父亲的一半，儿子去世后，丢番图就在深深痛苦中活了4年，结束了生命，请问丢番图活了多少岁?
        /// </summary>
        /// <returns></returns>
        public int DiuFanTu_Age()
        {
            for (int i = 0; i < 200; i++)
            {
                if (i == (i / 6.0 + i / 12.0 + i / 7.0 + 5.0 + i / 2.0 + 4.0))
                {
                    return i;
                }
            }
            return 0;
        }



    }
}
