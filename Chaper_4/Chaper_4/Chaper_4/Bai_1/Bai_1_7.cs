using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_7
    {
        public Bai_1_7(LinkedList list)
        {
            Console.WriteLine("Bai 1.7: Them Node Y Vao Truoc Node X");
            list.Print();
            Console.WriteLine("Enter Y:");
            int y = int.Parse(Console.ReadLine());
            Node nodeY = new Node(y);
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Node nodeX = new Node(x);
            list.AddBefore(nodeY, nodeX);
            list.Print();
        }
    }
}
