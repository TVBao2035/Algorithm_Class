using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_1.Setup
{
    internal class Node
    {
        public object? value;
        public Node? next;

        public Node()
        {
            value = null;
            next = null;
        }

        public Node(object value)
        {
            this.value = value;
            next = null;
        }
    }
}
