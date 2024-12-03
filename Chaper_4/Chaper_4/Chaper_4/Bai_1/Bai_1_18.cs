using Chaper_4.Bai_1.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1
{
    internal class Bai_1_18
    {
        public Bai_1_18(LinkedList list)
        {
            Console.WriteLine("Bai 1.18: Xoa Tat Ca");
            list.Print();
            Console.WriteLine("Delete All Node In Linked List:");
            list.first = null;
            list.Print();
        }
    }
}
