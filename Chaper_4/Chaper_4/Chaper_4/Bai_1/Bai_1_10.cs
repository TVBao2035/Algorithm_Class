using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_10
    {
        public Bai_1_10(LinkedList list)
        {
            Console.WriteLine("Bai 1.10: Node Chan Lon Nhat");
            Node MaxEvenNode = FindEvenNode(list);
            if(MaxEvenNode == null)
            {
                Console.WriteLine("There is no even number in linked list");
                return;
            }

            Node currNode = list.first;
            while(currNode != null)
            {
                int currNodeValue = int.Parse(currNode.value.ToString());
                int maxEvenNodeValue = int.Parse(MaxEvenNode.value.ToString());

                if (currNodeValue % 2 == 0 && currNodeValue > maxEvenNodeValue)
                {
                    MaxEvenNode = currNode;
                }
                currNode = currNode.next;
            }

            Console.WriteLine("Max Even Node Value " + MaxEvenNode.value);

        }

        public Node FindEvenNode(LinkedList list)
        {
            Node currNode = list.first;
        
            while(currNode != null)
            {
                if(int.Parse(currNode.value.ToString())%2 == 0)
                {
                    return currNode; 
                }
                currNode = currNode.next;
            }
          
            return null;

        }
    }
}
