using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.LinkedList
{
    /// <summary>
    /// 约瑟夫环（约瑟夫问题）是一个数学的应用问题：已知n个人（以编号1，2，3...n分别表示）围坐在一张圆桌周围。
    /// 从编号为k的人开始报数，数到m的那个人出列；他的下一个人又从1开始报数，数到m的那个人又出列；
    /// 依此规律重复下去，直到圆桌周围的人全部出列
    /// </summary>
    public class JosephProblem
    {
        private readonly int numberCount;
        private Node<int> tail;
        public JosephProblem(int numberCount)
        {
            this.numberCount = numberCount;
            tail = null;
        }
        private void Append(int data)
        {
            Node<int> newNode = new Node<int>(data);
            if (tail == null)
            {
                tail = newNode;
                tail.next = tail;
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
                tail = newNode;
            }
        }

        private void Print()
        {
            if (tail == null)
                return;
            Node<int> slider = tail.next;
            while (slider != tail)
            {
                Console.Write($"{slider.data} ");
                slider = slider.next;
            }
            Console.Write($"{tail.data} ");
            Console.WriteLine();
        }
        private void Initialize()
        {
            for (int i = 0; i < numberCount; i++)
            {
                Append(i + 1);
            }
        }

        /// <summary>
        /// 输出
        /// </summary>
        /// <param name="from">开始编号 minium=0</param>
        /// <param name="count">循环报数,minimu=1</param>
        public void JosephIt(int count)
        {
            Initialize();
            Console.WriteLine("Start Joseph Problem");
            Console.WriteLine($"condition Numbers {numberCount} count={count}");
            Print();

            int i = 0;
            //当前游标，从尾巴开始
            Node<int> slider = tail;
            //当前游标的前一个结点
            Node<int> previous;
            //tail==null说明空，slider.next==slider说明就剩下一个
            while (tail != null && slider.next != slider)
            {
                previous = slider;
                slider = slider.next;
                i++;
                //当前游标到要删除结点位置的时候
                if (i % count == 0)
                {
                    Console.WriteLine($"##[{slider.data}]");
                    //test
                    ResultList.Add(slider.data);
                    previous.next = slider.next;

                    if (slider == tail)
                    {
                        tail = previous;
                    }
                    //Print();
                }
            }
            Console.WriteLine($"Survived##[{slider.data}]");

            Console.WriteLine("Rounds Completed");
        }
        //for test
        public List<int> ResultList { get; set; } = new List<int>();


    }
}
