using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.StackQueue
{
    /// <summary>
    /// 使用栈来处理缀问题
    /// </summary>
    public class StackForAffix
    {
        private Stack<char> numbers;
        private Stack<char> operators;
        private StringBuilder sb;
        public StackForAffix()
        {
            numbers = new Stack<char>();
            operators = new Stack<char>();

            sb = new StringBuilder();
        }
        public string InfixToPostfix(string infix)
        {
            char[] input = infix.ToCharArray();
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }




    }
}
