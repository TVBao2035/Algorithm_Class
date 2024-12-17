using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Cau2
{
    internal class LinkedList
    {
        public Node root;
        public LinkedList()
        {
            root = null;
        }

        public void print()
        {
            Node curr = root;
            while (curr != null)
            {
                Console.Write(curr.value);
                if (curr.next != null) Console.Write("->");
                curr = curr.next;
            }
        }
        public void addBefore(int Q, int X)
        {
            if (root == null) return;
            Node newNode = new Node(X);
            if ((int)root.value == Q)
            {
                newNode.next = root;
                root = newNode;
                return;
            }
            Node curr = root;
            while (curr.next != null)
            {
                if ((int)curr.next.value == Q)
                {
                    newNode.next = curr.next;
                    curr.next = newNode;
                    return;
                }
                curr = curr.next;
            }


        }
        public void addNode(int x)
        {
            if (root == null)
            {
                root = new Node(x);
                return;
            }
            Node curr = root;
            while (curr.next != null) curr = curr.next;
            curr.next = new Node(x);

        }
    }
}
