using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_15
    {
        public Bai_1_15(LinkedList list)
        {
            Console.WriteLine("Bai 1.15: Xoa Node Sau Node P");
            list.Print();
            Console.WriteLine("Enter Node P:");
            int p = int.Parse(Console.ReadLine());
            if (list.first == null) return;
          
            Node currNode = list.first;
            while(currNode != null)
            {
                if (currNode.value.Equals(p) && currNode.next != null)
                {
                    currNode.next = currNode.next.next;
                    list.Print();
                    return;
                }
                currNode = currNode.next;
            }
            list.Print();
        }
    }
}
