using AlgorithmBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmRun
{
    class SimpleDataRunner
    {
        public void Run1()
        {
            SimpleAlgorithm simple = new SimpleAlgorithm();
            Console.WriteLine(simple.Fish_Count1());
        }

        public void Run10()
        {
            SimpleAlgorithm algorithm = new SimpleAlgorithm();
            algorithm.NumberPlusMatch();

        }

        public void Run()
        {
            SimpleAlgorithm algorithm = new SimpleAlgorithm();
            algorithm.BombMan();
        }

        public void Run12()
        {
            throw new NotImplementedException();
        }

        public void Run13()
        {
            throw new NotImplementedException();
        }

        public void Run14()
        {
            throw new NotImplementedException();
        }

        public void Run15()
        {
            throw new NotImplementedException();
        }

        public void Run2()
        {
            SimpleData simple = new SimpleData();
            var data = simple.GetOrderedArray(10);
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

        public void Run6()
        {
            throw new NotImplementedException();
        }

        public void Run7()
        {
            throw new NotImplementedException();
        }

        public void Run8()
        {
            throw new NotImplementedException();
        }

        public void Run9()
        {
            throw new NotImplementedException();
        }
    }
}
