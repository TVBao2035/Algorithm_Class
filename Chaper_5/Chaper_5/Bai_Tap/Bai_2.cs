using Chaper_5.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Bai_Tap
{
    internal class Bai_2
    {
        public Bai_2()
        {
            Console.Write("Enter your string: ");
            string yourString = Console.ReadLine();
            StackApp stack = new StackApp();
            
            for(int i=0; i<yourString.Length; i++)
            {
                stack.Push(yourString[i]);
            }

            string reverseString = "";

            while (!stack.Empty())
            {
                reverseString += stack.Top();
                stack.Pop();
            }
            Console.Clear();
            Console.WriteLine("Your String: " + yourString);
            Console.WriteLine("Reverse String : " + reverseString);

        }
    }
}
