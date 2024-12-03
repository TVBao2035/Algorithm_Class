using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_8
    {
        public Bai_1_8(LinkedList list)
        {
            int option;
            do
            {
                Console.WriteLine("Bai 1.8: Tim Node ");
                Console.WriteLine("[1]. Bai 1.8.1");
                Console.WriteLine("[2]. Bai 1.8.2");
                Console.WriteLine("[3]. Bai 1.8.3");
                Console.Write("Enter Option: ");
                option = int.Parse(Console.ReadLine());
            } while (option < 1 || option > 3);

            switch (option)
            {
                case 1:
                    Bai_1_8_1(list);
                    Console.ReadLine();
                    break;
                case 2:
                    Bai_1_8_2(list);
                    Console.ReadLine();
                    break;
                case 3:
                    Bai_1_8_2(list);
                    Console.ReadLine();
                    break;
            }
        }
        public void Bai_1_8_3(LinkedList list)
        {
            Console.WriteLine("Bai 1.8.3: Tim Node Truoc Node X");
            list.Print();
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Node currNode = list.first;

            if (currNode.value.Equals(x))
            {
                Console.WriteLine("Find Success This Node is the first node : " + currNode.value);
                return;
            }
            while(currNode.next != null)
            {
                if (currNode.next.value.Equals(x))
                {
                    Console.WriteLine("Find Success Node Prerious: " + currNode.value);
                    return;
                }
                currNode = currNode.next;
            }
            Console.WriteLine("Not Found");
        }

        public void Bai_1_8_2(LinkedList list)
        {
            Console.WriteLine("Bai 1.8.2: Tim Node Sau Node X");
            list.Print();
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Node currNode = list.first;
            while(currNode != null)
            {
                if (currNode.value.Equals(x) && currNode.next != null)
                {
                    Console.WriteLine("Find Success Node Next: " + currNode.next.value);
                    return;
                }
                else if(currNode.value.Equals(x) && currNode.next == null)
                {
                    Console.WriteLine("Find Success This Node Is The End Node: " + currNode.value);
                    return;
                }
                currNode = currNode.next;
            }
            Console.WriteLine("Not Found");

        }
        
        public void Bai_1_8_1(LinkedList list)
        {
            Console.WriteLine("Bai 1.8.1: Tim Node X");
            list.Print();
            Console.WriteLine("Enter X: ");
            int x = int.Parse(Console.ReadLine());
            Node nodeX = new Node(x);
            Node res = list.Find(nodeX);
            if(res == null)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Find Success: " + res.value);
            }
        }
    }
}
