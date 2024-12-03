using Chaper_5.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Bai_Tap
{
    internal class Bai_3
    {

        public Bai_3()
        {
            /*
                Convert 10 to 3
                34 / 3 = 11 _1
                11 / 3 = 3 _2
                3 / 3 = 1 _0
                1 / 3 = 0 _1
                (34)10 = (1021)3
             */
            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Base Number: ");
            int baseNumber = int.Parse(Console.ReadLine());
            StackApp stack = new StackApp();
            Console.WriteLine($"Conver {num} from 10 to {baseNumber}: ");

            while(num !=0)
            {
                stack.Push(num % baseNumber);
                num /= baseNumber;
            }

            while (!stack.Empty())
            {
                Console.Write(stack.Top());
                stack.Pop();
            }

        }
    }
}
