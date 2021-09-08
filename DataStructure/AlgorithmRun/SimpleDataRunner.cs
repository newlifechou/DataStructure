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
            SimpleData simple = new SimpleData();
            var data = simple.GetOrderedArray();
            simple.Shuffle(data);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public void Run2()
        {
            throw new NotImplementedException();
        }

        public void Run3()
        {
            throw new NotImplementedException();
        }

        public void Run4()
        {
            throw new NotImplementedException();
        }
    }
}
