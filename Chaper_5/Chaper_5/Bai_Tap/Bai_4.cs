using Chaper_5.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Bai_Tap
{
    internal class Bai_4
    {
        public Bai_4()
        {
            /*
                Bieu thuc toan hoc hau to
                635+-432*++ = 8
             */

            Console.WriteLine("Enter Your Expression: ");
            string expression = Console.ReadLine();
            StackApp stack = new StackApp();

            foreach (char e in expression)
            {
               
                if (e == '+' || e == '-' || e == '*' || e == '/')
                {
                    int num = (int)stack.Pop();
                    int result = (int)stack.Pop();
                    
                    switch (e)
                    {
                        case '+':
                            result += num;
                            break;
                        case '-':
                            result -= num;
                            break;
                        case '*':
                            result *= num;
                            break;
                        case '/':
                            result /= num;
                            break;
                    }

                    stack.Push(result);
                }
                else
                {
                    stack.Push((char)e - 48);// '1' = 49, '2' = 50
                }
            }

            Console.WriteLine("Result: " + stack.Top());
        }
    }
}
