using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex2
{
    internal class Node
    {
        public Object value;
        public Node next;
        public Node()
        {
            next = null;
        }

        public Node(Object value)
        {
            this.value = value;
            next = null;
        }
    }
}
