using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AlgorithmBasic
{
    public class SimpleAlgorithmVoid
    {
        /// <summary>
        /// a+b+c=1000;a^2+b^2=C^2，get a b c
        /// </summary>
        public void Solve1()
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int a = 1; a < 1001; a++)
            {
                for (int b = 1; b < 1001; b++)
                {
                    for (int c = 1; c < 1001; c++)
                    {
                        if (a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            Console.WriteLine($"a={a} b={b} c={c}");
                        }
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Elapsed:{sw.ElapsedMilliseconds}");
        }


        public void Solve2()
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int a = 1; a < 1001; a++)
            {
                for (int b = 1; b < 1001; b++)
                {
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(1000 - a - b, 2))
                    {
                        Console.WriteLine($"a={a} b={b} c={1000-a-b}");
                    }
                }
            }
            sw.Stop();
            Console.WriteLine($"Elapsed:{sw.ElapsedMilliseconds}");
        }


    }
}
