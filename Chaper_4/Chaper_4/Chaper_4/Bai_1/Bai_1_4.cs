using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_4
    {
        public Bai_1_4(LinkedList list)
        {
            Console.WriteLine("Bai 1.4: Them Node X Vao Dau Danh Sach");
            list.Print();
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            Node node = new Node(x);
            list.AddFirst(node);
            list.Print();

        }
    }
}
