using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau2
{
    internal class Node
    {
        public object value;
        public Node next;
        public Node()
        {
            next = null;
        }

        public Node(int value)
        {
            this.value = value;
            next = null;
        }
    }
}
