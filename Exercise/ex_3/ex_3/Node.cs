using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    internal class Node
    {
        public Object value;
        public Node next;
        public Node()
        {
            next = null;
            value = null;
        }

        public Node(Object v)
        {
            value = v;
            next = null;
        }
    }
}
