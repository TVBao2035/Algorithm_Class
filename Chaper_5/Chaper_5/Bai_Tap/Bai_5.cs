using Chaper_5.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Bai_Tap
{
    internal class Bai_5
    {
        public Bai_5()
        {
            /*
                a + b - c + (a + b) + 
                a b c - + ab++
               

                abc-+

             */
            Console.WriteLine("Enter Your Expression: ");
            string yourExpression = Console.ReadLine();

            StackApp operatorStack = new StackApp();
            StackApp stack = new StackApp();
            for(int i=0; i< yourExpression.Length; i++)
            {
                if (yourExpression[i] == '(')
                {

                }
                else
                {

                }
            }
        }

    }
}
