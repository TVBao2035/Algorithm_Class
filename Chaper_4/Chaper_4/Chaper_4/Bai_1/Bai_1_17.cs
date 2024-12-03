using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_17
    {
        public Bai_1_17(LinkedList list)
        {
            Console.WriteLine("Bai 1.17: Xoa Node Cuoi");
            list.Print();
            Console.WriteLine("Delete the end node in linked list:");
            list.Remove();
            list.Print();
        }
    }
}
