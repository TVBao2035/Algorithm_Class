using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_3
    {
        public Bai_1_3(LinkedList list)
        {
            Console.WriteLine("Bai 1.3");
            Console.Write("- Bai 1.3.1 : ");
            list.Print();

            Console.Write("- Bai 1.3.2 : ");
            int sum = 0;
            Node currNode = list.first;
            while (currNode != null)
            {
                sum += int.Parse(currNode.value.ToString());
                currNode = currNode.next;
            }

            Console.WriteLine("Sum = " + sum);

            Console.Write("- Bai 1.3.3 : ");
            Console.WriteLine($"Sum Avarage : {(sum * 1.0) / list.Count()}");
        }
    }
}
