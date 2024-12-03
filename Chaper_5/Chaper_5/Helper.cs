using Chaper_5.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5
{
    internal class Helper
    {
        public static void CreateStack<T>(T[] valueList, StackApp stack)
        {
            for(var i =0; i< valueList.Length; i++)
            {
                stack.Push(valueList[i]);
            }
        }
        public static void DisplayStack(StackApp stack)
        {
            while (!stack.Empty())
            {
                Console.WriteLine(stack.Top());
                stack.Pop();
            }
        }
    }
}
