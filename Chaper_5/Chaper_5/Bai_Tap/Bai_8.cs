using Chaper_5.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Bai_Tap
{
    internal class Bai_8
    {
        public Bai_8()
        {
            int n;
            do
            {
                Console.Write("Enter N : ");
                n = int.Parse(Console.ReadLine());
            }while (n < 2) ;
            StackApp stack = new StackApp();
            stack.Push(0);
            stack.Push(1);
            for(int i=2; i <= n; i++)
            {
                int top = (int)stack.Pop();
                int bottom = (int)stack.Pop();
                int res = top + bottom;
                stack.Push(top);
                stack.Push(res);
            }

            Console.WriteLine(stack.Top());
        }
    }
}
