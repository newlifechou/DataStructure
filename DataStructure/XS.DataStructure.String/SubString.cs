using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.String
{
    public class SubString
    {
        /// <summary>
        /// 复杂度O(mn)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public int Index(string source, string pattern)
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
                    //或者i=i-j+1
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
 
    }
}
