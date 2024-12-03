using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chaper_4.Bai_1.Setup;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_16
    {
        public Bai_1_16(LinkedList list)
        {
            Console.WriteLine("Bai 1.16: Xoa Node Dau");
            list.Print();
            Console.WriteLine("Delete the first node in linked list:");
            list.RemoveFirst();
            list.Print();
        }
    }
}
