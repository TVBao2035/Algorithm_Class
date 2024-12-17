using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_6
{
    internal class Node
    {
        public int value;
        public Node? left;
        public Node? right;

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

        public void DisplayNode()
        {
            Console.WriteLine("Root Node: " + value);
            Console.Write("Left Node: ");
            if (left != null) Console.WriteLine(left.value);
            else Console.WriteLine("null");
            Console.Write("Right Node: ");
            if (right != null) Console.WriteLine(right.value);
            else Console.WriteLine("null");
        }
    }
}
