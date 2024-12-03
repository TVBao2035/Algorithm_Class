using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_9
    {
        public Bai_1_9(LinkedList list)
        {
            Console.WriteLine("Bai 1.9: Node Lon Nhat");
            list.Print();
            Node currNode = list.first;
            Node maxNode = list.first;
            while(currNode != null)
            {
                if(int.Parse(currNode.value.ToString()) > int.Parse(maxNode.value.ToString()))
                {
                    maxNode = currNode;
                }
                currNode = currNode.next;
            }

            Console.WriteLine($"Max Node Value: {maxNode.value}");
        }
    }
}
