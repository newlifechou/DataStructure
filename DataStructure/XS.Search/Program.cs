using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.Search
{
    public class Program
    {
        public static void Main()
        {
            int[] s = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            SearchCollection op = new SearchCollection();
            int index=op.SearchByFib(s, 3);
            Console.WriteLine(index);


            Console.WriteLine("done");
            Console.Read();
        }
    }
}
