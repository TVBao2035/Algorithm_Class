using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_6
    {
        public Bai_1_6(LinkedList list)
        {
            Console.WriteLine("Bai 1.6: Them Node X Vao Sau Node V");
            list.Print();
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Node nodeX = new Node(x);
            Console.WriteLine("Enter V:");
            int v = int.Parse(Console.ReadLine());
            Node nodeV = new Node(v);

            list.AddAfter(nodeX, nodeV);
            list.Print();
        }
    }
}
