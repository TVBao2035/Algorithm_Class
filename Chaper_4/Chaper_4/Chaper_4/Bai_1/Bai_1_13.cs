using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_13
    {
        public Bai_1_13(LinkedList list)
        {
            Console.WriteLine("Bai 1.13: Dem Node Le Nho Nhat");
            list.Print();
            Node minOddNode = FindMinOddNode(list);
            if(minOddNode == null)
            {
                Console.WriteLine($"There is no odd node value in linked list");
                return;
            }

            Node currNode = list.first;
            while(currNode != null)
            {
                if (currNode.value.Equals(minOddNode.value))
                {
                    Console.WriteLine(currNode.value);
                }
                currNode = currNode.next;
            }
        }

        public Node FindMinOddNode(LinkedList list)
        {
            Node result = null;
            Node currNode = list.first;
            while(currNode != null)
            {
                int currNodeValue = int.Parse(currNode.value.ToString());

                if( currNodeValue % 2 != 0 
                    && (result == null 
                    || currNodeValue < int.Parse(result.value.ToString())))
                {
                    result = currNode;
                }
                currNode = currNode.next;
            }
            return result;

        }
    }
}
