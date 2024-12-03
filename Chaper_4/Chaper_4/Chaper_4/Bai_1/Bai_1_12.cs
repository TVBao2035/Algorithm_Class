using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_12
    {
        public Bai_1_12(LinkedList list)
        {
            Console.WriteLine("Bai 1.12: Dem Node Le");
            int countOddNode = 0;
            Node currNode = list.first;
            while(currNode != null)
            {
                int currNodeValue = int.Parse(currNode.value.ToString());
                if(currNodeValue%2 != 0)
                {
                    countOddNode++;
                }
                currNode = currNode.next;
            }
            Console.WriteLine("Number Of The Odd Node Value In Linked List: " + countOddNode);
        }
    }
}
