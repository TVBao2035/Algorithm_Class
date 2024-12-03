using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_14
    {
        public Bai_1_14(LinkedList list)
        {
            Console.WriteLine("Bai 1.14: Xoa Node X");
            list.Print();
            Console.Write("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Node currNode = list.first;
            if (list.first.value.Equals(x))
            {
                list.first = currNode.next;
            }
            while (currNode.next != null)
            {
                if (currNode.next.value.Equals(x))
                {
                    currNode.next = currNode.next.next;
                    break;
                }
                currNode = currNode.next;
            }
            list.Print();
            return;
           
        }
    }
}
