using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.String
{
    public class StringTest
    {
        public int IndexViaViolent(string source, string pattern)
        {
            int sourceCursor = 0;
            int i = sourceCursor, j = 0;

            while (i < source.Length && j < pattern.Length)
            {
                if (source[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    sourceCursor++;
                    i = sourceCursor;
                    j = 0;
                }
            }

            if (j >= pattern.Length)
            {
                return sourceCursor;
            }
            else
            {
                return -1;
            }

        }

        public int IndexViaKMP(string source,string pattern)
        {

        }

    }
}
