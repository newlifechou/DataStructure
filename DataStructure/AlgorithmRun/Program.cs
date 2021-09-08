using System;

namespace AlgorithmRun
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunner run = new SimpleDataRunner();

            run.Run1();


            Console.Read();
        }
    }
}
