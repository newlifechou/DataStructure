using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.String
{
    /// <summary>
    /// KMP算法
    /// 这个算法的基本思路就是利用patter字符串的各个子字符串的前缀和后缀相同，来减少无效移动
    /// S串尽量不回退，修改P串对应位置
    /// </summary>
    public class KMPSolution
    {
        /// <summary>
        /// KMP算法
        /// 复杂度O(m+n)
        /// 充分利用了目标字符串ptr的性质
        /// 比如里面部分字符串的重复性，即使不存在重复字段，在比较时，实现最大的移动量
        /// kmp算法的核心即是计算字符串f每一个位置之前的字符串的前缀和后缀公共部分的最大长度
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public int Index(string source, string pattern)
        {
            int i = 0;
            int j = 0;
            int slen = source.Length;
            int plen = pattern.Length;

            while (i < slen && j < plen)
            {
                //-1代表
                if (j == -1 || source[i] == pattern[j])
                {
                    j++;
                    i++;
                }
                else
                {
                    j = Next(j);
                }
            }

            //全部匹配
            if (j == plen)
            {
                return i - j;
            }
            else
            {
                return -1;
            }

        }
        /// <summary>
        /// 对应位置的next值
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private int[] GetNextArray(string pattern)
        {
            int[] next = new int[pattern.Length];
            next[0] = -1;
            int k = -1;
            int j = 0;
            while (j<pattern.Length-1)
            {
                if (k == -1 || pattern[j] == pattern[k])
                {
                    k++;
                    j++;
                    next[j] = k;
                }
                else
                {
                    k = next[k];
                }
            }

            return next;
        }


        /*
         next 数组各值的含义：代表当前字符之前的字符串中，有多大长度的相同前缀后缀。
         例如如果next [j] = k，代表j 之前的字符串中有最大长度为k 的相同前缀后缀。
         此也意味着在某个字符失配时，该字符对应的next 值会告诉你下一步匹配中，模式串应该跳到哪个位置（跳到next [j] 的位置）。如果next [j] 等于0或-1，则跳到模式串的开头字符，若next [j] = k 且 k > 0，代表下次匹配跳到j 之前的某个字符，而不是跳到开头，且具体跳过了k 个字符。
         */
    }
}
