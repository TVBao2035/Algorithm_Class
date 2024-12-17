using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex2
{
    internal class Cau2
    {
        public Cau2()
        {
            int[] array = { 17, 83, 8, 78, 6, 5, 78, 5, 83, 40 };

            LinkedList linkedList = new LinkedList();

            foreach (int num in array) linkedList.AddNode(num);

            linkedList.print();

            Console.WriteLine("\nSum Of Average: " + linkedList.sumOfAverage());
        }
    }
}
