using AlgorithmBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmRun
{
    class SimpleDataRunner : IRunner
    {
        public void Run1()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            Console.WriteLine(simple.Fish_Count1());
        }

        public void Run2()
        {
            SimpleData simple = new SimpleData();
            var data = simple.GetOrderedArray();
            simple.Shuffle(data);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public void Run3()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            int result = simple.DiuFanTu_Age();
            Console.WriteLine(result);
        }

        public void Run4()
        {
            SimpleAlgorithmVoid simple = new SimpleAlgorithmVoid();
            simple.Solve1();
        }

        public void Run5()
        {
            SimpleAlgorithmVoid simple = new SimpleAlgorithmVoid();
            simple.Solve2();
        }
    }
}
