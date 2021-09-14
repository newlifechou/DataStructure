using System;

namespace AlgorithmRun
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunner run = new SimpleDataRunner();

            run.Run4();
            run.Run5();


            Console.Read();
        }
    }
}
