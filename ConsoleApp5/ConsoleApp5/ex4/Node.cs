using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.ex4
{
    internal class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node()
        {
            left = null;
            right = null;
        }

        public Node(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
}
